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
        public OvertimeRequest()
        {
            InitializeComponent();
            labeljam.Text = "0";
            OTRequests();
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
          
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }
        private int hasil(int start, int finish)
        {
            int d = (finish - start + 24) % 24;

            return d;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int start = dateTimePicker2.Value.Hour;
            int finish = dateTimePicker3.Value.Hour;
            int hasill = hasil(start, finish);
            labeljam.Text = hasill.ToString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            int start = dateTimePicker2.Value.Hour;
            int finish = dateTimePicker3.Value.Hour;
            int hasill = hasil(start, finish);
            labeljam.Text = hasill.ToString();
        }

        private void labeljam_Click(object sender, EventArgs e)
        {

        }
        private void OTRequests()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Badge", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Employee Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Overtime", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Remark", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
        }
    }
}

