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
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(CEBox.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(departmentBox.Text) || string.IsNullOrEmpty(sectionBox.Text))
            {
                MessageBox.Show("Data Must Not Empty");
            }
            else if (equalitychecker(username.Text,true) == true || equalitychecker(username.Text,false) == true)
            {
                MessageBox.Show("Username is Already Taken!");
                clear();
            }
            else {
                string query = "INSERT INTO registerusername (Username,Password,Name,Position,departmentName,sectionName) VALUES('" + username.Text + "','" + MD5Hash(password.Text) + "','" + CEBox.Text + "','" + comboBox1.Text + "','" + departmentBox.Text + "','" + sectionBox.Text + "')";
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
            CEBox.Text = "";
            departmentBox.Text = "";
            sectionBox.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Submitter");
            comboBox1.Items.Add("Approver 1");
            comboBox1.Items.Add("Approver 2");
            comboBox1.Items.Add("Approver 3");            
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
                searchSect.Enabled = true;
            }
        }

        private void searchSect_Click(object sender, EventArgs e)
        {
            var ASL = new All_List.SectionList(departmentBox.Text);

            if (ASL.ShowDialog() == DialogResult.OK)
            {
                sectionBox.Text = ASL.sectionItems;
            }
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            var ED = new Employeedata();

            if (ED.ShowDialog() == DialogResult.OK)
            {
                CEBox.Text = ED.employee[1];
            }
        }
    }
}
