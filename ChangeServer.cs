using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OT_Management
{
    public partial class ChangeServer : Form
    {
        public ChangeServer()
        {
            InitializeComponent();
            IPA.Value = Properties.Settings.Default.IpAddress;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IpAddress = IPA.Text;
            MessageBox.Show("Server IP Address Just Changed","Changed!");
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IPA_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IpAddress == IPA.Text)
            {
                saveButton.Enabled = false;
            }
            else 
            {
                saveButton.Enabled = true;
            }
        }
    }
}
