namespace QQRobot.MahuaUI
{
    partial class AddConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.groupIdLabel = new System.Windows.Forms.Label();
            this.replyContentLabel = new System.Windows.Forms.Label();
            this.msgLenLabel = new System.Windows.Forms.Label();
            this.groupId = new System.Windows.Forms.TextBox();
            this.msgLen = new System.Windows.Forms.TextBox();
            this.replyContent = new System.Windows.Forms.RichTextBox();
            this.saveConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(69, 58);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 12);
            this.startTimeLabel.TabIndex = 0;
            this.startTimeLabel.Text = "监控开始时间";
            // 
            // startTime
            // 
            this.startTime.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.startTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(152, 52);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 21);
            this.startTime.TabIndex = 1;
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(510, 52);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 21);
            this.endTime.TabIndex = 3;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(427, 58);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(77, 12);
            this.endTimeLabel.TabIndex = 2;
            this.endTimeLabel.Text = "监控结束时间";
            // 
            // groupIdLabel
            // 
            this.groupIdLabel.AutoSize = true;
            this.groupIdLabel.Location = new System.Drawing.Point(69, 130);
            this.groupIdLabel.Name = "groupIdLabel";
            this.groupIdLabel.Size = new System.Drawing.Size(53, 12);
            this.groupIdLabel.TabIndex = 0;
            this.groupIdLabel.Text = "监控群号";
            // 
            // replyContentLabel
            // 
            this.replyContentLabel.AutoSize = true;
            this.replyContentLabel.Location = new System.Drawing.Point(69, 209);
            this.replyContentLabel.Name = "replyContentLabel";
            this.replyContentLabel.Size = new System.Drawing.Size(53, 12);
            this.replyContentLabel.TabIndex = 0;
            this.replyContentLabel.Text = "回复内容";
            // 
            // msgLenLabel
            // 
            this.msgLenLabel.AutoSize = true;
            this.msgLenLabel.Location = new System.Drawing.Point(427, 130);
            this.msgLenLabel.Name = "msgLenLabel";
            this.msgLenLabel.Size = new System.Drawing.Size(77, 12);
            this.msgLenLabel.TabIndex = 0;
            this.msgLenLabel.Text = "监控消息长度";
            // 
            // groupId
            // 
            this.groupId.Location = new System.Drawing.Point(152, 127);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(200, 21);
            this.groupId.TabIndex = 4;
            // 
            // msgLen
            // 
            this.msgLen.Location = new System.Drawing.Point(510, 127);
            this.msgLen.Name = "msgLen";
            this.msgLen.Size = new System.Drawing.Size(200, 21);
            this.msgLen.TabIndex = 4;
            // 
            // replyContent
            // 
            this.replyContent.Location = new System.Drawing.Point(152, 206);
            this.replyContent.Name = "replyContent";
            this.replyContent.Size = new System.Drawing.Size(558, 108);
            this.replyContent.TabIndex = 5;
            this.replyContent.Text = "";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(345, 415);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(75, 23);
            this.saveConfig.TabIndex = 6;
            this.saveConfig.Text = "保存";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // AddConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.replyContent);
            this.Controls.Add(this.msgLen);
            this.Controls.Add(this.groupId);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.replyContentLabel);
            this.Controls.Add(this.msgLenLabel);
            this.Controls.Add(this.groupIdLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Name = "AddConfig";
            this.Text = "监控群设置";
            this.Load += new System.EventHandler(this.AddConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label groupIdLabel;
        private System.Windows.Forms.Label replyContentLabel;
        private System.Windows.Forms.Label msgLenLabel;
        private System.Windows.Forms.TextBox groupId;
        private System.Windows.Forms.TextBox msgLen;
        private System.Windows.Forms.RichTextBox replyContent;
        private System.Windows.Forms.Button saveConfig;
    }
}