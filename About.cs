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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hsBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yulfanaditya/Overtime");
        }

        private void ghBox_MouseEnter(object sender, EventArgs e)
        {
            ghBox.Cursor = Cursors.Hand;
        }

        private void ghBox_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
