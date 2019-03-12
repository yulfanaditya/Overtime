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
    public partial class Employeedata : Form
    {
        OTDB DB = new OTDB();
        public string[] employeedata = {"", "", ""};

        public string[] employee {
            get { return employeedata; }
            set { employeedata = value; }
        }
        public Employeedata()
        {
            InitializeComponent();
            EmployeeLists();
            selected();
            comboBox1.Text = "By Name";
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }
        public void selected()
        {
            DB.inializing();

            string query = "Select Badge, Name, DoJ, timeRemain, sectionName FROM karyawan WHERE departmentName = '" + Global.GlobalVar[2] + "' ORDER BY sectionName ASC";
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            employee[0] = listView1.SelectedItems[0].SubItems[0].Text;
            employee[1] = listView1.SelectedItems[0].SubItems[1].Text;
            employee[2] = listView1.SelectedItems[0].SubItems[4].Text;

            DialogResult = DialogResult.OK;
        }

        private void EmployeeLists()
        {
            listView1.Columns.Add("Badge", 55, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Time Remain", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "By Name")
            {
                DB.inializing();

                string query = "Select Badge, Name, DoJ, timeRemain, sectionName FROM karyawan WHERE Name LIKE '" + textBox1.Text + "%' AND departmentName = '" + Global.GlobalVar[2] + "' ORDER BY Name ASC";
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
            else if (comboBox1.Text == "By Badge") 
            {
                DB.inializing();

                string query = "Select Badge, Name, DoJ, timeRemain, sectionName FROM karyawan WHERE Badge LIKE '" + textBox1.Text + "%' AND departmentName = '" + Global.GlobalVar[2] + "' ORDER BY Badge ASC";
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

            /*if (textBox1.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(textBox1.Text.ToString()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            {
                listView1.Items.Clear();
                selected();
            }
             */

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            selected();
        }
    }
}