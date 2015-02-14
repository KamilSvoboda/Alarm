namespace Alarm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.messageRadio = new System.Windows.Forms.RadioButton();
            this.shutDownRadio = new System.Windows.Forms.RadioButton();
            this.message = new System.Windows.Forms.TextBox();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.cancelAlarmButton = new System.Windows.Forms.Button();
            this.groupBoxCurrentTime = new System.Windows.Forms.GroupBox();
            this.groupBoxAlarmTime = new System.Windows.Forms.GroupBox();
            this.alarmTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAlarmAction = new System.Windows.Forms.GroupBox();
            this.commonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aboutButton = new System.Windows.Forms.Button();
            this.groupBoxCurrentTime.SuspendLayout();
            this.groupBoxAlarmTime.SuspendLayout();
            this.groupBoxAlarmAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Alarm";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(17, 16);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(127, 33);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00:00";
            // 
            // messageRadio
            // 
            this.messageRadio.AutoSize = true;
            this.messageRadio.Checked = true;
            this.messageRadio.Location = new System.Drawing.Point(18, 91);
            this.messageRadio.Name = "messageRadio";
            this.messageRadio.Size = new System.Drawing.Size(97, 17);
            this.messageRadio.TabIndex = 1;
            this.messageRadio.TabStop = true;
            this.messageRadio.Text = "Show message";
            this.messageRadio.UseVisualStyleBackColor = true;
            // 
            // shutDownRadio
            // 
            this.shutDownRadio.AutoSize = true;
            this.shutDownRadio.Location = new System.Drawing.Point(18, 117);
            this.shutDownRadio.Name = "shutDownRadio";
            this.shutDownRadio.Size = new System.Drawing.Size(120, 17);
            this.shutDownRadio.TabIndex = 3;
            this.shutDownRadio.TabStop = true;
            this.shutDownRadio.Text = "Shutdown computer";
            this.shutDownRadio.UseVisualStyleBackColor = true;
            this.shutDownRadio.CheckedChanged += new System.EventHandler(this.shutDownRadio_CheckedChanged);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(109, 15);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(132, 20);
            this.message.TabIndex = 2;
            this.message.Text = "wake up!";
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(12, 157);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(72, 24);
            this.setAlarmButton.TabIndex = 4;
            this.setAlarmButton.Text = "Set &alarm";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // cancelAlarmButton
            // 
            this.cancelAlarmButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAlarmButton.Location = new System.Drawing.Point(90, 157);
            this.cancelAlarmButton.Name = "cancelAlarmButton";
            this.cancelAlarmButton.Size = new System.Drawing.Size(76, 25);
            this.cancelAlarmButton.TabIndex = 5;
            this.cancelAlarmButton.Text = "&Cancel";
            this.cancelAlarmButton.UseVisualStyleBackColor = true;
            this.cancelAlarmButton.Click += new System.EventHandler(this.cancelAlarmButton_Click);
            // 
            // groupBoxCurrentTime
            // 
            this.groupBoxCurrentTime.Controls.Add(this.timeLabel);
            this.groupBoxCurrentTime.Location = new System.Drawing.Point(12, 9);
            this.groupBoxCurrentTime.Name = "groupBoxCurrentTime";
            this.groupBoxCurrentTime.Size = new System.Drawing.Size(152, 58);
            this.groupBoxCurrentTime.TabIndex = 9;
            this.groupBoxCurrentTime.TabStop = false;
            this.groupBoxCurrentTime.Text = "Current time";
            // 
            // groupBoxAlarmTime
            // 
            this.groupBoxAlarmTime.Controls.Add(this.alarmTimeTextBox);
            this.groupBoxAlarmTime.Location = new System.Drawing.Point(171, 9);
            this.groupBoxAlarmTime.Name = "groupBoxAlarmTime";
            this.groupBoxAlarmTime.Size = new System.Drawing.Size(93, 58);
            this.groupBoxAlarmTime.TabIndex = 10;
            this.groupBoxAlarmTime.TabStop = false;
            this.groupBoxAlarmTime.Text = "Alarm time";
            // 
            // alarmTimeTextBox
            // 
            this.alarmTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarmTimeTextBox.Location = new System.Drawing.Point(15, 14);
            this.alarmTimeTextBox.Mask = "00:00";
            this.alarmTimeTextBox.Name = "alarmTimeTextBox";
            this.alarmTimeTextBox.Size = new System.Drawing.Size(67, 35);
            this.alarmTimeTextBox.TabIndex = 0;
            this.alarmTimeTextBox.ValidatingType = typeof(System.DateTime);
            this.alarmTimeTextBox.Enter += new System.EventHandler(this.alarmTimeTextBox_Enter);
            // 
            // groupBoxAlarmAction
            // 
            this.groupBoxAlarmAction.Controls.Add(this.message);
            this.groupBoxAlarmAction.Location = new System.Drawing.Point(12, 73);
            this.groupBoxAlarmAction.Name = "groupBoxAlarmAction";
            this.groupBoxAlarmAction.Size = new System.Drawing.Size(252, 77);
            this.groupBoxAlarmAction.TabIndex = 11;
            this.groupBoxAlarmAction.TabStop = false;
            this.groupBoxAlarmAction.Text = "Alarm action";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(184, 158);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(80, 24);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "A&bout";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.setAlarmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelAlarmButton;
            this.ClientSize = new System.Drawing.Size(278, 194);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.cancelAlarmButton);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.shutDownRadio);
            this.Controls.Add(this.messageRadio);
            this.Controls.Add(this.groupBoxCurrentTime);
            this.Controls.Add(this.groupBoxAlarmTime);
            this.Controls.Add(this.groupBoxAlarmAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm 2.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBoxCurrentTime.ResumeLayout(false);
            this.groupBoxCurrentTime.PerformLayout();
            this.groupBoxAlarmTime.ResumeLayout(false);
            this.groupBoxAlarmTime.PerformLayout();
            this.groupBoxAlarmAction.ResumeLayout(false);
            this.groupBoxAlarmAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton messageRadio;
        private System.Windows.Forms.RadioButton shutDownRadio;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Button cancelAlarmButton;
        private System.Windows.Forms.GroupBox groupBoxCurrentTime;
        private System.Windows.Forms.GroupBox groupBoxAlarmTime;
        private System.Windows.Forms.GroupBox groupBoxAlarmAction;
        private System.Windows.Forms.MaskedTextBox alarmTimeTextBox;
        private System.Windows.Forms.ToolTip commonToolTip;
        private System.Windows.Forms.Button aboutButton;
    }
}

