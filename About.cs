﻿using System;
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
    }
}
