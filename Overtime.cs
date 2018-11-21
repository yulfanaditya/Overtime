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
    public partial class Overtime : Form
    {
        public Overtime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OvertimeRequest otr = new OvertimeRequest();
            otr.Closed += (s, args) => this.Close();
            otr.Show();
        }
    }
}
