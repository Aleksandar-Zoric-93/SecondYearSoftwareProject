﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class AmendStaff : Form
    {
        public AmendStaff()
        {
            InitializeComponent();
        }

        private void amendBtn_Click(object sender, EventArgs e)
        {
            new RegisterStaff().Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Hide();
        }
    }
}