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
        public Employeedata()
        {
            InitializeComponent();
            EmployeeLists();
            selected();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }
        public void selected()
        {
            DB.inializing();

            string query = "Select Badge, Name, DoJ, timeRemain FROM karyawan WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + Global.GlobalVar[3] + "' ORDER BY Badge ASC";
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
            string datalocals = listView1.SelectedItems[0].SubItems[1].Text;
            OvertimeRequest f1 = (OvertimeRequest)Application.OpenForms["OvertimeRequest"];
            TextBox tb = (TextBox)f1.Controls["CEBox"];
            tb.Text = datalocals;
         
            this.Close();
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

            if (textBox1.Text != "")
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
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            
        }
    }
}