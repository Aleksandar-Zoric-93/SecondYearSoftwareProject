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
    public partial class homePage : Form
    {
        public homePage Parent;
        public homePage()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegisterStaff rs = new RegisterStaff();
            this.Hide();
            rs.Show();
        }

        private void amendStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmendStaff rs = new AmendStaff();
            this.Hide();
            rs.Show();
        }

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStaff rs = new ListStaff();
            this.Hide();
            rs.Show();
        }

        private void cancelRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelRequest rs = new CancelRequest();
            this.Hide();
            rs.Show();
        }

        private void recordOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordOrder rs = new RecordOrder();
            this.Hide();
            rs.Show();
        }

        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrder rs = new EditOrder();
            this.Hide();
            rs.Show();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOrder rs = new ListOrder();
            this.Hide();
            rs.Show();
        }

       
        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordPayment rs = new RecordPayment();
            this.Hide();
            rs.Show();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder rs = new CancelOrder();
            this.Hide();
            rs.Show();
        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood rs = new AddFood();
            this.Hide();
            rs.Show();
        }

        private void changeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFood rs = new ChangeFood();
            this.Hide();
            rs.Show();
        }

        private void removeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFood rs = new RemoveFood();
            this.Hide();
            rs.Show();
        }

        private void listFoodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFood1 rs = new ListFood1();
            this.Hide();
            rs.Show();
        }

        private void viewSalesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSales rs = new ViewSales();
            this.Hide();
            rs.Show();
        }

       
      


        private void homePage_Load(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
