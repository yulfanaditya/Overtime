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
            selected();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void selected()
        {
            DB.inializing();

            string query = "Select departmentName from department ORDER BY departmentCode ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }
        private void deptLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Department Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);
        }

            }
}
