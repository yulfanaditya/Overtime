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
using System.Security.Cryptography;

namespace OT_Management
{
    public partial class Register : Form
    {
        OTDB DB = new OTDB();
        public Register()
        {
            InitializeComponent();
            
            
        }
//====================================================================================================================================================================================================================================

        private void searchOTC_Click(object sender, EventArgs e)
        {
            Employeedata home = new Employeedata();
            home.ShowDialog();
        }
//====================================================================================================================================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form or = new Login_Form();
            or.Closed += (s, args) => this.Close();
            or.Show();
        }
//====================================================================================================================================================================================================================================

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Data Must Not Empty");
            }
            else if (equalitychecker(username.Text,true) == true || equalitychecker(username.Text,false) == true)
            {
                MessageBox.Show("Username is Already Taken!");
                clear();
            }
            else {
                string query = "INSERT INTO registerusername (Username,Password,Name,Position,departmentName,sectionName) VALUES('" + username.Text + "','" + MD5Hash(password.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
                DB.CloseConnection();
                MessageBox.Show("Data Registered, Please Call Administrator for Approvement");
                clear();
            }
        }
//====================================================================================================================================================================================================================================

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
//====================================================================================================================================================================================================================================
        public bool equalitychecker(string data,bool check) 
        {

            DB.inializing();
            string data2 = "";
            string query;

            if (check == true)
            {
                query = "Select Username from registerusername WHERE Username = '" + data + "'";
            }
            else
            {
                query = "Select Username from account WHERE Username = '" + data + "'";
            }
            
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                data2 = Reader.GetString(0);
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();

            bool equal = string.Equals(data,data2);
            if (equal == false) {
                return false;
            }
            return true;
        }
//====================================================================================================================================================================================================================================
        public void clear() {
            username.Text = "";
            password.Text = "";
            textBox2.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Submitter");
            comboBox1.Items.Add("Approver 1");
            comboBox1.Items.Add("Approver 2");
            comboBox1.Items.Add("Approver 3");
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Accounting");
            comboBox2.Items.Add("Engineering");
            comboBox2.Items.Add("General Manager");
            comboBox2.Items.Add("HR & GA");
            comboBox2.Items.Add("MIS");
            comboBox2.Items.Add("Maintenance");
            comboBox2.Items.Add("PPCWL");
            comboBox2.Items.Add("Production");
            comboBox2.Items.Add("Quality");
            comboBox3.Items.Clear();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            switch (comboBox2.Text) {
                case "Accounting":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("FINANCE");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "Engineering":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PROCESS");
                    comboBox3.Items.Add("TEST AND CALIBRATION");
                    comboBox3.Items.Add("R & D");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "General Manager":
                    this.comboBox3.Items.Clear();
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Text = "GENERAL";
                    comboBox3.Enabled = false;
                    break;

                case "HR & GA":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("TRAINING");
                    comboBox3.Items.Add("PAYROLL");
                    comboBox3.Items.Add("GENERAL AFFAIR");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "MIS":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("IT");
                    comboBox3.Text = "IT";
                    comboBox3.Enabled = false;
                    break;

                case "Maintenance":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PM & FACILITY");
                    comboBox3.Items.Add("PRUDUCTION SUPPORT (MOL X)");
                    comboBox3.Items.Add("TECHNICAL SUPPORT");
                    comboBox3.Items.Add("PM (MOL W)");
                    comboBox3.Items.Add("PM");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (MOL S)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (EOL)");
                    comboBox3.Items.Add("PM (BOL NON WINDING)");
                    comboBox3.Items.Add("PM (EOL NON TESTING)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (BOL)");
                    comboBox3.Items.Add("PM (BOL WINDING)");
                    comboBox3.Items.Add("FACILITY");
                    comboBox3.Items.Add("PM (MOL S)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (MOL W)");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "PPCWL":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("W & L");
                    comboBox3.Items.Add("PLANNING");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "Production":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PRODUCTION CONTROLLER");
                    comboBox3.Items.Add("BOL LINE LEADER");
                    comboBox3.Items.Add("BOL NON WINDING");
                    comboBox3.Items.Add("BOL SECTION HEAD");
                    comboBox3.Items.Add("BOL WINDING");
                    comboBox3.Items.Add("EOL LINE LEADER");
                    comboBox3.Items.Add("EOL NON TESTING");
                    comboBox3.Items.Add("EOL SECTION HEAD");
                    comboBox3.Items.Add("EOL TESTING");
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Items.Add("MOL S");
                    comboBox3.Items.Add("MOL S LINE LEADER");
                    comboBox3.Items.Add("MOL S SECTION HEAD");
                    comboBox3.Items.Add("MOL WOUND");
                    comboBox3.Items.Add("MOL WOUND LINE LEADER");
                    comboBox3.Items.Add("MOL WOUND SECTION HEAD");
                    comboBox3.Items.Add("PROD. IN PROCESS YIELD IMPROVE");
                    comboBox3.Items.Add("PROD. INNOVATION & DEVELOPMENT");
                    comboBox3.Items.Add("PRODUCTION ENGINEERING");
                    comboBox3.Items.Add("PRODUCTION SUPERVISORY");
                    break;

                case "Quality" :
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("DOCUMENT CONTROL CENTRE");
                    comboBox3.Items.Add("ENVIRONMENT HEALTH SAFETY");
                    comboBox3.Items.Add("FINAL INSPECTION");
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Items.Add("INCOMING");
                    comboBox3.Items.Add("IPQC");
                    comboBox3.Items.Add("LINE LEADER");
                    comboBox3.Items.Add("OUTGOING");
                    comboBox3.Items.Add("QUALITY MANAGEMENT SYSTEM");
                    comboBox3.Items.Add("SECTION HEAD");
                    comboBox3.Items.Add("SUPPORTING TEAM");
                    comboBox3.Items.Add("TRAINING");
                    break;
            }
        }
    }
}
