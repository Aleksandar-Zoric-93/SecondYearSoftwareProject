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
    public partial class ChangeFood : Form
    {
        public ChangeFood()
        {
            InitializeComponent();
        }

        private void TitleIdLbl3_Click(object sender, EventArgs e)
        {

        }

        
        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void amendBtn_Click(object sender, EventArgs e)
        {
            new AddFood().Show();
            this.Hide();
        }

        private void ChangeFood_Load(object sender, EventArgs e)
        {
            TitleIdBox3.MaxLength = 12;
            txtSearchStock.MaxLength = 4;
            titleTxt.MaxLength = 12;
            descTxt.MaxLength = 25;
            ingriTxt.MaxLength = 25;
            categoryTxt.MaxLength = 10;
            priceTxt.MaxLength = 4;
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
            CancelRequest nf = new CancelRequest();

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

        

       

       

        private void getMatchingFood(String strDesc)
        {
            //Define database connection string
            String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

            OracleConnection conn = new OracleConnection(oradb);

            //define SQL query
            String strSQL = "SELECT * FROM Stock WHERE title LIKE '" +
                TitleIdBox3.Text + "%' ORDER BY title";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            grdFood.DataSource = ds.Tables["ss"];
            grpAllFood.Visible = true;
        }

        private void updateFood()
        {
            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

                //Connect to Database
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //Define SQL Query (UPDATE)
                String strSQL = "UPDATE Stock SET Title = '" + titleTxt.Text +
                    "', Description = '" + descTxt.Text +
                    "', Ingridients = '" + ingriTxt.Text +
                    "', Category = '" + categoryTxt.Text + "', Price = '" + priceTxt.Text +
                    "' WHERE StockNo = " + stockNoTxt.Text;


                //Execute SQL Query


                //OracleCommand cmd = new OracleCommand(strSQL, conn); 
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                //define SQL query
                String strSQL = "SELECT * FROM Stock WHERE StockNo = " + intStockNo;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    stockNoTxt.Text = dr.GetValue(0).ToString();
                    titleTxt.Text = dr.GetValue(1).ToString();
                    descTxt.Text = dr.GetValue(2).ToString();
                    ingriTxt.Text = dr.GetValue(3).ToString();
                    categoryTxt.Text = dr.GetValue(4).ToString();
                    priceTxt.Text = dr.GetValue(5).ToString();

                    //display the details on the form
                    grpFood.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Details Found");
                    //txtSearchStock.Focus();
                    return;
                }

                //Close DB connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void amendButton_Click(object sender, EventArgs e)
        {
            //validate input
            if (stockNoTxt.Text == "" || titleTxt.Text == "" || descTxt.Text == "" || ingriTxt.Text == "" || categoryTxt.Text == "" || priceTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (stockNoTxt.Text == "")
                {
                    stockNoTxt.Focus();
                }

                else if (titleTxt.Text == "")
                {
                    titleTxt.Focus();
                }

                else if (descTxt.Text == "")
                {
                    descTxt.Focus();
                }

                else if (ingriTxt.Text == "")
                {
                    ingriTxt.Focus();
                }

                else if (categoryTxt.Text == "")
                {
                    categoryTxt.Focus();
                }

                else if (priceTxt.Text == "")
                {
                    priceTxt.Focus();
                }

                return;
            }


            //update customer file
            updateFood();

            //display confirmation message
            MessageBox.Show("Food Updated");
        }


        private void TitleIdBox3_TextChanged(object sender, EventArgs e)
        {
            if (!TitleIdBox3.Text.Equals(""))
                getMatchingFood(TitleIdBox3.Text);
            else
                grpAllFood.Hide(); 
        }

        private void txtSearchStock_TextChanged_1(object sender, EventArgs e)
        {
            if (!txtSearchStock.Text.Equals(""))
                getFood(Convert.ToInt32(txtSearchStock.Text));
            else
                grpFood.Hide();
        }
         
         
    }
}
