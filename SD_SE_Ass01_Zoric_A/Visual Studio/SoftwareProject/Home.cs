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
            new RegisterStaff().Show();
            this.Hide();
        }

        private void amendStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AmendStaff().Show();
            this.Hide();
        }

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListStaff().Show();
            this.Hide();
        }

        private void cancelRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CancelRequest().Show();
            this.Hide();
        }

        private void recordOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RecordOrder().Show();
            this.Hide();
        }

        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditOrder().Show();
            this.Hide();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListOrder().Show();
            this.Hide();
        }

        private void dispatchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DispatchOrder().Show();
            this.Hide();
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RecordPayment().Show();
            this.Hide();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CancelOrder().Show();
            this.Hide();
        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddFood().Show();
            this.Hide();
        }

        private void changeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeFood().Show();
            this.Hide();
        }

        private void removeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveFood().Show();
            this.Hide();
        }

        private void listFoodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListFood1().Show();
            this.Hide();
        }

        private void viewSalesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewSales().Show();
            this.Hide();
        }

        private void viewCustomerAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewCustomer().Show();
            this.Hide();
        }

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageSales().Show();
            this.Hide();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageCustomers().Show();
            this.Hide();
        }
    }
}
