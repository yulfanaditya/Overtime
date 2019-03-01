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
    public partial class Status : Form
    {
        OTDB DB = new OTDB();
        public Status()
        {
            InitializeComponent();
            departmentBox.Text = Global.GlobalVar[2];
            sectionBox.Text = Global.GlobalVar[3];
            coloumnSet();
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
                selectData();
            }
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            var ASL = new All_List.SectionList(departmentBox.Text);

            if (ASL.ShowDialog() == DialogResult.OK)
            {
                sectionBox.Text = ASL.sectionItems;
                selectData();
            }
        }

        private void coloumnSet()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Employee Name", 125, HorizontalAlignment.Left);
            listView1.Columns.Add("Activity", 160, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Start Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Finish Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Hours", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("✓", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("✓", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("✓", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;

            selectData();
        }

        private void selectData()
        {
            DB.inializing();
            int i = 0;

            string query = "Select name, activity, date, finish, start, sumTime, approval1, approval2, approval3 FROM overtimerequest WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND departmentName = '" + departmentBox.Text + "' AND sectionName = '" + sectionBox.Text + "' ORDER BY approval1";
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
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));
                lv.SubItems.Add(Reader.GetString(7));
                lv.SubItems.Add(Reader.GetString(8));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            if(diff.Days < 0)
            {
                MessageBox.Show("You can't pick Date range with this kinda Date","Denied!");
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                selectData();
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            if (diff.Days < 0)
            {
                MessageBox.Show("You can't pick Date range with this kinda Date", "Denied!");
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                selectData();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }

        private void refreshBox_Click(object sender, EventArgs e)
        {
            selectData();
        }
    }
}
