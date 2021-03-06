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

namespace OT_Management
{
    public partial class OvertimeRequest : Form
    {
        public string departmentItems { get; set; }
        public bool ORB;
        private int i = 0;
        OTDB DB = new OTDB();
        public string badge;
        public string section;
        public OvertimeRequest()
        {
            InitializeComponent();
            OTRequests();
            refresh();           
        }
//=========================================================================================================================================================================
//dateTimePicker
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int start = dateTimePicker2.Value.Hour;
            int finish = dateTimePicker3.Value.Hour;
            int start1 = dateTimePicker2.Value.Minute;
            int finish1 = dateTimePicker3.Value.Minute;
            double hasill = hasil(start, finish, start1, finish1);

            labeljam.Text = hasill.ToString("n2");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            int start = dateTimePicker2.Value.Hour;
            int finish = dateTimePicker3.Value.Hour;
            int start1 = dateTimePicker2.Value.Minute;
            int finish1 = dateTimePicker3.Value.Minute;
            double hasill = hasil(start, finish, start1, finish1);

            labeljam.Text = hasill.ToString("n2");
         }

//=========================================================================================================================================================================
//Listview
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                deletebutton.Enabled = true;
            }
            else if (listView1.SelectedIndices.Count <= 0) 
            {
                deletebutton.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                deletebutton.Enabled = true;
            }
            else if (listView1.SelectedIndices.Count <= 0)
            {
                deletebutton.Enabled = false;
            }

            if (listView1.Items.Count == 0)
            {
                savebutton.Enabled = false;
            }
            else
            {
                savebutton.Enabled = true;
            }
        }

//=========================================================================================================================================================================
//CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int start = dateTimePicker2.Value.Hour;
                int finish = dateTimePicker3.Value.Hour;
                int start1 = dateTimePicker2.Value.Minute;
                int finish1 = dateTimePicker3.Value.Minute;
                double hasill = hasil(start, finish, start1, finish1);
                if (hasill <= 1.00)
                {
                    MessageBox.Show("Can't have a break when overtime less equal than a hour", "Break Time Rejected!");
                    checkBox1.Checked = false;
                }
                else
                {
                    hasill = hasill - 1.00;
                }
                labeljam.Text = hasill.ToString("n2");
            }
            else
            {
                int start = dateTimePicker2.Value.Hour;
                int finish = dateTimePicker3.Value.Hour;
                int start1 = dateTimePicker2.Value.Minute;
                int finish1 = dateTimePicker3.Value.Minute;
                double hasill = hasil(start, finish, start1, finish1);
                labeljam.Text = hasill.ToString("n2");
            }
        }
//=========================================================================================================================================================================
//Button
        private void savebutton_Click(object sender, EventArgs e)
        {
            addingData();
            listView1.Clear();
            OTRequests();
            savebutton.Enabled = false;
            deletebutton.Enabled = false;
            MessageBox.Show("Data Just Saved!");
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
            resetCounter();
            if (listView1.Items.Count == 0)
            {
                savebutton.Enabled = false;
            }
            else
            {
                savebutton.Enabled = true;
            }

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OABox.Text))
            {
                MessageBox.Show("Overtime Activity can't be Empty", "Empty Output");
            }
            else if (string.IsNullOrEmpty(CEBox.Text))
            {
                MessageBox.Show("Employee Name can't be Empty", "Empty Output");
            }
            else if (labeljam.Text == "0.00")
            {
                MessageBox.Show("Sum of overtime can't be 0", "Empty Output");
            }
            else if(nameChecker(CEBox.Text))
            {
                MessageBox.Show("you can't input same employee","Rejected!");
                CEBox.Text = "";
            }
            else if (string.IsNullOrEmpty(RemarkBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to add without Remark?", "Empty Remark", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    i++;
                    ListViewItem lv = new ListViewItem(i.ToString());
                    lv.SubItems.Add(CEBox.Text);
                    lv.SubItems.Add(badge);
                    lv.SubItems.Add(OABox.Text);
                    lv.SubItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    lv.SubItems.Add(dateTimePicker2.Value.ToString("HH : mm"));
                    lv.SubItems.Add(dateTimePicker3.Value.ToString("HH : mm"));
                    lv.SubItems.Add(labeljam.Text);
                    lv.SubItems.Add("");
                    lv.SubItems.Add(ORBox.Text);
                    lv.SubItems.Add(DepartmentBox.Text);
                    lv.SubItems.Add(section);

                    listView1.Items.Add(lv);
                    refresh();
                    resetCounter();
                    savebutton.Enabled = true;
                }
            }
            else
            {
                i++;
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(CEBox.Text);
                lv.SubItems.Add(badge);
                lv.SubItems.Add(OABox.Text);
                lv.SubItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                lv.SubItems.Add(dateTimePicker2.Value.ToString("HH : mm"));
                lv.SubItems.Add(dateTimePicker3.Value.ToString("HH : mm"));
                lv.SubItems.Add(labeljam.Text);
                lv.SubItems.Add(RemarkBox.Text);
                lv.SubItems.Add(ORBox.Text);
                lv.SubItems.Add(DepartmentBox.Text);
                lv.SubItems.Add(section);

                listView1.Items.Add(lv);
                refresh();
                resetCounter();
                savebutton.Enabled = true;
            }
        }

        private void searchOTC_Click(object sender, EventArgs e)
        {
            var OCD = new OvertimeCodeData();

            if (OCD.ShowDialog() == DialogResult.OK)
            {
                OABox.Text = OCD.ActivityOT;
            }
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            var ED = new Employeedata(DepartmentBox.Text);

            if (ED.ShowDialog() == DialogResult.OK)
            {
                CEBox.Text = ED.employee[1];
                badge = ED.employee[0];
                section = ED.employee[2];
            }
        }
//=========================================================================================================================================================================
//Supporting Function

        private void resetCounter() 
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i-1].SubItems[0].Text = i.ToString();
            }

        }

        private void refresh()
        {
            OABox.Text = "";
            if(checkBox2.Checked == false)
            {
                dateTimePicker3.Text = "00:00";
                dateTimePicker2.Text = "00:00";
            }
            DepartmentBox.Text = Global.GlobalVar[2];
            CEBox.Text = "";
            RemarkBox.Text = "";
            checkBox1.Checked = false;

            switch (Global.GlobalVar[2])
            {
                case "ACCOUNTING":
                    ORBox.Text = "01" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "ENGINEERING":
                    ORBox.Text = "02" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "GENERAL MANAGER":
                    ORBox.Text = "03" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "HR & GA":
                    ORBox.Text = "04" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "MIS":
                    ORBox.Text = "05" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "MAINTENANCE":
                    ORBox.Text = "06" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "PPCWL":
                    ORBox.Text = "07" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "PRODUCTION":
                    ORBox.Text = "08" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "QUALITY":
                    ORBox.Text = "09" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;
            }

        }

        private void OTRequests()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Employee Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Badge", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Activity", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Start", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Finish", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Hour", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Remark", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Code", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Department", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Section", 120, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }
        private void addingData()
        {
            string[,] lists = new string[listView1.Items.Count + 1, listView1.Columns.Count + 1];
            string query;
            DB.inializing();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j <listView1.Columns.Count ; j++)
                {
                    lists[i, j] = listView1.Items[i].SubItems[j].Text;
                }
                query = "INSERT INTO overtimerequest (name, Badge, departmentName, sectionName, activity, date, start, finish, sumTime, remark, code, submitter, approval1, approval2, approval3) VALUES('" + lists[i, 1] + "','" + lists[i, 2] + "','" + lists[i, 10] + "','" + lists[i, 11] + "','" + lists[i, 3].ToString() + "','" + lists[i, 4] + "','" + lists[i, 5] + "','" + lists[i, 6] + "','" + lists[i, 7] + "','" + lists[i, 8] + "','" + lists[i, 9] + "','" + Global.GlobalVar[0] + "',0,0,0)";

                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            DB.CloseConnection();

        }

        private double hasil(int start, int finish, int start1, int finish1)
        {
            double w = ((finish - start + 24) % 24) + ((double)((finish1 - start1 + 60) % 60) / 60);
            return w;
        }
        private bool nameChecker(string name){
            for (int i = 0;i < listView1.Items.Count;i++ )
            {
                if (listView1.Items[i].SubItems[1].Text == name) 
                {
                    return true;
                }
                
            }
            return false;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void SectionBox_TextChanged(object sender, EventArgs e)
        {

        }
//=============================================================================================================================================================================================

    }//Class
}//Package

