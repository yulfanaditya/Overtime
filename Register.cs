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

        private void searchOTC_Click(object sender, EventArgs e)
        {
            EmployeeList home = new EmployeeList();
            home.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form or = new Login_Form();
            or.Closed += (s, args) => this.Close();
            or.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Textbox Must Not Empty");
            }
            else {
                string query = "INSERT INTO registerusername (Username,Password,Name,Position,Department,Section) VALUES('" + username.Text + "','" + MD5Hash(password.Text) + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.CheckConnection();
                cmd.ExecuteNonQuery();
                DB.CloseConnection();
                
            }
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text) {
                case "Accounting":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("FINANCE");
                    comboBox2.Items.Add("GENERAL");
                    break;

                case "Engineering":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("PROCESS");
                    comboBox2.Items.Add("TEST AND CALIBRATION");
                    comboBox2.Items.Add("R & D");
                    comboBox2.Items.Add("GENERAL");
                    break;

                case "General Manager":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "GENERAL";
                    break;

                case "HR & GA":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("TRAINING");
                    comboBox2.Items.Add("PAYROLL");
                    comboBox2.Items.Add("GENERAL AFFAIR");
                    comboBox2.Items.Add("GENERAL");
                    break;

                case "IT/MIS":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("MIS");
                    break;

                case "Maintenance":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("PM & FACILITY");
                    comboBox2.Items.Add("PRUDUCTION SUPPORT (MOL X)");
                    comboBox2.Items.Add("TECHNICAL SUPPORT");
                    comboBox2.Items.Add("PM (MOL W)");
                    comboBox2.Items.Add("PM");
                    comboBox2.Items.Add("PRODUCTION SUPPORT (MOL S)");
                    comboBox2.Items.Add("PRODUCTION SUPPORT (EOL)");
                    comboBox2.Items.Add("PM (BOL NON WINDING)");
                    comboBox2.Items.Add("PM (EOL NON TESTING)");
                    comboBox2.Items.Add("PRODUCTION SUPPORT (BOL)");
                    comboBox2.Items.Add("PM (BOL WINDING)");
                    comboBox2.Items.Add("FACILITY");
                    comboBox2.Items.Add("PM (MOL S)");
                    comboBox2.Items.Add("PRODUCTION SUPPORT (MOL W)");
                    comboBox2.Items.Add("GENERAL");
                    break;

                case "PPCWL":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("W & L");
                    comboBox2.Items.Add("PLANNING");
                    comboBox2.Items.Add("GENERAL");
                    break;

                case "Production":
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("PRODUCTION CONTROLLER");
                    comboBox2.Items.Add("BOL LINE LEADER");
                    comboBox2.Items.Add("BOL NON WINDING");
                    comboBox2.Items.Add("BOL SECTION HEAD");
                    comboBox2.Items.Add("BOL WINDING");
                    comboBox2.Items.Add("EOL LINE LEADER");
                    comboBox2.Items.Add("EOL NON TESTING");
                    comboBox2.Items.Add("EOL SECTION HEAD");
                    comboBox2.Items.Add("EOL TESTING");
                    comboBox2.Items.Add("GENERAL");
                    comboBox2.Items.Add("MOL S");
                    comboBox2.Items.Add("MOL S LINE LEADER");
                    comboBox2.Items.Add("MOL S SECTION HEAD");
                    comboBox2.Items.Add("MOL WOUND");
                    comboBox2.Items.Add("MOL WOUND LINE LEADER");
                    comboBox2.Items.Add("MOL WOUND SECTION HEAD");
                    comboBox2.Items.Add("PROD. IN PROCESS YIELD IMPROVE");
                    comboBox2.Items.Add("PROD. INNOVATION & DEVELOPMENT");
                    comboBox2.Items.Add("PRODUCTION ENGINEERING");
                    comboBox2.Items.Add("PRODUCTION SUPERVISORY");
                    break;

                case "Quality" :
                    this.comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("DOCUMENT CONTROL CENTRE");
                    comboBox2.Items.Add("ENVIRONMENT HEALTH SAFETY");
                    comboBox2.Items.Add("FINAL INSPECTION");
                    comboBox2.Items.Add("GENERAL");
                    comboBox2.Items.Add("INCOMING");
                    comboBox2.Items.Add("IPQC");
                    comboBox2.Items.Add("LINE LEADER");
                    comboBox2.Items.Add("OUTGOING");
                    comboBox2.Items.Add("QUALITY MANAGEMENT SYSTEM");
                    comboBox2.Items.Add("SECTION HEAD");
                    comboBox2.Items.Add("SUPPORTING TEAM");
                    comboBox2.Items.Add("TRAINING");
                    break;
            }
        }
    }
}
