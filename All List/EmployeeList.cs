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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
            EmployeeLists();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void EmployeeLists()
        {
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Badge", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }
    }
}