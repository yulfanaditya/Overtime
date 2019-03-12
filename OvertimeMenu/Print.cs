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
using CrystalDecisions.CrystalReports.Engine;

namespace OT_Management
{
    public partial class Print : Form
    {
        OTDB DB = new OTDB();
        public Print()
        {
            InitializeComponent();
            departmentBox.Text = Global.GlobalVar[2];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            if (diff.Days < 0)
            {
                MessageBox.Show("You can't pick Date range with this kinda Date", "Denied!");
                dateTimePicker1.Value = DateTime.Now;
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
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var PIL = new PrintItemsLists(dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), departmentBox.Text);
            if (PIL.ShowDialog() == DialogResult.OK)
            {
                string[] dataPrint = {"","","","",""};
                DB.inializing();
                for (int i = 0; i <= 3; i++) 
                {
                    dataPrint[i] = PIL.data[i];
                }

                string query = "SELECT name, departmentName,DATE_FORMAT(date, '%e %M  %Y') AS date, start, finish, sumTime, submitter, approvalName1, approvalName2, approvalName3, remark, Badge FROM overtimerequest WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND submitter = '" + dataPrint[0] + "' AND approvalName1 = '" + dataPrint[1] + "' AND approvalName2 = '" + dataPrint[2] + "' AND approvalName3 = '" + dataPrint[3] + "'";
                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();

                MySqlDataAdapter msda = new MySqlDataAdapter();
                msda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                ds.Clear();
                msda.Fill(ds, "DataOvertime");

                OvertimeMenu.Report rep = new OvertimeMenu.Report();
                rep.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rep;
                cmd.Dispose();
                DB.CloseConnection();

                    /*MySqlConnection conn; 
                    MySqlCommand cmd; 
                    MySqlDataAdapter adap; 

                    string[] dataPrint = {"","","","",""};
                    
                    for (int i = 0; i <= 3; i++) 
                    {
                        dataPrint[i] = PIL.data[i];
                    }
                    // Code to get data from database 
                    conn = new MySqlConnection("Server=192.168.110.22; Database=overtime; User ID=root; Password=123; charset=utf8;");
                    conn.Open(); 
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT overtimerequest.name, overtimerequest.departmentName, overtimerequest.date, overtimerequest.start, overtimerequest.finish, overtimerequest.sumTime, overtimerequest.submitter, overtimerequest.approvalName1, overtimerequest.approvalName2, overtimerequest.approvalName3, overtimerequest.remark, karyawan.badge FROM overtimerequest INNER JOIN  karyawan ON overtimerequest.name = karyawan.Name WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND submitter = '" + dataPrint[0] + "' AND approvalName1 = '" + dataPrint[1] + "' AND approvalName2 = '" + dataPrint[2] + "' AND approvalName3 = '" + dataPrint[3] + "'"; 

                    // Create a Dataset and using DataAdapter to fill it 
                    adap = new MySqlDataAdapter(); 
                    adap.SelectCommand = cmd;
                    DataSet custDB = new DataSet();
                    custDB.Clear(); 
                    adap.Fill(custDB, "DataOvertime");

                    Report rep = new Report();
                    rep.SetDataSource(custDB);
                    crystalReportViewer1.ReportSource = rep;*/
                }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }
    }
}
