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
    public partial class Approval : Form
    {
        OTDB DB = new OTDB();
        public Approval()
        {
            InitializeComponent();
            catchSection();
            viewList();
            if (listView1.Items.Count > 0)
            {
                approveAllButton.Enabled = true;
            }
            else 
            {
                approveAllButton.Enabled = false;
            }

            if (Global.GlobalVar[1] == "Approver 3")
            {
                departmentLabel.Visible = false;
                searchDept.Enabled = true;
                departmentBox.Text = Global.GlobalVar[2];
            }
            else 
            {
                departmentBox.Visible = false;
                searchDept.Visible = false;
                searchDept.Enabled = false;
            }
        }
        private void viewData() {
                                    
           
        }
        private void viewList()
        {
            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Employee Name", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("Activity", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Start Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Finish Time", 75, HorizontalAlignment.Center);
            listView1.Columns.Add("Hours", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("RequestCode", -2, HorizontalAlignment.Center);
            listView1.View = View.Details;

            catchAcess();
        }


        private void sectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            catchAcess();
        }

        private void catchAcess()
        {
            string query = "";
            int i = 0;

            switch (Global.GlobalVar[1])
            {
                case "Approver 1" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text +"' AND approval1 = 0";
                    break;
                case "Approver 2" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text + "' AND approval1 = '1' AND approval2 = '0'";
                    break;
                case "Approver 3" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + departmentBox.Text + "' AND sectionName = '" + sectionBox.Text + "' AND approval1 = '1' AND approval2 = '1' AND approval3 = '0'";
                    break;
                /*case "Administrator" :
                    query = "Select name, activity, date, finish, start, sumTime, code FROM overtimerequest WHERE departmentName = '" + Global.GlobalVar[2] + "' AND sectionName = '" + sectionBox.Text + "'";
                    break;*/
            }
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
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));

                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }

        private void catchSection()
        {
            departmentLabel.Text = Global.GlobalVar[2];
            sectionBox.Text = Global.GlobalVar[3];
            sectionBox.Enabled = false;
            sectionButton.Enabled = true;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar[1] == "Approver 3")
            {
                var ASL = new All_List.SectionList(departmentBox.Text);
                if (ASL.ShowDialog() == DialogResult.OK)
                {
                    sectionBox.Text = ASL.sectionItems;
                    catchAcess();
                }
            }
            else 
            {
                var ASL = new All_List.SectionList(departmentLabel.Text);
                if (ASL.ShowDialog() == DialogResult.OK)
                {
                    sectionBox.Text = ASL.sectionItems;
                    catchAcess();
                }
            }
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
                catchAcess();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                declineButton.Enabled = true;
                approveButton.Enabled = true;
                approveAllButton.Enabled = true;
            }
            else if (listView1.SelectedIndices.Count <= 0)
            {
                declineButton.Enabled = false;
                approveButton.Enabled = false;
                approveAllButton.Enabled = false;
            }

            if (listView1.Items.Count > 0) 
            {
                approveAllButton.Enabled = true;
            }
            else if (listView1.Items.Count <= 0) 
            {
                approveAllButton.Enabled = false;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                declineButton.Enabled = true;
                approveButton.Enabled = true;
                approveAllButton.Enabled = true;
            }
            else if (listView1.SelectedIndices.Count <= 0)
            {
                declineButton.Enabled = false;
                approveButton.Enabled = false;
                approveAllButton.Enabled = false;
            }

            if (listView1.Items.Count > 0)
            {
                approveAllButton.Enabled = true;
            }
            else if (listView1.Items.Count <= 0)
            {
                approveAllButton.Enabled = false;
            }
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Approve Button
        private void approveButton_Click(object sender, EventArgs e)
        {
            selectedItemsapprove(false);
            catchAcess();
            resetCounter();
        }
        private void selectedItemsapprove(bool All) 
        {
            string query = "";
            
            if (All == false)
            {
                for (int i = 0; listView1.SelectedItems.Count > i; i++)
                {
                    DB.inializing();

                    switch (Global.GlobalVar[1])
                    {
                        case "Approver 1":
                            query = "UPDATE overtimerequest SET approval1 = 1, approvalName1 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.SelectedItems[i].SubItems[7].Text + "'";
                            break;
                        case "Approver 2":
                            query = "UPDATE overtimerequest SET approval2 = 1, approvalName2 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.SelectedItems[i].SubItems[7].Text + "'";
                            break;
                        case "Approver 3":
                            query = "UPDATE overtimerequest SET approval3 = 1, approvalName3 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.SelectedItems[i].SubItems[7].Text + "'";
                            break;
                    }

                    MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                    DB.OpenConnection();
                    cmd.ExecuteNonQuery();
                }
                DB.CloseConnection();
                approveButton.Enabled = false;
                declineButton.Enabled = false;
            }
            else 
            {
                for (int i = 0; listView1.Items.Count > i; i++)
                {
                    DB.inializing();

                    switch (Global.GlobalVar[1])
                    {
                        case "Approver 1":
                            query = "UPDATE overtimerequest SET approval1 = 1, approvalName1 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.Items[i].SubItems[7].Text + "'";
                            break;
                        case "Approver 2":
                            query = "UPDATE overtimerequest SET approval2 = 1, approvalName2 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.Items[i].SubItems[7].Text + "'";
                            break;
                        case "Approver 3":
                            query = "UPDATE overtimerequest SET approval3 = 1, approvalName3 = '" + Global.GlobalVar[0] + "' WHERE code = '" + listView1.Items[i].SubItems[7].Text + "'";
                            break;
                    }
                    MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                    DB.OpenConnection();
                    cmd.ExecuteNonQuery();
                }
                DB.CloseConnection();
                approveButton.Enabled = false;
                declineButton.Enabled = false;
                approveAllButton.Enabled = false;
            }
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Approve All Button
        private void approveAllButton_Click(object sender, EventArgs e)
        {
            selectedItemsapprove(true);
            catchAcess();
            resetCounter();
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Decline Button

        private void declineButton_Click(object sender, EventArgs e)
        {
           declineovertime();
           catchAcess();
        }

        private void declineovertime()
        {
            string query = "";
            
            for (int i = 0; listView1.SelectedItems.Count > i; i++)
            {
                DB.inializing();

                query = "DELETE FROM overtimerequest WHERE code = '" + listView1.SelectedItems[i].SubItems[7].Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
                DB.OpenConnection();
                cmd.ExecuteNonQuery();
                DB.CloseConnection();

                approveButton.Enabled = false;
                declineButton.Enabled = false;
            }
            
        }

        private void refreshBox_Click(object sender, EventArgs e)
        {
            catchAcess();
        }
    }
}
