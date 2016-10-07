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
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void EditOrderBtn_Click(object sender, EventArgs e)
        {
            EditOrder nf = new EditOrder();

            this.Close();
            nf.Show();
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

       

       

       

        private void EditOrder_Load(object sender, EventArgs e)
        {
            orderIdBox.MaxLength = 4;
            orderValTxt.MaxLength = 8;
            qtyTxt.MaxLength = 2;
            priceTxt.MaxLength = 4;
            dspTxt.MaxLength = 4;
        }

        private void orderIdBox_TextChanged(object sender, EventArgs e)
        {

            if (!orderIdBox.Text.Equals(""))
                getOrders(Convert.ToInt32(orderIdBox.Text));
            else
                grpOrder.Hide();
        }

      

        private void getOrders(int intOrderNo)
        {
            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //define SQL query
                String strSQL = "SELECT Orders.OrderID,Orders.OrderValue,Order_Items.Quantity,Order_Items.Price,Orders.Dispatched From Orders INNER JOIN Order_Items ON Orders.OrderID = Order_Items.OrderID WHERE Orders.OrderID = " + orderIdBox.Text;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    orderValTxt.Text = dr.GetValue(1).ToString();
                    qtyTxt.Text = dr.GetValue(2).ToString();
                    priceTxt.Text = dr.GetValue(3).ToString();
                    dspTxt.Text = dr.GetValue(4).ToString();
                   
                    //display the details on the form
                    grpOrder.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Orders Found");
                    orderIdBox.Focus();
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


        private void UpdateOrders()
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
                String strSQL = "UPDATE Orders SET OrderValue = '" + orderValTxt.Text +
                    "', Orders.Dispatched = '" + dspTxt.Text +
                    "' WHERE OrderID = " + orderIdBox.Text;

                String strSQL1 = "UPDATE Order_Items SET Quantity = '" + qtyTxt.Text +
                    "', Price = '" + priceTxt.Text +
                    "' WHERE OrderID = " + orderIdBox.Text;


                //Execute SQL Query


                //OracleCommand cmd = new OracleCommand(strSQL, conn); 
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.CommandText = strSQL1;
                cmd.ExecuteNonQuery();

                //Close Database
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
            if (orderValTxt.Text == "" || qtyTxt.Text == "" || priceTxt.Text == "" || dspTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (orderValTxt.Text == "")
                {
                    orderValTxt.Focus();
                }

                else if (qtyTxt.Text == "")
                {
                    qtyTxt.Focus();
                }

                else if (priceTxt.Text == "")
                {
                    priceTxt.Focus();
                }

                else if (dspTxt.Text == "")
                {
                    dspTxt.Focus();
                }

                return;
            }

            //update orders file
            UpdateOrders();

            //display confirmation message
            MessageBox.Show("Order Updated");
        }

        private void dispatch()
        {
            try
            {
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(oradb);

                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                String check = "UPDATE Orders SET Dispatched = 'YES' WHERE OrderID = " + orderIdBox.Text + "";

                cmd.CommandText = check;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Dispatched");

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DispatchBtn_Click(object sender, EventArgs e)
        {
            dispatch();
        }





        private void getNewTotal()
        {
            Boolean check = false;

            while (check == false)
            {
                Int32 qty = Convert.ToInt32(qtyTxt.Text);

                if (qty >= 1)
                {
                    String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                    //Connect to Database
                    OracleConnection conn = new OracleConnection(oradb);

                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();

                    Int32 intPrice = Convert.ToInt32(priceTxt.Text);

                    Int32 total = intPrice * qty;
                    orderValTxt.Text = total.ToString();
                    String strSql = "UPDATE Order_Items SET Quantity = '" + qtyTxt.Text + "'" + "WHERE OrderID = " + orderIdBox.Text;
                    String strSql1 = "UPDATE Orders SET OrderValue = '" + orderValTxt.Text + "'" + "WHERE OrderID = " + orderIdBox.Text;
                    cmd.CommandText = strSql;
                    cmd.CommandText = strSql1;
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    check = true;
                }
            }
        }

        private void getTotalBtn_Click(object sender, EventArgs e)
        {
            getNewTotal();
        }

        


    }
}
