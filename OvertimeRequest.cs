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
    public partial class OvertimeRequest : Form
    {
        public bool ORB;
        private int i = 0;
        OTDB DB = new OTDB();
        
        public OvertimeRequest()
        {
            InitializeComponent();
            OTRequests();
            //OvertimeCodeList OCL = new OvertimeCodeList();
            refresh();
           
        }
        public OvertimeRequest(string data) 
        {
            ORBox.Text = data;
        }

        private void OvertimeRequest_Load(object sender, EventArgs e)
        {
            
        }

        private void searchdept_Click(object sender, EventArgs e)
        {

        }

        private void searchOTC_Click(object sender, EventArgs e)
        {
            OvertimeCodeList home = new OvertimeCodeList();   
            home.ShowDialog();
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            EmployeeList home = new EmployeeList();
            home.ShowDialog();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CEBox.Text) || string.IsNullOrEmpty(OABox.Text))
            {
                MessageBox.Show("Overtime Activity or Employee List can't be Empty","Empty Output");
            }
            else if(labeljam.Text == "0.00")
            {
                MessageBox.Show("Sum of overtime can't be 0", "Empty Output");
            }
            else if (string.IsNullOrEmpty(RemarkBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to add without Remark?", "Empty Remark", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    i++;
                    ListViewItem lv = new ListViewItem(i.ToString());
                    lv.SubItems.Add(CEBox.Text);
                    lv.SubItems.Add(OABox.Text);
                    lv.SubItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    lv.SubItems.Add(dateTimePicker2.Value.ToString("HH : mm"));
                    lv.SubItems.Add(dateTimePicker3.Value.ToString("HH : mm"));
                    lv.SubItems.Add(labeljam.Text);
                    lv.SubItems.Add(ORBox.Text);

                    listView1.Items.Add(lv);
                    refresh();
                    resetCounter();
                }
            }
            else {
                i++;
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(CEBox.Text);
                lv.SubItems.Add(OABox.Text);
                lv.SubItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                lv.SubItems.Add(dateTimePicker2.Value.ToString("HH : mm"));
                lv.SubItems.Add(dateTimePicker3.Value.ToString("HH : mm"));
                lv.SubItems.Add(labeljam.Text);
                lv.SubItems.Add(RemarkBox.Text);
                lv.SubItems.Add(ORBox.Text);

                listView1.Items.Add(lv);
                refresh();
                resetCounter();
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            OvertimeCodeList ocl = new OvertimeCodeList();
            EmployeeList el = new EmployeeList();

            ot.Closed += (s, args) => this.Close();
            ot.Closed += (s, args) => ocl.Close();
            ot.Closed += (s, args) => el.Close();
            ot.Show();
        }
        private double hasil(int start, int finish, int start1, int finish1)
        {
            double w = ((finish - start + 24) % 24) + ((double)((finish1 - start1 + 60) % 60) / 60);
            return w;
        }

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

        private void labeljam_Click(object sender, EventArgs e)
        {

        }
        private void OTRequests()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Employee Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Activity", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Start", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Finish", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Hour", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Remark", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Code", 120, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }
        private void addingData()
        {
            string[,] lists = new string[listView1.Items.Count+1, 8];
            string query;
            DB.inializing();

            for (int i = 0; i <= listView1.Items.Count; i++) 
            {
                for (int j=0; j <= 8; j++ )
                {
                    lists[i, j] = listView1.Items[i].SubItems[j].ToString(); ;
                }
                query = "INSERT INTO overtimerequest (name, activity, date, start, finish, sumTime, remark, code) VALUES('" + lists[i,1] + "','" + lists[i,2] + "','" + lists[i,3] + "','" + lists[i,4] + "','" + lists[i,5] + "','" + lists[i,6] + "','" + lists[i,7] + "','" + lists[i,8] + "')";

                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            DB.CloseConnection();
        }
        private void refresh() {
            ORBox.Text = "";
            OABox.Text = "";
            dateTimePicker3.Text = "00: 00";
            dateTimePicker2.Text = "00: 00";
            DepartmentBox.Text = Global.GlobalVar[2];
            SectionBox.Text = Global.GlobalVar[3];
            CEBox.Text = "";
            RemarkBox.Text = "";

            switch (Global.GlobalVar[2])
            {
                case "Accounting":
                    ORBox.Text = "01" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "Engineering":
                    ORBox.Text = "02" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "General Manager":
                    ORBox.Text = "03" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "HR & GA":
                    ORBox.Text = "04" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "MIS":
                    ORBox.Text = "05" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "Maintenance":
                    ORBox.Text = "06" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "PPCWL":
                    ORBox.Text = "07" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "Production":
                    ORBox.Text = "08" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;

                case "Quality":
                    ORBox.Text = "09" + DateTime.Now.ToString("yyddMMHHmmssff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    break;
            }
            
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
           // string sub[this.i,] = addingData(this.i);
            //MessageBox.Show(addingData(this.i).GetLength(0).ToString());
            MessageBox.Show(listView1.SelectedIndices.Count.ToString());
        }

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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
            resetCounter();
           
        }

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
                    MessageBox.Show("Can't have a break when overtime less equal than a hour","Break Time Rejected!");
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
        }

        private void resetCounter() 
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i-1].SubItems[0].Text = i.ToString();
            }

        }

    }
}

