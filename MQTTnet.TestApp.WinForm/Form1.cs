// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="Haemmer Electronics">
//   Copyright (c) 2020 All rights reserved.
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using MQTTnet.Client;
using MQTTnet.Diagnostics;

namespace MQTTnet.TestApp.WinForm
{
    using System;
    using System.Text;
    using System.Timers;
    using System.Windows.Forms;

    using MQTTnet.Client.Connecting;
    using MQTTnet.Client.Disconnecting;
    using MQTTnet.Client.Options;
    using MQTTnet.Client.Receiving;
    using MQTTnet.Extensions.ManagedClient;
    using MQTTnet.Formatter;
    using MQTTnet.Protocol;
    using MQTTnet.Server;

    using Timer = System.Timers.Timer;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// The managed subscriber client.
        /// </summary>
        private IMqttClient _mqttClient1;
        private IMqttClient _mqttClient2;

        /// <summary>
        /// The MQTT server.
        /// </summary>
        private IMqttServer _mqttServer;

        /// <summary>
        /// The port.
        /// </summary>
        private string port = "1883";

        private TimeSpan _keepAlive = TimeSpan.FromSeconds(60);

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();

            var timer = new Timer
            {
                AutoReset = true,
                Enabled = true,
                Interval = 1000
            };

            timer.Elapsed += this.TimerElapsed;

#if DEBUG
            MqttNetGlobalLogger.LogMessagePublished += (s, e) =>
                {
                    var trace = $">> [{e.LogMessage.Timestamp:g}] [{e.LogMessage.ThreadId}] [{e.LogMessage.Source}] [{e.LogMessage.Level}]: {e.LogMessage.Message}";
                    if (e.LogMessage.Exception != null)
                    {
                        trace += Environment.NewLine + e.LogMessage.Exception.ToString();
                    }

                    Debug.WriteLine(trace);
                };


            var timeout = new Timer(400)
            {
                AutoReset = false,
                Enabled = true
            };
            //Auto create local server and connect
            timeout.Elapsed += (x, e) =>
            {
                ButtonServerStartClick(null, null);
                ButtonSubscriberStartClick(null, null);
                ButtonSubscriberStart2Click(null, null);
            };
#endif

        }

        /// <summary>
        /// Handles the publisher connected event.
        /// </summary>
        /// <param name="x">The MQTT client connected event args.</param>
        private static void OnPublisherConnected(MqttClientConnectedEventArgs x)
        {
            MessageBox.Show("Publisher Connected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the publisher disconnected event.
        /// </summary>
        /// <param name="x">The MQTT client disconnected event args.</param>
        private static void OnPublisherDisconnected(MqttClientDisconnectedEventArgs x)
        {
            MessageBox.Show("Publisher Disconnected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the subscriber connected event.
        /// </summary>
        /// <param name="x">The MQTT client connected event args.</param>
        private static void OnSubscriberConnected(MqttClientConnectedEventArgs x, MqttClientOptions options)
        {
            MessageBox.Show($"Subscriber {options.ClientId} Connected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the subscriber disconnected event.
        /// </summary>
        /// <param name="x">The MQTT client disconnected event args.</param>
        private static void OnSubscriberDisconnected(MqttClientDisconnectedEventArgs x)
        {
            if (x.AuthenticateResult != null)
            {
                MessageBox.Show($"Subscriber {x.AuthenticateResult.AssignedClientIdentifier} Disconnected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Subscriber Disconnected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        /// <summary>
        /// The method that handles the button click to start the server.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonServerStartClick(object sender, EventArgs e)
        {
            if (this._mqttServer != null)
            {
                return;
            }

            var storage = new JsonServerStorage();
            storage.Clear();
            this._mqttServer = new MqttFactory().CreateMqttServer();
            var options = new MqttServerOptions();
            options.DefaultEndpointOptions.Port = int.Parse(this.TextBoxPort.Text);
            options.Storage = storage;
            options.EnablePersistentSessions = true;
            options.ConnectionValidator = new MqttServerConnectionValidatorDelegate(
                c =>
                {
                    if (c.Username != "username")
                    {
                        c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                        return;
                    }

                    if (c.Password != "password")
                    {
                        c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                        return;
                    }

                    c.ReasonCode = MqttConnectReasonCode.Success;
                });

            try
            {
                await this._mqttServer.StartAsync(options);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await this._mqttServer.StopAsync();
                this._mqttServer = null;
            }
        }

        /// <summary>
        /// The method that handles the button click to stop the server.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonServerStopClick(object sender, EventArgs e)
        {
            if (this._mqttServer == null)
            {
                return;
            }

            await this._mqttServer.StopAsync();
            this._mqttServer = null;
        }

        /// <summary>
        /// The method that handles the button click to subscribe to a certain topic.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonSubscribeClick(object sender, EventArgs e)
        {
            var topic = this.TextBoxTopicSubscribed.Text.Trim();
            await this._mqttClient1.SubscribeAsync(topic,MqttQualityOfServiceLevel.AtLeastOnce);

            if (!this.ListBoxSubscribedTopics.Items.Contains(topic))
            {
                this.ListBoxSubscribedTopics.Items.Add(topic);
                this.ListBoxSubscribedTopics.SelectedItem = topic;
            }

            MessageBox.Show("Topic " + this.TextBoxTopicSubscribed.Text.Trim() + " is subscribed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// The method that handles the button click to subscribe to a certain topic.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonSubscribe2Click(object sender, EventArgs e)
        {
            var topic = this.TextBoxTopicSubscribed2.Text.Trim();
            await this._mqttClient2.SubscribeAsync(topic,MqttQualityOfServiceLevel.AtLeastOnce);

            if (!this.ListBoxSubscribedTopics2.Items.Contains(topic))
            {
                this.ListBoxSubscribedTopics2.Items.Add(topic);
                this.ListBoxSubscribedTopics2.SelectedItem = topic;
            }
            

            MessageBox.Show("Topic " + this.TextBoxTopicSubscribed2.Text.Trim() + " is subscribed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ButtonUnsubscribeClick(object sender, EventArgs e)
        {
            var topicFilter = new string[] {(string)this.ListBoxSubscribedTopics.SelectedItem};
            await this._mqttClient1.UnsubscribeAsync(topicFilter);

            this.ListBoxSubscribedTopics.Items.Remove(topicFilter[0]);

            MessageBox.Show("Topic " + this.TextBoxTopicSubscribed.Text.Trim() + " is unsubscribed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ButtonUnsubscribe2Click(object sender, EventArgs e)
        {
            var topicFilter = new string[] {(string)this.ListBoxSubscribedTopics2.SelectedItem};
            await this._mqttClient1.UnsubscribeAsync(topicFilter);
            this.ListBoxSubscribedTopics2.Items.Remove(topicFilter[0]);

            MessageBox.Show("Topic " + this.TextBoxTopicSubscribed.Text.Trim() + " is unsubscribed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// The method that handles the button click to start the subscriber.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonSubscriberStartClick(object sender, EventArgs e)
        {
            var mqttFactory = new MqttFactory();

            var tlsOptions = new MqttClientTlsOptions
            {
                UseTls = false,
                IgnoreCertificateChainErrors = true,
                IgnoreCertificateRevocationErrors = true,
                AllowUntrustedCertificates = true
            };

            var options = new MqttClientOptions
            {
                ClientId = this.TextBoxClientId.Text.Trim(),
                ProtocolVersion = MqttProtocolVersion.V311,
                ChannelOptions = new MqttClientTcpOptions
                {
                    Server = this.textBoxServer.Text.Trim(),
                    Port = int.Parse(this.TextBoxPort.Text.Trim()),
                    TlsOptions = tlsOptions
                }
            };

            if (options.ChannelOptions == null)
            {
                throw new InvalidOperationException();
            }

            options.Credentials = new MqttClientCredentials
            {
                Username = "username",
                Password = Encoding.UTF8.GetBytes("password")
            };

            options.CleanSession = true;
            options.KeepAlivePeriod = _keepAlive;

            this._mqttClient1 = mqttFactory.CreateMqttClient();
            this._mqttClient1.ConnectedHandler = new MqttClientConnectedHandlerDelegate((args) => OnSubscriberConnected(args, options));
            this._mqttClient1.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnSubscriberDisconnected);
            this._mqttClient1.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(this.OnSubscriberMessageReceived);

            await this._mqttClient1.ConnectAsync(options, CancellationToken.None);
        }


        private async void ButtonSubscriberStart2Click(object sender, EventArgs e)
        {
            var mqttFactory = new MqttFactory();

            var tlsOptions = new MqttClientTlsOptions
            {
                UseTls = false,
                IgnoreCertificateChainErrors = true,
                IgnoreCertificateRevocationErrors = true,
                AllowUntrustedCertificates = true
            };

            var options = new MqttClientOptions
            {
                ClientId = this.TextBoxClientId2.Text.Trim(),
                ProtocolVersion = MqttProtocolVersion.V311,
                ChannelOptions = new MqttClientTcpOptions
                {
                    Server = this.textBoxServer.Text.Trim(),
                    Port = int.Parse(this.TextBoxPort.Text.Trim()),
                    TlsOptions = tlsOptions
                }
            };

            if (options.ChannelOptions == null)
            {
                throw new InvalidOperationException();
            }

            options.Credentials = new MqttClientCredentials
            {
                Username = "username",
                Password = Encoding.UTF8.GetBytes("password")
            };

            options.CleanSession = true;
            options.KeepAlivePeriod = _keepAlive;

            this._mqttClient2 = mqttFactory.CreateMqttClient();
            this._mqttClient2.ConnectedHandler = new MqttClientConnectedHandlerDelegate(args => OnSubscriberConnected(args, options));
            this._mqttClient2.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnSubscriberDisconnected);
            this._mqttClient2.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(this.OnSubscriber2MessageReceived);

            await this._mqttClient2.ConnectAsync(options, CancellationToken.None);

        }

        /// <summary>
        /// The method that handles the button click to stop the subscriber.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonSubscriberStopClick(object sender, EventArgs e)
        {
            if (this._mqttClient1 == null)
            {
                return;
            }

            await this._mqttClient1.DisconnectAsync();
            this._mqttClient1 = null;
        }

        /// <summary>
        /// The method that handles the button click to stop the subscriber.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonSubscriber2StopClick(object sender, EventArgs e)
        {
            if (this._mqttClient2 == null)
            {
                return;
            }

            await this._mqttClient2.DisconnectAsync();
            this._mqttClient2 = null;
        }


        /// <summary>
        /// Handles the received subscriber message event for 1.
        /// </summary>
        /// <param name="x">The MQTT application message received event args.</param>
        private void OnSubscriberMessageReceived(MqttApplicationMessageReceivedEventArgs x)
        {
            var item = FormatMessage(x);
            this.BeginInvoke((MethodInvoker)delegate { this.TextBoxSubscriber.Text = item + Environment.NewLine + this.TextBoxSubscriber.Text; });
        }

        /// <summary>
        /// Handles the received subscriber message event for 2.
        /// </summary>
        /// <param name="x">The MQTT application message received event args.</param>
        private void OnSubscriber2MessageReceived(MqttApplicationMessageReceivedEventArgs x)
        {
            var item = FormatMessage(x);
            this.BeginInvoke((MethodInvoker)delegate { this.TextBoxSubscriber2.Text = item + Environment.NewLine + this.TextBoxSubscriber2.Text; });
        }

        private string FormatMessage(MqttApplicationMessageReceivedEventArgs x)
        {
            return $"[{DateTime.Now:g}] - {x.ApplicationMessage.Topic} : {x.ApplicationMessage.ConvertPayloadToString()}";
        }

        /// <summary>
        /// The method that handles the text changes in the text box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void TextBoxPortTextChanged(object sender, EventArgs e)
        {
            // ReSharper disable once StyleCop.SA1126
            if (int.TryParse(this.TextBoxPort.Text, out _))
            {
                this.port = this.TextBoxPort.Text.Trim();
            }
            else
            {
                this.TextBoxPort.Text = this.port;
                this.TextBoxPort.SelectionStart = this.TextBoxPort.Text.Length;
                this.TextBoxPort.SelectionLength = 0;
            }
        }

        /// <summary>
        /// The method that handles the timer events.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(
                (MethodInvoker)delegate
                {
                    // Server
                    this.TextBoxPort.Enabled = this._mqttServer == null;
                    this.ButtonServerStart.Enabled = this._mqttServer == null;
                    this.ButtonServerStop.Enabled = this._mqttServer != null;

                    // Subscriber
                    this.ButtonSubscriberStart.Enabled = this._mqttClient1 == null;
                    this.ButtonSubscriberStop.Enabled = this._mqttClient1 != null;

                    this.ButtonSubscriberStart2.Enabled = this._mqttClient2 == null;
                    this.ButtonSubscriberStop2.Enabled = this._mqttClient2 != null;
                });
        }

        
        private async void buttonPublish_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            try
            {
                var payload = Encoding.UTF8.GetBytes(this.textBoxMessage.Text);
                var message = new MqttApplicationMessageBuilder()
                    .WithTopic(this.textBoxPublishTopic.Text)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                    .Build();

                if (this._mqttClient1 != null)
                {
                    await this._mqttClient1.PublishAsync(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ((Button)sender).Enabled = true;
        }

        private async void buttonPublish2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            try
            {
                var payload = Encoding.UTF8.GetBytes(this.textBoxMessage2.Text);
                var message = new MqttApplicationMessageBuilder()
                    .WithTopic(this.textBoxPublishTopic2.Text)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                    .Build();

                if (this._mqttClient2 != null)
                {
                    await this._mqttClient2.PublishAsync(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ((Button)sender).Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxSubscriber.Text = string.Empty;
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            this.TextBoxSubscriber2.Text = string.Empty;
        }

        private void ListBoxSubscribedTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPublishTopic.Text = (string) this.ListBoxSubscribedTopics.SelectedItem;
        }

        private void ListBoxSubscribedTopics2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPublishTopic2.Text = (string) this.ListBoxSubscribedTopics2.SelectedItem;
        }
    }
}
