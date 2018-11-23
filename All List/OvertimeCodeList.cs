using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OT_Management
{
    public partial class OvertimeCodeList : Form
    {
        public OvertimeCodeList()
        {
            InitializeComponent();
            OTCodeLists();
        }

        private void OvertimeCodeList_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OTCodeLists() 
        {
            listView1.Columns.Add("Overtime Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Overtime Activities", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }
    }
}
