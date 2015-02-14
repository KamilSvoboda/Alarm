using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace Alarm
{
    public partial class AboutForm : Form
    {
        private ResourceManager rm;
        public AboutForm()
        {
            InitializeComponent();
            rm = new ResourceManager("Alarm.ApplicationResources", this.GetType().Assembly);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Text = rm.GetString("about");
            label1.Text = rm.GetString("alarm");
            label2.Text = rm.GetString("version") + " " + MainForm.version;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.svoboda.biz");
        }
    }
}
