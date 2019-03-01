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
    public partial class Overtime : Form
    {

        public Overtime()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OvertimeRequest otr = new OvertimeRequest();
            otr.Closed += (s, args) => this.Close();
            otr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar[1] == "Submitter")
            {
                MessageBox.Show("Cant Access this Session!", "Access Denied");
            }
            else 
            {
                this.Hide();
                Approval ap = new Approval();
                ap.Closed += (s, args) => this.Close();
                ap.Show();
            }
        
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status aps = new Status();
            aps.Closed += (s, args) => this.Close();
            aps.Show();
        }

    }
}
