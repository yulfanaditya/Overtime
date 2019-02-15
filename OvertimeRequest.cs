using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OT_Management
{
    public partial class OvertimeRequest : Form
    {
        public bool ORB;
        public int i = 0;
        public OvertimeRequest()
        {
            InitializeComponent();
            OTRequests();
            OvertimeCodeList OCL = new OvertimeCodeList();
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
                MessageBox.Show("Overtime Activity or Employee List can't be Empty");
            }
            else if (string.IsNullOrEmpty(RemarkBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to add without Remark?", "Empty Remark", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    i++;
                    ListViewItem lv = new ListViewItem(i.ToString());
                    lv.SubItems.Add(ORBox.Text);
                    lv.SubItems.Add(OABox.Text);
                    lv.SubItems.Add(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                    lv.SubItems.Add(labeljam.Text);
                    lv.SubItems.Add(CEBox.Text);

                    listView1.Items.Add(lv);
                    refresh();
                }
            }
            else {
                i++;
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(ORBox.Text);
                lv.SubItems.Add(OABox.Text);
                lv.SubItems.Add(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                lv.SubItems.Add(labeljam.Text);
                lv.SubItems.Add(CEBox.Text);
                lv.SubItems.Add(RemarkBox.Text);

                listView1.Items.Add(lv);
                refresh();
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
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
            listView1.Columns.Add("No", 20, HorizontalAlignment.Center);
            listView1.Columns.Add("No Request", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Activity", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Sum of OT", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Employee Name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Remark", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
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

    }
}

