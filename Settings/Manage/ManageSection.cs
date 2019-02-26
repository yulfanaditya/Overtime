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
    public partial class ManageSection : Form
    {
        OTDB DB = new OTDB();
        public int i = 0;
        public ManageSection()
        {
            InitializeComponent();
            deptLists();
            selected();
        }

        private void codeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (countDatabase() == 0)
                {
                    saveButton.Text = "Save";
                    deleteButton.Enabled = false;
                    
                }
                else
                {
                    saveButton.Text = "Update";
                    deleteButton.Enabled = true;
                    selectDatabase();
                }
                codeBox.Enabled = false;
                departmentBox.Enabled = true;
                sectionBox.Enabled = true;

                saveButton.Enabled = true;
                cancelButton.Enabled = true;
                departmentBox.Focus();
            }
        }

        private void departmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(departmentBox.Text != "")
            {
                codeBox.Enabled = true;
            }
        }


        private void deptLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Section Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Section", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", -2, HorizontalAlignment.Left);
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        public void selected()
        {
            DB.inializing();

            string query = "Select sectionCode, sectionName, departmentName from section ORDER BY sectionCode ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseSettings ds = new DatabaseSettings();
            ds.Closed += (s, args) => this.Close();
            ds.Show();
        }

        private int countDatabase()
        {
            string query = "SELECT COUNT(sectionCode) FROM section WHERE sectionCode = '" + codeBox.Text + "'";
            int i = 0;
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                i = int.Parse(Reader.GetString(0));

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            return i;
        }

        private void selectDatabase()
        {
            string query = "SELECT departmentName, sectionName FROM section WHERE sectionCode = '" + codeBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                departmentBox.Text = Reader.GetString(0);
                sectionBox.Text = Reader.GetString(1);
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "";
            string messaging = "";
            if (string.IsNullOrEmpty(sectionBox.Text))
            {
                MessageBox.Show("Section Box can't be Empty", "Denied!");
                sectionBox.Focus();
            }
            else 
            {
                if (countDatabase() >= 1)
                {
                    query = "UPDATE section SET sectionName='" + sectionBox.Text + "', departmentName='" + departmentBox.Text + "' WHERE sectionCode = '"+codeBox.Text+"'";
                    messaging = "Data Just Updated!";
                }
                else
                {
                    query = "INSERT INTO section (sectionCode, departmentName, sectionName) VALUES('" + codeBox.Text + "','" + departmentBox.Text + "','" + sectionBox.Text + "')";
                    messaging = "Data Just Saved!";
                }
                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
                DB.CloseConnection();

                MessageBox.Show(messaging, "Success!");
                refresh();
                selected();
                codeBox.Focus();
            }
        }
        private void refresh()
        {
            codeBox.Enabled = true;
            departmentBox.Enabled = false;
            sectionBox.Enabled = false;

            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;

            codeBox.Text = "";
            sectionBox.Text = "";
            
            departmentBox.Items.Clear();
            departmentBox.Items.Add("ACCOUNTING");
            departmentBox.Items.Add("ENGINEERING");
            departmentBox.Items.Add("GENERAL MANAGER");
            departmentBox.Items.Add("HR & GA");
            departmentBox.Items.Add("MIS");
            departmentBox.Items.Add("MAINTENANCE");
            departmentBox.Items.Add("PPCWL");
            departmentBox.Items.Add("PRODUCTION");
            departmentBox.Items.Add("QUALITY");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM section WHERE sectionCode='" + codeBox.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            cmd.ExecuteNonQuery();
            DB.CloseConnection();

            refresh();
            selected();
            codeBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            refresh();
            codeBox.Focus();
        }

        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
