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
            
            DB.inializing();
           
            DeptLists();
            AddDeptLists();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddDeptLists() 
        {
            string sql = "SELECT departementCode,departementName FROM departement";
            MySqlCommand cmd = new MySqlCommand(sql,DB.inializing());
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();
            
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.inializing().Close();

        }
        private void DeptLists()
        {
            listView1.Columns.Add("Department Code", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }

            }
}
