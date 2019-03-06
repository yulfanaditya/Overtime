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
    public partial class PrintItemsLists : Form
    {
        OTDB DB = new OTDB();
        public string[] data = { "", "", "", "" };

        public PrintItemsLists()
        {
            InitializeComponent();
        }
        public PrintItemsLists(string date1, string date2, string dept, string sect)
        {
            InitializeComponent();
            AppCodeLists();
            selected(date1,date2,dept,sect);
        }
        private void AppCodeLists()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Submitter", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Approver 1", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Approver 2", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Approver 3", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("date", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        public void selected(string date1, string date2, string dept, string sect)
        {
            int i = 0;
            DB.inializing();

            string query = "SELECT DISTINCT submitter, approvalName1, approvalName2, approvalName3, date from overtimerequest WHERE date BETWEEN '"+date1+"' AND '"+date2+"' AND approval1 = 1 ORDER BY approval1 DESC, date";
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
                listView1.Items.Add(lv);

            }
            resetCounter();
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string datalocals = listView1.SelectedItems[0].SubItems[1].Text;
            for (int i = 1; i <= 4; i++)
            {
                data[i-1] = listView1.SelectedItems[0].SubItems[i].Text;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
