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
        OTDB DB = new OTDB();
        public OvertimeCodeList()
        {
            InitializeComponent();
            OTCodeLists();
            selected();
        }

        private void OvertimeCodeList_Load(object sender, EventArgs e)
        {

        }
        public void selected()
        {
            DB.inializing();

            string query = "Select goalofOT from goal ORDER BY goalofOT ASC";
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

        private void OTCodeLists() 
        {
            listView1.Columns.Add("Overtime Activities", -2, HorizontalAlignment.Left);
            listView1.View = View.Details;
        }
        public void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            string datalocals = listView1.Items[listView1.SelectedIndices[0]].Text;
            OvertimeRequest f1 = (OvertimeRequest)Application.OpenForms["OvertimeRequest"];
            TextBox tb = (TextBox)f1.Controls["OABox"];
            tb.Text = datalocals;
            
            this.Close();
         }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
