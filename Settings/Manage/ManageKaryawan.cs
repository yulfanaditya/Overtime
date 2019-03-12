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
    public partial class ManageKaryawan : Form
    {
        OTDB DB = new OTDB();
        public int i = 0;
        public ManageKaryawan()
        {
            InitializeComponent();
            employeeLists();
            selected();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseSettings ds = new DatabaseSettings();
            ds.Closed += (s, args) => this.Close();
            ds.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string query = "";
            string messaging = "";
            if(string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Name Can't be empty","Denied!");
            }
            else if (string.IsNullOrEmpty(genderBox.Text))
            {
                MessageBox.Show("Gender Can't be empty", "Denied!");
            }
            else if (string.IsNullOrEmpty(departmentBox.Text))
            {
                MessageBox.Show("Department Can't be empty", "Denied!");
            }
            else if (string.IsNullOrEmpty(sectionBox.Text))
            {
                MessageBox.Show("Section Can't be empty", "Denied!");
            }
            else if (string.IsNullOrEmpty(timeBox.Text))
            {
                MessageBox.Show("Time Can't be empty", "Denied!");
            }
            if (countDatabase() >= 1)
            {
                query = "UPDATE karyawan SET name='" + nameBox.Text + "', DOJ='" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', Gender='" + genderBox.Text + "', departmentName='" + departmentBox.Text + "', sectionName='" + sectionBox.Text + "', timeRemain='" + timeBox.Text + "' WHERE Badge='" + badgeBox.Text + "'";
                messaging = "Data Just Updated!";
            }
            else
            {
                query = "INSERT INTO karyawan (Badge,Name,DOJ,Gender,departmentName,sectionName,timeRemain) VALUES('" + badgeBox.Text + "','" + nameBox.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + genderBox.Text + "','" + departmentBox.Text + "','" + sectionBox.Text + "','" + timeBox.Text + "')";
                messaging = "Data Just Saved!";
            }
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            cmd.ExecuteNonQuery();
            DB.CloseConnection();

            MessageBox.Show(messaging,"Success!");
            refresh();
            selected();
            badgeBox.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM karyawan WHERE Username='" + badgeBox.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            cmd.ExecuteNonQuery();
            DB.CloseConnection();

            refresh();
            selected();
            badgeBox.Focus();
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Event
        private void badgeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(badgeBox.Text)) 
                {
                    MessageBox.Show("Badge Can't Be Empty","Denied!");
                }
                else if (badgeBox.Text.Length < 4)
                {
                    MessageBox.Show("Badge atleast 4 Character", "Denied!");
                }
                else
                {

                    if (countDatabase() == 0)
                    {
                        badgeBox.Enabled = false;
                        updateButton.Text = "Save";
                        deleteButton.Enabled = false;
                        timeBox.Enabled = false;
                        timeBox.Text = "56";
                        searchSect.Enabled = false;
                    }
                    else
                    {
                        badgeBox.Enabled = false;
                        updateButton.Text = "Update";
                        deleteButton.Enabled = true;
                        timeBox.Enabled = true;
                        searchSect.Enabled = true;
                    }
                    badgeBox.Enabled = false;
                    enable();
                    nameBox.Focus();
                }
            }
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Support

        private int countDatabase()
        {
            string query = "SELECT COUNT(Badge) FROM karyawan WHERE Badge = '" + badgeBox.Text + "'";
            int i = 0;
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                i = int.Parse(Reader.GetString(0));

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            return i;
        }

        public void selected()
        {
            DB.inializing();

            string query = "Select Badge, Name, DOJ, Gender, departmentName, sectionName from karyawan ORDER BY Badge ASC";
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
                listView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
            resetCounter();
        }

        private void resetCounter()
        {
            for (int i = 1; listView1.Items.Count >= i; i++)
            {
                listView1.Items[i - 1].SubItems[0].Text = i.ToString();
            }

        }

        private void employeeLists()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("No", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Badge", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Sex", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Section", 200, HorizontalAlignment.Left);
        }

        private void enable()
        {
            nameBox.Enabled = true;
            dateTimePicker1.Enabled = true;
            genderBox.Enabled = true;
            departmentBox.Enabled = true;
            sectionBox.Enabled = true;

            updateButton.Enabled = true;
            cancelButton.Enabled = true;

            if (countDatabase() >= 1)
            {
                selectDatabase();
            }
            else if (countDatabase() == 0)
            {
                clear();
            }
        }

        private void selectDatabase()
        {
            string query = "SELECT name, DOJ, Gender, departmentName, sectionName, timeRemain FROM karyawan WHERE Badge = '" + badgeBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, DB.inializing());
            DB.OpenConnection();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                nameBox.Text = Reader.GetString(0);
                dateTimePicker1.Text = Reader.GetString(1);
                genderBox.Text = Reader.GetString(2);
                departmentBox.Text = Reader.GetString(3);
                sectionBox.Text = Reader.GetString(4);
                timeBox.Text = Reader.GetInt32(5).ToString();
            }
            Reader.Close();
            cmd.Dispose();
            DB.CloseConnection();
        }

        private void clear() 
        {
            nameBox.Text = "";
            dateTimePicker1.Text = "";
            timeBox.Text = "";
            departmentBox.Text = "";
            sectionBox.Text = "";

            genderBox.Items.Clear();
            genderBox.Items.Add("M");
            genderBox.Items.Add("F");
        }
        private void refresh()
        {
            badgeBox.Enabled = true;
            badgeBox.Text = "";
            nameBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            clear();

            nameBox.Enabled = false;
            dateTimePicker1.Enabled = false;
            genderBox.Enabled = false;
            departmentBox.Enabled = false;
            sectionBox.Enabled = false;
            timeBox.Enabled = false;

            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            refresh();
            badgeBox.Focus();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
                searchSect.Enabled = true;
            }
        }

        private void searchSect_Click(object sender, EventArgs e)
        {
            var ASL = new All_List.SectionList(departmentBox.Text);

            if (ASL.ShowDialog() == DialogResult.OK)
            {
                sectionBox.Text = ASL.sectionItems;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            badgeBox.Enabled = false;
            updateButton.Text = "Update";
            deleteButton.Enabled = true;
            timeBox.Enabled = true;
            searchSect.Enabled = true;
     
            badgeBox.Enabled = false;
            enable();
            nameBox.Focus();
        }

        
    }
}
