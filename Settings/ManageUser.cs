﻿using System;
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
    public partial class ManageUser : Form
    {
        OTDB DB = new OTDB();
        public int i = 0;
        public string t = "";
        public ManageUser()
        {
            InitializeComponent();
            userLists();
            selected();
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (countDatabase() == 0)
                {
                    usernameBox.Enabled = false;
                    saveButton.Text = "Save";
                    deleteButton.Enabled = false;
                    sectionButton.Enabled = false;
                }
                else 
                {
                    usernameBox.Enabled = false;
                    saveButton.Text = "Update";
                    deleteButton.Enabled = true;
                    sectionButton.Enabled = true;
                }
                enable();
                passwordBox.Focus();
            }
        }     
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Button

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "";
            string messaging = "";
            string pass = "";
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Password Can't be Empty!");
            }
            else if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Password Can't be Empty!");
            }
            else if (string.IsNullOrEmpty(positionBox.Text))
            {
                MessageBox.Show("Position Can't be Empty!");
            }
            else if (string.IsNullOrEmpty(departmentBox.Text))
            {
                MessageBox.Show("Department Can't be Empty!");
            }
            else if (string.IsNullOrEmpty(sectionBox.Text))
            {
                MessageBox.Show("Section Can't be Empty!");
            }
            else
            {
                if (countDatabase() >= 1)
                {
                    if (this.t == passwordBox.Text)
                    {
                        pass = passwordBox.Text;
                    }
                    else
                    {
                        pass = MD5Hash(passwordBox.Text);
                    }
                    query = "UPDATE account SET password='" + pass + "', name='" + nameBox.Text + "', position='" + positionBox.Text + "', departmentName='" + departmentBox.Text + "', sectionName='" + sectionBox.Text + "' WHERE username='" + usernameBox.Text + "'";
                    messaging = "Data Just Updated!";

                }
                else
                {
                    query = "INSERT INTO account (Username,Password,Name,Position,departmentName,sectionName) VALUES('" + usernameBox.Text + "','" + MD5Hash(passwordBox.Text) + "','" + nameBox.Text + "','" + positionBox.Text + "','" + departmentBox.Text + "','" + sectionBox.Text + "')";
                    messaging = "Data Just Saved!";
                }

                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
                DB.CloseConnection();

                MessageBox.Show(messaging, "Success!");
                refresh();
                selected();
                usernameBox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings set = new Settings();
            set.Closed += (s, args) => this.Close();
            set.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM account WHERE Username='" + usernameBox.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            cmd.ExecuteNonQuery();
            DB.CloseConnection();

            refresh();
            selected();
            usernameBox.Focus();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            refresh();
            usernameBox.Focus();
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Support
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
        private int countDatabase()
        {
            string query = "SELECT COUNT(username) FROM account WHERE username = '" + usernameBox.Text + "'";
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
        private void enable()
        {
            passwordBox.Enabled = true;
            nameBox.Enabled = true;
            positionBox.Enabled = true;
            searchDept.Enabled = true;

            saveButton.Enabled = true;
            deleteButton.Enabled = true;
            cancelButton.Enabled = true;

            if (countDatabase() >= 1)
            {
                selectDatabase(usernameBox.Text);
            }
            else if (countDatabase() == 0)
            {
                passwordBox.Text = "";
                nameBox.Text = "";
                clear();
            }
        }

        private void selectDatabase(string username)
        {
            string query = "SELECT password, position, name, departmentName, sectionName FROM account WHERE username = '" + username + "'";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                passwordBox.Text = Reader.GetString(0);
                positionBox.Text = Reader.GetString(1);
                nameBox.Text = Reader.GetString(2);
                departmentBox.Text = Reader.GetString(3);
                sectionBox.Text = Reader.GetString(4);
            }
            this.t = Reader.GetString(0);
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        public void clear()
        {
            positionBox.Items.Clear();
            positionBox.Items.Add("Submitter");
            positionBox.Items.Add("Approver 1");
            positionBox.Items.Add("Approver 2");
            positionBox.Items.Add("Approver 3");
            positionBox.Items.Add("Administrator");

            departmentBox.Text = "";
            sectionBox.Text = "";
        }

        private void userLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Username", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Position", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", 95, HorizontalAlignment.Left);
            listView1.Columns.Add("Section", -2, HorizontalAlignment.Left);
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

            string query = "Select username, name, position, departmentName, sectionName from account ORDER BY position ASC";
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
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }
        private void refresh() 
        {
            usernameBox.Enabled = true;
            usernameBox.Text = "";
            passwordBox.Text = "";
            nameBox.Text = "";
            clear();

            passwordBox.Enabled = false;
            nameBox.Enabled = false;
            positionBox.Enabled = false;
            departmentBox.Enabled = false;
            sectionBox.Enabled = false;

            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
                sectionBox.Text = "";
                sectionButton.Enabled = true;
            }
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            var ASL = new All_List.SectionList(departmentBox.Text);

            if (ASL.ShowDialog() == DialogResult.OK)
            {
                sectionBox.Text = ASL.sectionItems;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            usernameBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            usernameBox.Enabled = false;
            saveButton.Text = "Update";
            deleteButton.Enabled = true;
            sectionButton.Enabled = true;
            enable();
            passwordBox.Focus();
        }
    }
}
