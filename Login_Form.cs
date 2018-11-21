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
            else 
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
                DBOT datab = new DBOT();

                datab.inializing();
                check = datab.CheckConnection();
                check = datab.checkingUserPassword(userid.Text, password.Text);
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


        ///////////////////////////////////Class For Database///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public class DBOT {
            MySqlConnection connecting;
            private string server = "192.168.110.22";
            private string database = "overtime";
            private string user = "root";
            private string password = "123";

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            public void inializing(){
            string connect;

            connect = "SERVER=" + server + ";" + "DATABASE=" 
            + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            connecting = new MySqlConnection(connect);
                        
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            public bool CheckConnection()
            {
                try
                {
                    connecting.Open();

                    return true;
                }
                catch (MySqlException ex)
                {

                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Call at *160 or *146");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    
                    return false;
                }
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            public bool checkingUserPassword(string User, string Password){
                MySqlDataAdapter linier;
                string MD5Hasher;
                DataTable table = new DataTable();

                MD5Hasher = MD5Hash(Password);
    
                linier = new MySqlDataAdapter("SELECT Username,Password FROM account WHERE Username = '" + User + "' AND Password = '" + MD5Hasher + "'", connecting);
                linier.Fill(table);

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
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {
           
        }

        

    }
}
