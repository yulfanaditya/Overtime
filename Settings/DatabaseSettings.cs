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
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
        }

        private void employeeBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageKaryawan mk = new ManageKaryawan();
            mk.Closed += (s, args) => this.Close();
            mk.Show();
        }

        private void sectionBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSection ms = new ManageSection();
            ms.Closed += (s, args) => this.Close();
            ms.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings st = new Settings();
            st.Closed += (s, args) => this.Close();
            st.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageDepartment md = new ManageDepartment();
            md.Closed += (s, args) => this.Close();
            md.Show();
        }

    }
}
