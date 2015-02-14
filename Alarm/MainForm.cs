using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Globalization;
using System.Resources;

namespace Alarm
{
    public partial class MainForm : Form
    {
        public static String version = "2.1";
        private ResourceManager rm;
        private DateTime alarmTime;
        private DateTime currentTime;
        private Boolean alarmEnabled = false;
        private Boolean tomorrow = false;

        public enum ShutDownType
        {
            LogOff = 0,
            Shutdown = 1,
            Reboot = 2,
            ForcedLogOff = 4,
            ForcedShutdown = 5,
            ForcedReboot = 6,
            PowerOff = 8,
            ForcedPowerOff = 12
        }

        public MainForm()
        {
            InitializeComponent();
            rm = new ResourceManager("Alarm.ApplicationResources", this.GetType().Assembly);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            alarmTimeTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(alarmTimeTextBox_MaskInputRejected);
            alarmTimeTextBox.ValidatingType = typeof(System.DateTime);
            alarmTimeTextBox.TypeValidationCompleted += new TypeValidationEventHandler(alarmTimeTextBox_TypeValidationCompleted);

            currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToLongTimeString();
            this.Text = rm.GetString("alarm") + " " + MainForm.version;
            groupBoxCurrentTime.Text = rm.GetString("current_time");
            groupBoxAlarmTime.Text = rm.GetString("alarm_time");
            groupBoxAlarmAction.Text = rm.GetString("alarm_action");
            messageRadio.Text = rm.GetString("message_radio");
            message.Text = rm.GetString("message");
            shutDownRadio.Text = rm.GetString("shutdown_radio");
            setAlarmButton.Text = rm.GetString("set_the_alarm");
            cancelAlarmButton.Text = rm.GetString("cancel");
            aboutButton.Text = rm.GetString("about");
            
            String t = currentTime.AddMinutes(15).ToShortTimeString();
            if (t.Length < 5) t = "0" + t;
            alarmTimeTextBox.Text = t; 
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            alarmTimeTextBox.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToLongTimeString();
            
            if (alarmEnabled)                 
            {
                if ((currentTime >= alarmTime) && (!tomorrow))
                { 
                    alarmEnabled = false;
                    if (messageRadio.Checked)
                    {
                        MessageBox.Show(message.Text, alarmTime.ToShortTimeString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        notifyIcon_Click(sender, e);
                    }
                    else
                    {
                        shutDown(ShutDownType.ForcedPowerOff);
                    }
                }
                else if ((currentTime < alarmTime) && (tomorrow))  //po překonání půlnoci musím zrušit příznak, že alarm má nastat až zítra
                {
                    tomorrow = false;
                    setNotifyIconText(getText());
                }
            }
        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            alarmTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, int.Parse(alarmTimeTextBox.Text.Substring(0, 2)), int.Parse(alarmTimeTextBox.Text.Substring(3, 2)), 0);

            alarmEnabled = true;
            if (alarmTime < currentTime) tomorrow = true;
            
            if (tomorrow)
                notifyIcon.BalloonTipTitle = rm.GetString("tomorrow") + " " + rm.GetString("at") + " " + alarmTime.ToShortTimeString() + " " + rm.GetString("o_clock");     
            else
                notifyIcon.BalloonTipTitle = alarmTime.ToShortTimeString();

            notifyIcon.BalloonTipText = getText();

            setNotifyIconText(getText());          

            Hide();
            notifyIcon.ShowBalloonTip(500);
        }

        private String getText()
        {
            if (messageRadio.Checked)
                return message.Text;
            else
                return rm.GetString("computer_shutdown");
        }

        private void setNotifyIconText(String text)
        {
            if (tomorrow)
                notifyIcon.Text = text + " - " + rm.GetString("tomorrow") + " " + rm.GetString("at") + " " + alarmTime.ToShortTimeString() + " " + rm.GetString("o_clock");
            else
                notifyIcon.Text = text + " - " + rm.GetString("at") + " " + alarmTime.ToShortTimeString() + " " + rm.GetString("o_clock");            
        }

        private void shutDown(ShutDownType type)
        {
            ManagementClass W32_OS = new ManagementClass("Win32_OperatingSystem");
            ManagementBaseObject inParams, outParams;
            int result;

            W32_OS.Scope.Options.EnablePrivileges = true;
            foreach (ManagementObject obj in W32_OS.GetInstances())
            {
                inParams = obj.GetMethodParameters("Win32Shutdown");
                inParams["Flags"] = type;
                inParams["Reserved"] = 0;

                outParams = obj.InvokeMethod("Win32Shutdown", inParams, null);
                result = Convert.ToInt32(outParams["returnValue"]);
                if (result != 0) throw new Win32Exception(result);
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            notifyIcon.Text = rm.GetString("alarm");
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon_Click(sender, e);
        }

        private void shutDownRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (shutDownRadio.Checked)
            {
                message.Enabled = false;
            } else {
                message.Enabled = true;
            }
        }

        private void cancelAlarmButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void alarmTimeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            commonToolTip.ToolTipTitle = rm.GetString("invalid_input_title");
            commonToolTip.Show(rm.GetString("invalid_input_text"), alarmTimeTextBox, alarmTimeTextBox.Location, 3000);
        }

        public void alarmTimeTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                commonToolTip.ToolTipTitle = rm.GetString("invalid_time_title");
                commonToolTip.Show(rm.GetString("invalid_time_text"), alarmTimeTextBox, 3000);
                e.Cancel = true;
            }
        }

        private void alarmTimeTextBox_Enter(object sender, EventArgs e)
        {
            alarmTimeTextBox.SelectAll();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.Show();
        }      
    }
}
