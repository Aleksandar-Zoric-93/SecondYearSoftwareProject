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
    public partial class RecordOrder : Form
    {
        public RecordOrder()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStaff nf = new RegisterStaff();

            this.Close();
            nf.Show();
        }

        private void amendStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmendStaff rs = new AmendStaff();
            this.Close();
            rs.Show();
        }

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStaff rs = new ListStaff();
            this.Close();
            rs.Show();
        }

        private void cancelRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelRequest rs = new CancelRequest();
            this.Close();
            rs.Show();
        }

        private void recordOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordOrder rs = new RecordOrder();
            this.Close();
            rs.Show();
        }

        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrder rs = new EditOrder();
            this.Close();
            rs.Show();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOrder rs = new ListOrder();
            this.Close();
            rs.Show();
        }


        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordPayment rs = new RecordPayment();
            this.Close();
            rs.Show();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder rs = new CancelOrder();
            this.Close();
            rs.Show();
        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood rs = new AddFood();
            this.Close();
            rs.Show();
        }

        private void changeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFood rs = new ChangeFood();
            this.Close();
            rs.Show();
        }

        private void removeFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFood rs = new RemoveFood();
            this.Close();
            rs.Show();
        }

        private void listFoodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFood1 rs = new ListFood1();
            this.Close();
            rs.Show();
        }

        private void viewSalesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSales rs = new ViewSales();
            this.Close();
            rs.Show();
        }

       

       







        //Display the current cost of each item ordered
        private void displayCost()
        {
            if (stockNoTxt.Text.Equals(" "))
            {
                stockNoTxt.Focus();
            }

            else
            {

                //Define the connection string(hostname,userID,password
                string AlexDB = "Data Source=Oracle;User Id=t00166011;Password=4yybapkv;";
                try
                {
                    //Creating an instance of an oracle Connection
                    OracleConnection conn = new OracleConnection(AlexDB);

                    //Creating an instance of an Oracle Command to be executed on the connection
                    OracleCommand cmd = new OracleCommand("SELECT StockNo,Title,Price FROM Stock WHERE StockNo = " + stockNoTxt.Text, conn);


                    //Specifing the command type here as a String
                    cmd.CommandType = CommandType.Text;


                    //put query result into data reader
                    OracleDataReader dr = cmd.ExecuteReader();

                    //read the record returned
                    dr.Read();

                    //move data from the data reader to the grid grdCost
                    grdCost.Rows.Add();


                    //Creating a data adapter to contain the results
                    OracleDataAdapter da = new OracleDataAdapter(cmd);

                    //Creating a dataset to hold the records returned by the query
                    DataSet ds = new DataSet();

                    //Fill the dataset with the contents of the data adapter
                    da.Fill(ds, "ss");

                    //Binding the dataDridView to the results
                    grdCost.DataSource = ds.Tables["ss"];



                    conn.Close();
                }
                catch (Exception ex)
                {
                    stockNoTxt.Focus();   
                }
            }
        }

        private void setGridCost()
        {
            

            //int index = grdCost.Rows.Add();
        }
      







        private void RecordOrder_Load(object sender, EventArgs e)
        {
            getNextOrderNoOrder();
            dateTxt.Text = String.Format("{0:dd-MMM-yy}", DateTime.Now);

            grdCost.Columns.Add("Col1", "StockNo");
            grdCost.Columns.Add("Col2", "Title");
            grdCost.Columns.Add("Col3", "Price");

            //Define the connection string(hostname,userID,password
            string AlexDB = "Data Source=Oracle;User Id=t00166011;Password=4yybapkv;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(AlexDB);

                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT * FROM Stock WHERE Available = 'YES'", conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdFood.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Food Items Found");
                MessageBox.Show(ex.Message);
            }

           
        }







        //Get Next Order Number
        private void getNextOrderNoOrder()
        {
            try
            {
                String AlexDB = "Data Source=Oracle; User ID=t00166011; password=4yybapkv";
                OracleConnection conn = new OracleConnection(AlexDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(OrderID) FROM Orders", conn);

                conn.Open();


                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                   
                    OrderIDBox.Text = String.Format("{0:0000}", 1);
                }
                else
                {
                    OrderIDBox.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                }

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        




        private void submitBtn_Click(object sender, EventArgs e)
        {
            //validate input
            if (stockNoTxt.Text == "" || qtyTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (stockNoTxt.Text == "")
                {
                    stockNoTxt.Focus();
                }

                else if (qtyTxt.Text == "")
                {
                    qtyTxt.Focus();
                }
                return;

            }
            try
            {
                String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(AlexDB);


                //Define SQL Query (UPDATE)
                String strSQL = "INSERT INTO Orders (OrderID,OrderDate,OrderValue) VALUES(" + OrderIDBox.Text + ",'" + dateTxt.Text + "'," + totalTxt.Text + ")";

                conn.Open(); 
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;

                cmd.ExecuteNonQuery();

                //for each item ordered
  
                for (int i = 0; i < grdCost.Rows.Count; i++ )
                {
                    strSQL = "INSERT INTO Order_Items VALUES(" + OrderIDBox.Text + "," + grdCost.Rows[i].Cells[0].Value + "," + qtyTxt.Text + "," + grdCost.Rows[i].Cells[2].Value + ")";

                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();

                    i++;
                }

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

            //Display confirmation message
            MessageBox.Show("Order Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calling the method to clear the form
            clearForm();

            //reset the ID number
            getNextOrderNoOrder();
        }






        //Calculate the running total
        private void calculateTotal()
        {

            /*
            int totalCost = 0;

            totalCost = Convert.ToInt32(grdCost.Rows[index].Cells[2].Value);

            Int32 stockSelected = Convert.ToInt32(qwe);

            grdCost.Rows[index].Cells[0].Value = stockNoTxt.Text;
            grdCost.Rows[index].Cells[1].Value = grdFood.Rows[stockSelected - 1].Cells[1].Value;
            grdCost.Rows[index].Cells[2].Value = grdFood.Rows[stockSelected - 1].Cells[5].Value;
            grdCost.Rows[index].Cells[3].Value = totalCost;

            */



            decimal total = 0;
            Int32 qty = 0;


            if (qtyTxt.Text.Equals(""))
            {
                totalTxt.Text = String.Empty;
            }

            else
            {
                qty = Convert.ToInt32(qtyTxt.Text);

                for (int i = 0; i < grdCost.Rows.Count; i++)
                {

                    total += Convert.ToDecimal(grdCost.Rows[i].Cells[2].Value);

                    if (qty == 1)
                    {
                        total= Convert.ToInt32(grdCost.Rows[i].Cells[2].Value);
                    }

                    else if (qty > 1)
                    {
                        total = Convert.ToInt32(grdFood.Rows[i].Cells[2].Value);
                    }
                }
            }

            totalTxt.Text = total.ToString();

        }
         




        //Method to clear the form
        private void clearForm()
        {
            stockNoTxt.Text = String.Empty;
            qtyTxt.Text = String.Empty;
            totalTxt.Text = String.Empty;
        }







        //When next is clicked
        private void nextBtn_Click(object sender, EventArgs e)
        {
                //stockNoTxt.Text = String.Empty;
                qtyTxt.Text = String.Empty;
                setGridCost();

                int index = grdCost.Rows.Add();
                String StockSelectedString = stockNoTxt.Text;



                if (!String.IsNullOrEmpty(StockSelectedString))
                {
                    
                        Int32 qty = 0;
                        
                        

                        if (String.IsNullOrEmpty(StockSelectedString) || stockNoTxt.Equals(" "))
                        {
                            stockNoTxt.Focus();
                        }





                        
                                Int32 stockSelected = Convert.ToInt32(StockSelectedString);

                                Int32 qtyValue = Convert.ToInt32(qtyTxt.Text);
                                Int32 priceValue = Convert.ToInt32(grdFood.Rows[stockSelected - 1].Cells[5].Value);

                                qty = priceValue * qtyValue;
                                qtyValue.ToString();

                                grdCost.Rows[index].Cells[0].Value = stockNoTxt.Text;
                                grdCost.Rows[index].Cells[1].Value = grdFood.Rows[stockSelected - 1].Cells[1].Value;
                                grdCost.Rows[index].Cells[2].Value = grdFood.Rows[stockSelected - 1].Cells[5].Value = qty.ToString();

                }
                //for (int y = 0; y <= grdCost.Rows.Count - 1; y++ )
                //{



           

                    /*
                    try
                    {
                        String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                        //Connect to Database
                        OracleConnection conn = new OracleConnection(AlexDB);


                        conn.Open();
                        OracleCommand cmd = conn.CreateCommand();

                        //for each item ordered

                        for (int i = 0; i < grdCost.Rows.Count; i++)
                        {
                            String strSQL = "INSERT INTO Order_Items VALUES(" + OrderIDBox.Text + "," + grdCost.Rows[i].Cells[0].Value + "," + qtyTxt.Text + "," + grdCost.Rows[i].Cells[2].Value + ")";

                            cmd.CommandText = strSQL;
                            cmd.ExecuteNonQuery();

                            i++;
                        }

                        //Close Database
                        conn.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.StackTrace);
                    }

                    //Display confirmation message
                    MessageBox.Show("Order Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     * */
                //}
                calculateTotal();
         
        }

        private void stockNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (stockNoTxt.Text.Equals(" "))
            {
                stockNoTxt.Focus();
            }


            displayCost();
            //setGridCost();
/*
            int index = grdCost.Rows.Add();
            String qwe = stockNoTxt.Text;

            if (!String.IsNullOrEmpty(qwe))
            {
                Int32 stockSelected = Convert.ToInt32(qwe);

                grdCost.Rows[index].Cells[0].Value = stockNoTxt.Text;
                grdCost.Rows[index].Cells[1].Value = grdFood.Rows[stockSelected - 1].Cells[1].Value;
                grdCost.Rows[index].Cells[2].Value = grdFood.Rows[stockSelected - 1].Cells[5].Value;
                displayCost();
            }

            if (String.IsNullOrEmpty(qwe) || stockNoTxt.Equals(" "))
            {
                stockNoTxt.Focus();
            }
 * */
        }

        private void qtyTxt_TextChanged(object sender, EventArgs e)
        {
            //calculateTotal();
        }
    }
}
