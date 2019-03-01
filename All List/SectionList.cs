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

namespace OT_Management.All_List
{
    public partial class SectionList : Form
    {
        OTDB DB = new OTDB();
        public string sectionItems { get; set; }
        public SectionList()
        {
            InitializeComponent();
            sectLists();
        }
        public SectionList(string data)
        {
            InitializeComponent();
            sectLists();
            selected(data);
        }
        public void selected(string dept)
        {
            DB.inializing();
            int i = 0;

            string query = "Select sectionName, departmentName from section WHERE departmentName = '" + dept + "' ORDER BY sectionName ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                listView1.Items.Add(lv);

            }
            resetCounter();
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }
        private void sectLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Section Name", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Department Name", -2, HorizontalAlignment.Center);
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string datalocals = listView1.SelectedItems[0].SubItems[1].Text;
            sectionItems = datalocals;
            DialogResult = DialogResult.OK;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }
    }
}
