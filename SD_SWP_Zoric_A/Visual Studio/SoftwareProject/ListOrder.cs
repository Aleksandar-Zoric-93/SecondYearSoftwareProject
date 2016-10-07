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
    public partial class ListOrder : Form
    {
        public ListOrder()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOrder nf = new ListOrder();

            this.Close();
            nf.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStaff nf = new RegisterStaff();

            this.Close();
            nf.Show();
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            //Define the connection string(hostname,userID,password
            string AlexDB = "Data Source=Oracle;User Id=t00166011;Password=4yybapkv;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(AlexDB);

                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT Orders.OrderID,Orders.OrderValue,Order_Items.Quantity,Order_Items.Price,Orders.Dispatched From Orders INNER JOIN Order_Items ON Orders.OrderID = Order_Items.OrderID",conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdOrders.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Orders Found");
                MessageBox.Show(ex.Message);
            }
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

       

       

      

        private void sortOrderBtn_Click(object sender, EventArgs e)
        {
            //Define the connection string(hostname,userID,password
            string AlexDB = "Data Source=Oracle;User Id=t00166011;Password=4yybapkv;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(AlexDB);

                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT Orders.OrderID,Orders.OrderValue,Order_Items.Quantity,Order_Items.Price,Orders.Dispatched From Orders INNER JOIN Order_Items ON Orders.OrderID = Order_Items.OrderID ORDER BY Orders.OrderID", conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdOrders.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot order the list.");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
