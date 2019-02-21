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
            
        }

        private void ManageUserBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUsers anu = new AddNewUsers();
            anu.Closed += (s, args) => this.Close();
            anu.Show();
        }
    }
}
