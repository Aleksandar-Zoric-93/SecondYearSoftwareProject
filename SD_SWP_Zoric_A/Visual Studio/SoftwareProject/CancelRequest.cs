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
    public partial class CancelRequest : Form
    {
        public CancelRequest()
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



        private void CancelRequest_Load(object sender, EventArgs e)
        {
            staffIdBox2.MaxLength = 4;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validate
            if (staffIdBox2.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (staffIdBox2.Text == "")
                {
                    staffIdBox2.Focus();
                }
                return;
            }

            int outParse;

            if (!Int32.TryParse(staffIdBox2.Text, out outParse))
            {
                MessageBox.Show("This is a numeric only field");
                return;
            }

            cancelRequest();                   
        }

        private void cancelRequest()
        {
            try {
            String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
            //Connect to Database
            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String cancel = "UPDATE Staff SET Status = 'U' WHERE StaffId = " + staffIdBox2.Text + "";

            cmd.CommandText = cancel;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Request Cancelled");

            //Close Database
            conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showStaffMember()
        {
            if(!staffIdBox2.Equals(""))
            {
                listGroupBox.Visible = true;
                grdStaff.Visible = true;
            }

            //Define the connection string(hostname,userID,password
            string AlexDB = "Data Source=Oracle;User Id=t00166011;Password=4yybapkv;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(AlexDB);


                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT * FROM Staff WHERE StaffID = " + staffIdBox2.Text, conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;
                conn.Open();

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdStaff.DataSource = ds.Tables["cc"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Found");
                MessageBox.Show(ex.Message);
            }
        }

        private void staffIdBox2_TextChanged(object sender, EventArgs e)
        {
            showStaffMember();
        }
    }
}
