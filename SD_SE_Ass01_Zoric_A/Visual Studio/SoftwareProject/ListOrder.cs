using System;
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
    public partial class ListOrder : Form
    {
        public ListOrder()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Hide();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
