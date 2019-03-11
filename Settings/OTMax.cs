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
    public partial class OTMax : Form
    {
        OTDB DB = new OTDB();
        public OTMax()
        {
            InitializeComponent();
            selected();
        }

        public void selected()
        {
            DB.inializing();

            string query = "Select OTMAX from overtimemax";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                timeBox.Text = Reader.GetInt16(0).ToString();
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "";
            string messaging = "";
            if (string.IsNullOrEmpty(timeBox.Text))
            {
                MessageBox.Show("Time Max Can't be Empty!");
            }
            else
            {
                query = "UPDATE overtimemax SET OTMAX='" + timeBox.Text + "'";
                messaging = "Data Just Updated!";

                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                if (DB.OpenConnection() == true)
                {
                    cmd.ExecuteNonQuery();
                    DB.CloseConnection();
                }
                MessageBox.Show(messaging, "Success!");
                timeBox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings set = new Settings();
            set.Closed += (s, args) => this.Close();
            set.Show();
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
