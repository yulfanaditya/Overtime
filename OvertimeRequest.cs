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
        public OvertimeRequest()
        {
            InitializeComponent();
            DepartmentBox.Text = Global.GlobalVar[2];
            SectionBox.Text = Global.GlobalVar[3];
            labeljam.Text = "0";
            OTRequests();
            OvertimeCodeList OCL = new OvertimeCodeList();
           
        }
        public OvertimeRequest(string data) 
        {
            textBox2.Text = data;
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
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Overtime Activity or Employee List can't be Empty");
            }
            else if (string.IsNullOrEmpty(RemarkBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to add without Remark?", "Empty Remark", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
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
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Badge", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Employee Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Overtime", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Remark", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                    
        }
    }
}

