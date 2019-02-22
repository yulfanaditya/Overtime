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
    public partial class Approval : Form
    {
        OTDB DB = new OTDB();
        public Approval()
        {
            InitializeComponent();
            catchSection();
            viewList();
            //justAccess();
        }
        private void viewData() {
                                    
           
        }
        private void viewList()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Employee Name", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("Activity", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Start Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Finish Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Hours", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("RequestCode", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;

            catchAcess();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            catchAcess();
        }

        private void catchAcess()
        {
            string query = "";
            int i = 0;

            switch (Global.GlobalVar[1])
            {
                case "Approver 1" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text +"' AND approval1 = 0";
                    break;
                case "Approver 2" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text + "' AND approval1 = '1' AND approval2 = '0'";
                    break;
                case "Approver 3" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text + "' AND approval1 = '1' AND approval2 = '1' AND approval3 = '0'";
                    break;
                case "Administrator" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text + "'";
                    break;
            }
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

                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }

        private void catchSection()
        {
            departmentLabel.Text = Global.GlobalVar[2];
            
            sectionBox.Enabled = true;
            
            switch (Global.GlobalVar[2])
            {
                case "Accounting":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("FINANCE");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "Engineering":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("PROCESS");
                    sectionBox.Items.Add("TEST AND CALIBRATION");
                    sectionBox.Items.Add("R & D");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "General Manager":
                    this.sectionBox.Items.Clear();
                    sectionBox.Text = "GENERAL";
                    break;

                case "HR & GA":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("TRAINING");
                    sectionBox.Items.Add("PAYROLL");
                    sectionBox.Items.Add("GENERAL AFFAIR");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "MIS":
                    this.sectionBox.Items.Clear();
                    sectionBox.Text = "IT";
                    sectionBox.Enabled = false;
                    break;

                case "Maintenance":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("PM & FACILITY");
                    sectionBox.Items.Add("PRUDUCTION SUPPORT (MOL X)");
                    sectionBox.Items.Add("TECHNICAL SUPPORT");
                    sectionBox.Items.Add("PM (MOL W)");
                    sectionBox.Items.Add("PM");
                    sectionBox.Items.Add("PRODUCTION SUPPORT (MOL S)");
                    sectionBox.Items.Add("PRODUCTION SUPPORT (EOL)");
                    sectionBox.Items.Add("PM (BOL NON WINDING)");
                    sectionBox.Items.Add("PM (EOL NON TESTING)");
                    sectionBox.Items.Add("PRODUCTION SUPPORT (BOL)");
                    sectionBox.Items.Add("PM (BOL WINDING)");
                    sectionBox.Items.Add("FACILITY");
                    sectionBox.Items.Add("PM (MOL S)");
                    sectionBox.Items.Add("PRODUCTION SUPPORT (MOL W)");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "PPCWL":
                    this.sectionBox.Items.Clear();                    
                    sectionBox.Items.Add("W & L");
                    sectionBox.Items.Add("PLANNING");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "Production":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("PRODUCTION CONTROLLER");
                    sectionBox.Items.Add("BOL LINE LEADER");
                    sectionBox.Items.Add("BOL NON WINDING");
                    sectionBox.Items.Add("BOL SECTION HEAD");
                    sectionBox.Items.Add("BOL WINDING");
                    sectionBox.Items.Add("EOL LINE LEADER");
                    sectionBox.Items.Add("EOL NON TESTING");
                    sectionBox.Items.Add("EOL SECTION HEAD");
                    sectionBox.Items.Add("EOL TESTING");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Items.Add("MOL S");
                    sectionBox.Items.Add("MOL S LINE LEADER");
                    sectionBox.Items.Add("MOL S SECTION HEAD");
                    sectionBox.Items.Add("MOL WOUND");
                    sectionBox.Items.Add("MOL WOUND LINE LEADER");
                    sectionBox.Items.Add("MOL WOUND SECTION HEAD");
                    sectionBox.Items.Add("PROD. IN PROCESS YIELD IMPROVE");
                    sectionBox.Items.Add("PROD. INNOVATION & DEVELOPMENT");
                    sectionBox.Items.Add("PRODUCTION ENGINEERING");
                    sectionBox.Items.Add("PRODUCTION SUPERVISORY");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;

                case "Quality":
                    this.sectionBox.Items.Clear();
                    sectionBox.Items.Add("DOCUMENT CONTROL CENTRE");
                    sectionBox.Items.Add("ENVIRONMENT HEALTH SAFETY");
                    sectionBox.Items.Add("FINAL INSPECTION");
                    sectionBox.Items.Add("GENERAL");
                    sectionBox.Items.Add("INCOMING");
                    sectionBox.Items.Add("IPQC");
                    sectionBox.Items.Add("LINE LEADER");
                    sectionBox.Items.Add("OUTGOING");
                    sectionBox.Items.Add("QUALITY MANAGEMENT SYSTEM");
                    sectionBox.Items.Add("SECTION HEAD");
                    sectionBox.Items.Add("SUPPORTING TEAM");
                    sectionBox.Items.Add("TRAINING");
                    sectionBox.Text = Global.GlobalVar[3];
                    break;
            }
        }
        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }
    }
}
