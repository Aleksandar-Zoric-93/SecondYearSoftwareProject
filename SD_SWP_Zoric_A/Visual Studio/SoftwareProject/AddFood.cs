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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }


        //Gets the next stock Number
        private void getNextStockNo()
        {
            try
            {
                String AlexDB = "Data Source=Oracle; User ID=t00166011; password=4yybapkv";
                OracleConnection conn = new OracleConnection(AlexDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(StockNo) FROM Stock", conn);
               
                conn.Open();
           

                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                   // stockNoTxt.Text = String.Format("1", "0000");
                    stockNoTxt.Text = String.Format("{0:0000}",1);
                }
                else
                {
                    stockNoTxt.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                    //stockNoTxt.Text = String.Format("{0:0000}", 1);
                }
             
                conn.Close();               
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }




        private void AddFood_Load(object sender, EventArgs e)
        {
            getNextStockNo();

            //Setting the maximun length for each textbox
            TitleIdBox2.MaxLength = 12;
            descBox.MaxLength = 25;
            IngriBox.MaxLength = 25;
            CategoryBox.MaxLength = 10;
            PriceBox.MaxLength = 4;
        }





        private void submitBtn_Click(object sender, EventArgs e)
        {
            //validate input
            if (TitleIdBox2.Text == "" || descBox.Text == "" || IngriBox.Text == "" || CategoryBox.Text == "" || PriceBox.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (TitleIdBox2.Text == "")
                {
                    TitleIdBox2.Focus();
                }

                    else if (descBox.Text == "")
                    {
                     descBox.Focus();
                    }

                        else if (IngriBox.Text == "")
                         {
                            IngriBox.Focus();
                         }

                             else if (CategoryBox.Text == "")
                               {
                                 CategoryBox.Focus();
                               }

                                 else if (PriceBox.Text == "")
                                   {
                                     PriceBox.Focus();
                                   }
                return;
            }
            try
            {
                String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(AlexDB);

                //Define SQL Query (UPDATE)
                String strSQL = "INSERT INTO Stock (StockNo,Title,Description,Ingridients,Category,Price) VALUES(" + stockNoTxt.Text + ",'" + TitleIdBox2.Text + "'," + "'" +
                descBox.Text + "','" + IngriBox.Text + "','" + CategoryBox.Text + "'," + PriceBox.Text + ")";


                conn.Open();

                //OracleCommand cmd = conn.CreateCommand();
                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //Execute SQL Query
                cmd.ExecuteNonQuery();

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Display confirmation message
            MessageBox.Show("Stock Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calling the method to clear the form
            clearForm();

            //reset the stockNo
            getNextStockNo();
        }


        //Method to clear the form
        private void clearForm()
        {
            TitleIdBox2.Text = String.Empty;
            descBox.Text = String.Empty;
            IngriBox.Text = String.Empty;
            CategoryBox.Text = String.Empty;
            PriceBox.Text = String.Empty; 
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


        private void allMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
