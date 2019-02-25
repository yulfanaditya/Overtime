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
    public partial class ManageKaryawan : Form
    {
        public ManageKaryawan()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            switch (comboBox2.Text)
            {
                case "Accounting":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("FINANCE");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "Engineering":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PROCESS");
                    comboBox3.Items.Add("TEST AND CALIBRATION");
                    comboBox3.Items.Add("R & D");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "General Manager":
                    this.comboBox3.Items.Clear();
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Text = "GENERAL";
                    comboBox3.Enabled = false;
                    break;

                case "HR & GA":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("TRAINING");
                    comboBox3.Items.Add("PAYROLL");
                    comboBox3.Items.Add("GENERAL AFFAIR");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "MIS":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("IT");
                    comboBox3.Text = "IT";
                    comboBox3.Enabled = false;
                    break;

                case "Maintenance":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PM & FACILITY");
                    comboBox3.Items.Add("PRUDUCTION SUPPORT (MOL X)");
                    comboBox3.Items.Add("TECHNICAL SUPPORT");
                    comboBox3.Items.Add("PM (MOL W)");
                    comboBox3.Items.Add("PM");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (MOL S)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (EOL)");
                    comboBox3.Items.Add("PM (BOL NON WINDING)");
                    comboBox3.Items.Add("PM (EOL NON TESTING)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (BOL)");
                    comboBox3.Items.Add("PM (BOL WINDING)");
                    comboBox3.Items.Add("FACILITY");
                    comboBox3.Items.Add("PM (MOL S)");
                    comboBox3.Items.Add("PRODUCTION SUPPORT (MOL W)");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "PPCWL":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("W & L");
                    comboBox3.Items.Add("PLANNING");
                    comboBox3.Items.Add("GENERAL");
                    break;

                case "Production":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("PRODUCTION CONTROLLER");
                    comboBox3.Items.Add("BOL LINE LEADER");
                    comboBox3.Items.Add("BOL NON WINDING");
                    comboBox3.Items.Add("BOL SECTION HEAD");
                    comboBox3.Items.Add("BOL WINDING");
                    comboBox3.Items.Add("EOL LINE LEADER");
                    comboBox3.Items.Add("EOL NON TESTING");
                    comboBox3.Items.Add("EOL SECTION HEAD");
                    comboBox3.Items.Add("EOL TESTING");
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Items.Add("MOL S");
                    comboBox3.Items.Add("MOL S LINE LEADER");
                    comboBox3.Items.Add("MOL S SECTION HEAD");
                    comboBox3.Items.Add("MOL WOUND");
                    comboBox3.Items.Add("MOL WOUND LINE LEADER");
                    comboBox3.Items.Add("MOL WOUND SECTION HEAD");
                    comboBox3.Items.Add("PROD. IN PROCESS YIELD IMPROVE");
                    comboBox3.Items.Add("PROD. INNOVATION & DEVELOPMENT");
                    comboBox3.Items.Add("PRODUCTION ENGINEERING");
                    comboBox3.Items.Add("PRODUCTION SUPERVISORY");
                    break;

                case "Quality":
                    this.comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    comboBox3.Items.Add("DOCUMENT CONTROL CENTRE");
                    comboBox3.Items.Add("ENVIRONMENT HEALTH SAFETY");
                    comboBox3.Items.Add("FINAL INSPECTION");
                    comboBox3.Items.Add("GENERAL");
                    comboBox3.Items.Add("INCOMING");
                    comboBox3.Items.Add("IPQC");
                    comboBox3.Items.Add("LINE LEADER");
                    comboBox3.Items.Add("OUTGOING");
                    comboBox3.Items.Add("QUALITY MANAGEMENT SYSTEM");
                    comboBox3.Items.Add("SECTION HEAD");
                    comboBox3.Items.Add("SUPPORTING TEAM");
                    comboBox3.Items.Add("TRAINING");
                    break;
            }
        }
    }
}
