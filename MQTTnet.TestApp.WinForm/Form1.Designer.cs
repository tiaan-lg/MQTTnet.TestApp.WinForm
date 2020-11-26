namespace MQTTnet.TestApp.WinForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.ButtonServerStart = new System.Windows.Forms.Button();
            this.ButtonServerStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMessage2 = new System.Windows.Forms.TextBox();
            this.ButtonSubscriberStop = new System.Windows.Forms.Button();
            this.ButtonSubscriberStart = new System.Windows.Forms.Button();
            this.TextBoxSubscriber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxTopicSubscribed = new System.Windows.Forms.TextBox();
            this.ButtonSubscribe = new System.Windows.Forms.Button();
            this.TextBoxSubscriber2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonSubscriberStop2 = new System.Windows.Forms.Button();
            this.ButtonSubscriberStart2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxTopicSubscribed2 = new System.Windows.Forms.TextBox();
            this.ButtonSubscribe2 = new System.Windows.Forms.Button();
            this.TextBoxClientId = new System.Windows.Forms.TextBox();
            this.TextBoxClientId2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPublish2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxSubscribedTopics = new System.Windows.Forms.ListBox();
            this.ListBoxSubscribedTopics2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.textBoxPublishTopic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPublishTopic2 = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(305, 38);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(100, 23);
            this.TextBoxPort.TabIndex = 1;
            this.TextBoxPort.Text = "1883";
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBoxPortTextChanged);
            // 
            // ButtonServerStart
            // 
            this.ButtonServerStart.Location = new System.Drawing.Point(411, 38);
            this.ButtonServerStart.Name = "ButtonServerStart";
            this.ButtonServerStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonServerStart.TabIndex = 2;
            this.ButtonServerStart.Text = "Start";
            this.ButtonServerStart.UseVisualStyleBackColor = true;
            this.ButtonServerStart.Click += new System.EventHandler(this.ButtonServerStartClick);
            // 
            // ButtonServerStop
            // 
            this.ButtonServerStop.Location = new System.Drawing.Point(492, 38);
            this.ButtonServerStop.Name = "ButtonServerStop";
            this.ButtonServerStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonServerStop.TabIndex = 3;
            this.ButtonServerStop.Text = "Stop";
            this.ButtonServerStop.UseVisualStyleBackColor = true;
            this.ButtonServerStop.Click += new System.EventHandler(this.ButtonServerStopClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.Text = "maskedTextBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client:";
            // 
            // textBoxMessage2
            // 
            this.textBoxMessage2.Location = new System.Drawing.Point(659, 334);
            this.textBoxMessage2.Name = "textBoxMessage2";
            this.textBoxMessage2.Size = new System.Drawing.Size(453, 23);
            this.textBoxMessage2.TabIndex = 1;
            this.textBoxMessage2.TextChanged += new System.EventHandler(this.TextBoxPortTextChanged);
            // 
            // ButtonSubscriberStop
            // 
            this.ButtonSubscriberStop.Location = new System.Drawing.Point(383, 79);
            this.ButtonSubscriberStop.Name = "ButtonSubscriberStop";
            this.ButtonSubscriberStop.Size = new System.Drawing.Size(90, 23);
            this.ButtonSubscriberStop.TabIndex = 3;
            this.ButtonSubscriberStop.Text = "Disconnect";
            this.ButtonSubscriberStop.UseVisualStyleBackColor = true;
            this.ButtonSubscriberStop.Click += new System.EventHandler(this.ButtonSubscriberStopClick);
            // 
            // ButtonSubscriberStart
            // 
            this.ButtonSubscriberStart.Location = new System.Drawing.Point(302, 79);
            this.ButtonSubscriberStart.Name = "ButtonSubscriberStart";
            this.ButtonSubscriberStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubscriberStart.TabIndex = 2;
            this.ButtonSubscriberStart.Text = "Connect";
            this.ButtonSubscriberStart.UseVisualStyleBackColor = true;
            this.ButtonSubscriberStart.Click += new System.EventHandler(this.ButtonSubscriberStartClick);
            // 
            // TextBoxSubscriber
            // 
            this.TextBoxSubscriber.Location = new System.Drawing.Point(33, 374);
            this.TextBoxSubscriber.Multiline = true;
            this.TextBoxSubscriber.Name = "TextBoxSubscriber";
            this.TextBoxSubscriber.Size = new System.Drawing.Size(556, 275);
            this.TextBoxSubscriber.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Topic:";
            // 
            // TextBoxTopicSubscribed
            // 
            this.TextBoxTopicSubscribed.Location = new System.Drawing.Point(74, 114);
            this.TextBoxTopicSubscribed.Name = "TextBoxTopicSubscribed";
            this.TextBoxTopicSubscribed.Size = new System.Drawing.Size(222, 23);
            this.TextBoxTopicSubscribed.TabIndex = 1;
            this.TextBoxTopicSubscribed.Text = "thread/clients/x";
            this.TextBoxTopicSubscribed.TextChanged += new System.EventHandler(this.TextBoxPortTextChanged);
            // 
            // ButtonSubscribe
            // 
            this.ButtonSubscribe.Location = new System.Drawing.Point(302, 113);
            this.ButtonSubscribe.Name = "ButtonSubscribe";
            this.ButtonSubscribe.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubscribe.TabIndex = 3;
            this.ButtonSubscribe.Text = "Subscribe";
            this.ButtonSubscribe.UseVisualStyleBackColor = true;
            this.ButtonSubscribe.Click += new System.EventHandler(this.ButtonSubscribeClick);
            // 
            // TextBoxSubscriber2
            // 
            this.TextBoxSubscriber2.Location = new System.Drawing.Point(659, 374);
            this.TextBoxSubscriber2.Multiline = true;
            this.TextBoxSubscriber2.Name = "TextBoxSubscriber2";
            this.TextBoxSubscriber2.Size = new System.Drawing.Size(556, 275);
            this.TextBoxSubscriber2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Client";
            // 
            // ButtonSubscriberStop2
            // 
            this.ButtonSubscriberStop2.Location = new System.Drawing.Point(1012, 79);
            this.ButtonSubscriberStop2.Name = "ButtonSubscriberStop2";
            this.ButtonSubscriberStop2.Size = new System.Drawing.Size(90, 23);
            this.ButtonSubscriberStop2.TabIndex = 9;
            this.ButtonSubscriberStop2.Text = "Disconnect";
            this.ButtonSubscriberStop2.UseVisualStyleBackColor = true;
            this.ButtonSubscriberStop2.Click += new System.EventHandler(this.ButtonSubscriber2StopClick);
            // 
            // ButtonSubscriberStart2
            // 
            this.ButtonSubscriberStart2.Location = new System.Drawing.Point(931, 79);
            this.ButtonSubscriberStart2.Name = "ButtonSubscriberStart2";
            this.ButtonSubscriberStart2.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubscriberStart2.TabIndex = 8;
            this.ButtonSubscriberStart2.Text = "Connect";
            this.ButtonSubscriberStart2.UseVisualStyleBackColor = true;
            this.ButtonSubscriberStart2.Click += new System.EventHandler(this.ButtonSubscriberStart2Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Topic";
            // 
            // TextBoxTopicSubscribed2
            // 
            this.TextBoxTopicSubscribed2.Location = new System.Drawing.Point(703, 114);
            this.TextBoxTopicSubscribed2.Name = "TextBoxTopicSubscribed2";
            this.TextBoxTopicSubscribed2.Size = new System.Drawing.Size(222, 23);
            this.TextBoxTopicSubscribed2.TabIndex = 7;
            this.TextBoxTopicSubscribed2.Text = "thread/clients/y";
            // 
            // ButtonSubscribe2
            // 
            this.ButtonSubscribe2.Location = new System.Drawing.Point(931, 113);
            this.ButtonSubscribe2.Name = "ButtonSubscribe2";
            this.ButtonSubscribe2.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubscribe2.TabIndex = 10;
            this.ButtonSubscribe2.Text = "Subscribe";
            this.ButtonSubscribe2.UseVisualStyleBackColor = true;
            this.ButtonSubscribe2.Click += new System.EventHandler(this.ButtonSubscribe2Click);
            // 
            // TextBoxClientId
            // 
            this.TextBoxClientId.Location = new System.Drawing.Point(74, 79);
            this.TextBoxClientId.Name = "TextBoxClientId";
            this.TextBoxClientId.Size = new System.Drawing.Size(222, 23);
            this.TextBoxClientId.TabIndex = 14;
            this.TextBoxClientId.Text = "x";
            // 
            // TextBoxClientId2
            // 
            this.TextBoxClientId2.Location = new System.Drawing.Point(703, 80);
            this.TextBoxClientId2.Name = "TextBoxClientId2";
            this.TextBoxClientId2.Size = new System.Drawing.Size(222, 23);
            this.TextBoxClientId2.TabIndex = 15;
            this.TextBoxClientId2.Text = "y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Un-Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonUnsubscribe2Click);
            // 
            // buttonPublish2
            // 
            this.buttonPublish2.Location = new System.Drawing.Point(1118, 333);
            this.buttonPublish2.Name = "buttonPublish2";
            this.buttonPublish2.Size = new System.Drawing.Size(97, 23);
            this.buttonPublish2.TabIndex = 18;
            this.buttonPublish2.Text = "Publish";
            this.buttonPublish2.UseVisualStyleBackColor = true;
            this.buttonPublish2.Click += new System.EventHandler(this.buttonPublish2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Un-Subscribe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonUnsubscribeClick);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(33, 335);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(453, 23);
            this.textBoxMessage.TabIndex = 20;
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(492, 334);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(97, 23);
            this.buttonPublish.TabIndex = 21;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Receive From Subscribed Topics";
            // 
            // ListBoxSubscribedTopics
            // 
            this.ListBoxSubscribedTopics.FormattingEnabled = true;
            this.ListBoxSubscribedTopics.ItemHeight = 15;
            this.ListBoxSubscribedTopics.Location = new System.Drawing.Point(33, 172);
            this.ListBoxSubscribedTopics.Name = "ListBoxSubscribedTopics";
            this.ListBoxSubscribedTopics.Size = new System.Drawing.Size(263, 94);
            this.ListBoxSubscribedTopics.TabIndex = 23;
            this.ListBoxSubscribedTopics.SelectedIndexChanged += new System.EventHandler(this.ListBoxSubscribedTopics_SelectedIndexChanged);
            // 
            // ListBoxSubscribedTopics2
            // 
            this.ListBoxSubscribedTopics2.FormattingEnabled = true;
            this.ListBoxSubscribedTopics2.ItemHeight = 15;
            this.ListBoxSubscribedTopics2.Location = new System.Drawing.Point(659, 172);
            this.ListBoxSubscribedTopics2.Name = "ListBoxSubscribedTopics2";
            this.ListBoxSubscribedTopics2.Size = new System.Drawing.Size(266, 94);
            this.ListBoxSubscribedTopics2.TabIndex = 25;
            this.ListBoxSubscribedTopics2.SelectedIndexChanged += new System.EventHandler(this.ListBoxSubscribedTopics2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Receive From Subscribed Topics";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(514, 655);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(1140, 655);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(75, 23);
            this.buttonClear2.TabIndex = 27;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // textBoxPublishTopic
            // 
            this.textBoxPublishTopic.Location = new System.Drawing.Point(33, 296);
            this.textBoxPublishTopic.Name = "textBoxPublishTopic";
            this.textBoxPublishTopic.Size = new System.Drawing.Size(263, 23);
            this.textBoxPublishTopic.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Publish To Topic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Publish To Topic";
            // 
            // textBoxPublishTopic2
            // 
            this.textBoxPublishTopic2.Location = new System.Drawing.Point(659, 296);
            this.textBoxPublishTopic2.Name = "textBoxPublishTopic2";
            this.textBoxPublishTopic2.Size = new System.Drawing.Size(266, 23);
            this.textBoxPublishTopic2.TabIndex = 30;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(74, 39);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(184, 23);
            this.textBoxServer.TabIndex = 32;
            this.textBoxServer.Text = "localhost";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(624, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2, 600);
            this.label11.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 713);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPublishTopic2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPublishTopic);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ListBoxSubscribedTopics2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListBoxSubscribedTopics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPublish2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxClientId2);
            this.Controls.Add(this.TextBoxClientId);
            this.Controls.Add(this.TextBoxSubscriber2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonSubscriberStop2);
            this.Controls.Add(this.ButtonSubscriberStart2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxTopicSubscribed2);
            this.Controls.Add(this.ButtonSubscribe2);
            this.Controls.Add(this.TextBoxSubscriber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonServerStop);
            this.Controls.Add(this.ButtonServerStart);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage2);
            this.Controls.Add(this.ButtonSubscriberStop);
            this.Controls.Add(this.ButtonSubscriberStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxTopicSubscribed);
            this.Controls.Add(this.ButtonSubscribe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MQTT Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxPort;
		private System.Windows.Forms.Button ButtonServerStart;
		private System.Windows.Forms.Button ButtonServerStop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxMessage2;
		private System.Windows.Forms.Button ButtonSubscriberStop;
		private System.Windows.Forms.Button ButtonSubscriberStart;
		private System.Windows.Forms.TextBox TextBoxSubscriber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button ButtonSubscribe;
		private System.Windows.Forms.TextBox TextBoxTopicSubscribed;
        private System.Windows.Forms.TextBox TextBoxSubscriber2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonSubscriberStop2;
        private System.Windows.Forms.Button ButtonSubscriberStart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxTopicSubscribed2;
        private System.Windows.Forms.Button ButtonSubscribe2;
        private System.Windows.Forms.TextBox TextBoxClientId;
        private System.Windows.Forms.TextBox TextBoxClientId2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPublish2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxSubscribedTopics;
        private System.Windows.Forms.ListBox ListBoxSubscribedTopics2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.TextBox textBoxPublishTopic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPublishTopic2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxServer;
    }
}

