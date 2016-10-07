using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace SoftwareProject
{
    public partial class RemoveFood : Form
    {
        public RemoveFood()
        {
            InitializeComponent();
        }

        private void amendFoodLbl_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void RemoveFood_Load(object sender, EventArgs e)
        {
            stockNumTxt.MaxLength = 4;
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStaff nf = new RegisterStaff();

            this.Close();
            nf.Show();
        }

        private void amendStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmendStaff nf = new AmendStaff();

            this.Close();
            nf.Show();
        }

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStaff nf = new ListStaff();

            this.Close();
            nf.Show();
        }

        private void cancelRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder nf = new CancelOrder();

            this.Close();
            nf.Show();
        }

        private void recordOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordOrder nf = new RecordOrder();

            this.Close();
            nf.Show();
        }

        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrder nf = new EditOrder();

            this.Close();
            nf.Show();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOrder nf = new ListOrder();

            this.Close();
            nf.Show();
        }

       

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordPayment nf = new RecordPayment();

            this.Close();
            nf.Show();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder nf = new CancelOrder();

            this.Close();
            nf.Show();
        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood nf = new AddFood();

            this.Close();
            nf.Show();
        }

        private void changeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFood nf = new ChangeFood();

            this.Close();
            nf.Show();
        }

        private void removeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFood nf = new RemoveFood();

            this.Close();
            nf.Show();
        }

        private void listFoodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFood1 nf = new ListFood1();

            this.Close();
            nf.Show();
        }

        private void viewSalesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSales nf = new ViewSales();

            this.Close();
            nf.Show();
        }

       

      

       

        private void removeFood()
        {
            try
            {
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(oradb);

                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                String remove = "UPDATE Stock SET Available = 'NO' WHERE StockNo = " + stockNumTxt.Text + "";

                cmd.CommandText = remove;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Food Item Removed");

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validate
            if (stockNumTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (stockNumTxt.Text == "")
                {
                    stockNumTxt.Focus();
                }
                return;
            }

            int outParse;

            if (!Int32.TryParse(stockNumTxt.Text, out outParse))
            {
                MessageBox.Show("This is a numeric only field");
                return;
            }

            removeFood();
        }

        private void getFood(int intStockNo)
        {
            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                grpAllFood.Visible = true;

                //define SQL query
                String strSQL = "SELECT * FROM Stock WHERE StockNo = " + stockNumTxt;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                //Close DB connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stockNumTxt_TextChanged(object sender, EventArgs e)
        {
            if (!stockNumTxt.Text.Equals(""))
                getFood(Convert.ToInt32(stockNumTxt.Text));
        }


    }
}
