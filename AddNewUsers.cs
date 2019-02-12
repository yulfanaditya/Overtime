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
    public partial class AddNewUsers : Form
    {
        OTDB DB = new OTDB();
        public AddNewUsers()
        {
            InitializeComponent();
            UserLists();
            selected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void selected()
        {
            DB.inializing();

            string query = "Select Username, Name, Position, departmentName, sectionName from registerusername ORDER BY departmentName ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void UserLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Username", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 190, HorizontalAlignment.Left);
            listView1.Columns.Add("Position", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Section", 100 , HorizontalAlignment.Left);
        }

        public void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            usernameBox.Text =      listView1.SelectedItems[0].SubItems[0].Text;
            nameBox.Text =          listView1.SelectedItems[0].SubItems[1].Text;
            positionBox.Text =      listView1.SelectedItems[0].SubItems[2].Text;
            departmentBox.Text =    listView1.SelectedItems[0].SubItems[3].Text;
            sectionBox.Text =       listView1.SelectedItems[0].SubItems[4].Text;

            Approve.Enabled = true;
            Decline.Enabled = true;
        }

        public void Insert()
        {
            string query1 = "INSERT INTO account (Name, Username, Password, Position, departmentName, sectionName) SELECT Name, Username, Password, Position, departmentName, sectionName FROM registerusername WHERE Username = '"+usernameBox.Text+"' AND Name = '"+nameBox.Text+"'";
            DB.inializing();
            DB.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query1, DB.inializing());
            DB.inializing().Open();
            cmd.ExecuteNonQuery();
            DB.CloseConnection();
        }

        public void Delete()
        {
            string query = "DELETE FROM registerusername WHERE Username='" + usernameBox.Text + "' AND Name='" + nameBox.Text + "'";
            //DB.inializing();

            DB.OpenConnection();
            
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            cmd.ExecuteNonQuery();
            DB.CloseConnection();
        }
 

        private void Approve_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to add "+ usernameBox.Text +" ?", "Approving", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Insert();
                Delete();

                usernameBox.Text = "";
                nameBox.Text = "";
                positionBox.Text = "";
                departmentBox.Text = "";
                sectionBox.Text = "";
            }
        }
    }
}
