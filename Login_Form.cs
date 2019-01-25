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
    public partial class Login_Form : Form
    {
        public static string datauser;
        OTDB datab = new OTDB();

        public string userdata { get; set; }

        public Login_Form()
        {
            InitializeComponent();
            Login_button.Enabled = true;
            this.AcceptButton = Login_button;
            userid.Select();
            if (Properties.Settings.Default.check == true)
            {
                userid.Text = Properties.Settings.Default.username;
                password.Text = Properties.Settings.Default.password;
                remember_me.Checked = true;
            }
            else if(Properties.Settings.Default.check == false)
            {
                userid.Text = "";
                password.Text = "";
                remember_me.Checked = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if(Control.IsKeyLocked(Keys.CapsLock)){
                MessageBox.Show("Capslock Is On");
            }
        }

        private void remember_me_CheckedChanged(object sender, EventArgs e)
        {
           if (remember_me.Checked == true)
            {
                Properties.Settings.Default.username = this.userid.Text;
                Properties.Settings.Default.password = this.password.Text;
                Properties.Settings.Default.check = true;
            }
            else if (remember_me.Checked == false)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.check = false;
            }
        }
        
        private void Login_button_Click(object sender, EventArgs e)
        {
            bool check;
            

            if ((userid.Text == "") && (password.Text == ""))
            {
                MessageBox.Show("UserID and Password are Empty");
            }
            else if ((userid.Text == "") || (password.Text == ""))
            {
                MessageBox.Show("UserID or Password are Empty");
            }
            else
            {
                
                datab.inializing();
                datab.CheckConnection();
                check = checkingUserPassword(userid.Text, password.Text);
                if (check == true)
                {
                    this.Hide();
                    Home home = new Home();
                    home.Closed += (s, args) => this.Close();
                    home.Show();

                }
                datauser = userid.Text;

            }
        }
        
        public bool checkingUserPassword(string User, string Password)
        {
            MySqlDataAdapter linier;
            string MD5Hasher;
            DataTable table = new DataTable();

            MD5Hasher = MD5Hash(Password);

            linier = new MySqlDataAdapter("SELECT Username,Password FROM account WHERE Username = '" + User + "' AND Password = '" + MD5Hasher + "'",datab.inializing());
            linier.Fill(table);
            getData(User,MD5Hasher);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid UserID or Password");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void getData(string User, string Password)
        {
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            datab.inializing();
            string query = "SELECT Name,Position,departmentName,sectionName FROM account WHERE Username = '" + User + "' AND Password = '" + Password + "'";

            MySqlCommand cmd = new MySqlCommand(query, datab.inializing());
            datab.CheckConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                Global.GlobalVar[0] = Reader.GetString(0); //Name
                Global.GlobalVar[1] = Reader.GetString(1); //Position
                Global.GlobalVar[2] = Reader.GetString(2); //Department
                Global.GlobalVar[3] = Reader.GetString(3); //Section
            }

            Reader.Close();
            cmd.Dispose();
            datab.CloseConnection();

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
       
        private void userid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_List.DepartmentList or = new All_List.DepartmentList();
            or.Closed += (s, args) => this.Close();
            or.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register or = new Register();
            or.Closed += (s, args) => this.Close();
            or.Show();
        }

    }
}
