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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUser mu = new ManageUser();
            mu.Closed += (s, args) => this.Close();
            mu.Show();
        }

        private void ManageUserBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUsers anu = new AddNewUsers();
            anu.Closed += (s, args) => this.Close();
            anu.Show();
        }

        private void ManageKaryawan_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseSettings ds = new DatabaseSettings();
            ds.Closed += (s, args) => this.Close();
            ds.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OTMax otm = new OTMax();
            otm.Closed += (s, args) => this.Close();
            otm.Show();
        }
    }
}
