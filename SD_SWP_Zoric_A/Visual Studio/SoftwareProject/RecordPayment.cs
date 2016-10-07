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
using System.Data.Sql;

namespace SoftwareProject
{
    public partial class RecordPayment : Form
    {
        public RecordPayment()
        {
            InitializeComponent();
        }

        private void getNextPayNum()
        {
            try
            {
                String AlexDB = "Data Source=Oracle; User ID=t00166011; password=4yybapkv";
                OracleConnection conn = new OracleConnection(AlexDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(PaymentID) FROM Payments", conn);

                conn.Open();


                if (cmd.ExecuteScalar().ToString().Equals(""))
                {

                    payIDTxt.Text = String.Format("{0:0000}", 1);
                }
                else
                {
                    payIDTxt.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");

                }

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            new homePage().Show();
            this.Close();
        }

        private void RecordPayment_Load(object sender, EventArgs e)
        {
            payIDTxt.MaxLength = 4;
            OrderIDTxt.MaxLength = 4;
            dateTxt.MaxLength = 10;
            totalBox.MaxLength = 8;

            getNextPayNum();
            dateTxt.Text = String.Format("{0:dd-MMM-yy}", DateTime.Now);

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

        

       

        

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validate Input
            if (payIDTxt.Text == "" || OrderIDTxt.Text == "" || dateTxt.Text == "" || totalBox.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (payIDTxt.Text == "")
                {
                    payIDTxt.Focus();
                }

                else if (OrderIDTxt.Text == "")
                {
                    OrderIDTxt.Focus();
                }

                else if (dateTxt.Text == "")
                {
                    dateTxt.Focus();
                }

                else if (totalBox.Text == "")
                {
                    totalBox.Focus();
                }

                return;
            }
        
            
            try
            {
                String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(AlexDB);

                conn.Open();

                
                //Define SQL Query
                String strSQL = "INSERT INTO Payments VALUES(" + payIDTxt.Text + "," + OrderIDTxt.Text + "," +
                totalBox.Text + ",'" + dateTxt.Text + "'" + ")";

              
              

                //OracleCommand cmd = conn.CreateCommand();
                OracleCommand cmd = conn.CreateCommand();


                cmd.CommandText = strSQL;

                //Execute SQL Query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Made");

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            getNextPayNum();
        }

        private void OrderIDTxt_TextChanged(object sender, EventArgs e)
        {
            Boolean check = false;

            while (check == false)
            {
                if (!OrderIDTxt.Equals(""))
                {
                    String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                    //Connect to Database
                    OracleConnection conn = new OracleConnection(AlexDB);

                    conn.Open();

                    Object returnValue;

                    String strSQL1 = "SELECT OrderValue FROM Orders WHERE OrderID = " + OrderIDTxt.Text;
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = strSQL1;
                    //Execute SQL Query
                    returnValue = cmd.ExecuteScalar();

                    totalBox.Text = returnValue.ToString();
                    check = true;
                }
            }
        }

    }
}
