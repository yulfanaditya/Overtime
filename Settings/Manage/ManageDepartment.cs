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
    public partial class ManageDepartment : Form
    {
        OTDB DB = new OTDB();
        public ManageDepartment()
        {
            InitializeComponent();
            deptLists();
            selected();
        }

        private void deptLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "";
            string messaging = "";
            if (string.IsNullOrEmpty(departmentBox.Text))
            {
                MessageBox.Show("Department can't be Empty", "Denied!");
                departmentBox.Focus();
            }
            else
            {
                if (countDatabase() >= 1)
                {
                    query = "UPDATE department SET departmentName='" + departmentBox.Text + "' WHERE departmentCode = '" + codeBox.Text + "'";
                    messaging = "Data Just Updated!";
                }
                else
                {
                    query = "INSERT INTO department (departmentCode, departmentName) VALUES('" + codeBox.Text + "','" + departmentBox.Text + "')";
                    messaging = "Data Just Saved!";
                }
                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());

                if (DB.OpenConnection() == true)
                {
                    cmd.ExecuteNonQuery();
                    DB.CloseConnection();
                }
                MessageBox.Show(messaging, "Success!");
                selected();
                departmentBox.Text = "";
                codeBox.Text = "";
                departmentBox.Enabled = false;
                codeBox.Enabled = true;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
                cancelButton.Enabled = false;
                codeBox.Focus();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM department WHERE departmentCode='" + codeBox.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            if (DB.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
                DB.CloseConnection();
            }
            departmentBox.Enabled = false;
            codeBox.Enabled = true;
            departmentBox.Text = "";
            codeBox.Text = "";
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            codeBox.Focus();
            selected();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            departmentBox.Enabled = false;
            codeBox.Enabled = true;
            departmentBox.Text = "";
            codeBox.Text = "";
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            codeBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseSettings ds = new DatabaseSettings();
            ds.Closed += (s, args) => this.Close();
            ds.Show();
        }

        public void selected()
        {
            int i = 0;
            DB.inializing();

            string query = "Select departmentCode, departmentName from department ORDER BY departmentCode ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            if (DB.OpenConnection() == true)
            {
                MySqlDataReader Reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(i.ToString());
                    lv.SubItems.Add(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    listView1.Items.Add(lv);

                }
                Reader.Close();
                cmd.Dispose();
                DB.CloseConnection();
                resetCounter();
            }
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
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

                saveButton.Enabled = true;
                cancelButton.Enabled = true;
                departmentBox.Focus();
            }
        }

        private int countDatabase()
        {
            string query = "SELECT COUNT(departmentCode) FROM department WHERE departmentCode = '" + codeBox.Text + "'";
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
            string query = "SELECT departmentName FROM department WHERE departmentCode = '" + codeBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                departmentBox.Text = Reader.GetString(0);
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            codeBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            saveButton.Text = "Update";
            deleteButton.Enabled = true;
            codeBox.Enabled = false;
            departmentBox.Enabled = true;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;

            selectDatabase();
            departmentBox.Focus();
        }

    }
}
