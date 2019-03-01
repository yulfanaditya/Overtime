using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OT_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if(Global.GlobalVar[1] == "Administrator"){
                settingBox.Visible = true;
                settingBox.Enabled = true;
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void overreq_Click(object sender, EventArgs e)
        {
            OvertimeRequest or = new OvertimeRequest();
            or.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON!!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageKaryawan dbm = new ManageKaryawan();
            dbm.Closed += (s, args) => this.Close();
            dbm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            string datanama = Login_Form.datauser;
            label2.Text = Global.GlobalVar[0];
            label3.Text = Global.GlobalVar[1];
        }

        public string userdata { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings st = new Settings();
            st.Closed += (s, args) => this.Close();
            st.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Global.GlobalVar[i] = "";
            }
            this.Hide();
            Login_Form or = new Login_Form();
            or.Closed += (s, args) => this.Close();
            or.Show();
        }


    }
   /* class DBOT
    {
        MySqlConnection connecting;
        private string server = "192.168.110.42";
        private string database = "otmanagement";
        private string user = "root";
        private string password = "kemet123";

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void inializing()
        {
            string connect;

            connect = "SERVER=" + server + ";" + "DATABASE="
            + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            connecting = new MySqlConnection(connect);

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////

    }*/
}

