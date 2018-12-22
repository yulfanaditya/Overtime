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

namespace OT_Management.All_List
{
    public partial class DepartmentList : Form
    {
        OTDB DB = new OTDB();
        public DepartmentList()
        {
            InitializeComponent();
                       
            deptLists();
            deptLists();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void deptLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Department Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);

            //DB.inializing();
            MySqlCommand cmd = new MySqlCommand("select * from department", DB.inializing());
            DataTable dt = new DataTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["departmentCode"].ToString());
                listitem.SubItems.Add(dr["departmentName"].ToString());
                listView1.Items.Add(listitem);
            } 
        }

            }
}
