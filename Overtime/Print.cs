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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
            departmentBox.Text = Global.GlobalVar[2];
            sectionBox.Text = Global.GlobalVar[3];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            if (diff.Days < 0)
            {
                MessageBox.Show("You can't pick Date range with this kinda Date", "Denied!");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            if (diff.Days < 0)
            {
                MessageBox.Show("You can't pick Date range with this kinda Date", "Denied!");
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void searchDept_Click(object sender, EventArgs e)
        {
            var ADL = new All_List.DepartmentList();

            if (ADL.ShowDialog() == DialogResult.OK)
            {
                departmentBox.Text = ADL.departmentItems;
                sectionBox.Text = "";
            }

        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            var ASL = new All_List.SectionList(departmentBox.Text);

            if (ASL.ShowDialog() == DialogResult.OK)
            {
                sectionBox.Text = ASL.sectionItems;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sectionBox.Text))
            {
                MessageBox.Show("Section Can't be Empty!", "Empty Section");
            }
            else
            {
                var PIL = new PrintItemsLists(dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), departmentBox.Text, sectionBox.Text);
                if (PIL.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        MessageBox.Show(PIL.data[i]);
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overtime ot = new Overtime();
            ot.Closed += (s, args) => this.Close();
            ot.Show();
        }
    }
}
