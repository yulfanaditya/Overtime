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
        public string departmentItems { get; set; }
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
            int i = 0;
            DB.inializing();

            string query = "Select departmentName from department ORDER BY departmentName ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(Reader.GetString(0));
                listView1.Items.Add(lv);

            }
            resetCounter();
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }
        private void deptLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string datalocals = listView1.SelectedItems[0].SubItems[1].Text;
            departmentItems = datalocals;
            DialogResult = DialogResult.OK;
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }
    }
}
