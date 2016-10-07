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
   
    public partial class AmendStaff : Form
    {

        public AmendStaff(homePage parent)
        {
            InitializeComponent();
            Parent = parent;
        }


         public AmendStaff()
         {
             // TODO: Complete member initialization
            InitializeComponent();
         }

        private void AmendStaff_Load_1(object sender, EventArgs e)
        {

            //Setting the maximum length for each textbox
            txtSearchID.MaxLength = 4;
            searchName.MaxLength = 20;
            staffIDTxt.MaxLength = 4;
            surnameBox.MaxLength = 20;
            dobBox.MaxLength = 10;
            emailBox.MaxLength = 30;
            phoneBox.MaxLength = 10;
           
        }


        //Not currently used
        private void findBtn_Click(object sender, EventArgs e)
        {
            //Only one of StockNo OR Description may be entered
            if (!txtSearchID.Text.Equals("") & !searchName.Text.Equals(""))
            {
                MessageBox.Show("Please enter EITHER StockNo or Description");
                txtSearchID.Focus();
                return;
            }

            //hide any previously displayed data
            grpAllStaff.Visible = false;
            grpStaff.Visible = false;

            // Display all stock with description
            if (txtSearchID.Text.Length > 0)
            {
                //Get the selected StockNo details
                getStaff(Convert.ToInt32(txtSearchID.Text));
            }
            else
            {
                //Display the all Stock details with matching description
                getMatchingStaff(searchName.Text);
            }
        }



        //Returns the staff ID, Search using staff ID
        private void getStaff(int intStaffNo)
        {
            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //define SQL query
                String strSQL = "SELECT * FROM Staff WHERE StaffID = " + intStaffNo;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    staffIDTxt.Text = dr.GetValue(0).ToString();
                    surnameBox.Text = dr.GetValue(1).ToString();
                    forenameBox.Text = dr.GetValue(2).ToString();
                    dobBox.Text = dr.GetValue(3).ToString();
                    emailBox.Text = dr.GetValue(4).ToString();
                    phoneBox.Text = dr.GetValue(5).ToString();
                   
                    //display the details on the form
                    grpStaff.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Details Found");
                    txtSearchID.Focus();
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



        //Return staff with the matching name inputed by the user
        private void getMatchingStaff(String strDesc)
        {
            //Define database connection string
            String oradb = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";

            OracleConnection conn = new OracleConnection(oradb);

            //define SQL query
            String strSQL = "SELECT StaffID, Forename FROM Staff WHERE Forename LIKE '" +
                searchName.Text + "%' ORDER BY Forename";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            grdStaff.DataSource = ds.Tables["ss"];
            grpAllStaff.Visible = true;
        }



        //Updates new information given by the user
        private void UpdateStaff()
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
            String strSQL = "UPDATE Staff SET Surname = '" + surnameBox.Text +
                "', Forename = '" + forenameBox.Text +
                "', DOB = '" + dobBox.Text +
                "', Email = '" + emailBox.Text + "', Phone = '" + phoneBox.Text +
                "' WHERE StaffID = " + staffIDTxt.Text;

            
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

        private void grpStock_Enter(object sender, EventArgs e)
        {

        }

        private void grpAllStaff_Enter(object sender, EventArgs e)
        {

        }


        //Runs the update method and displays a confirmation message
        private void amendButton_Click(object sender, EventArgs e)
        {
            //validate input
            if (staffIDTxt.Text == "" || surnameBox.Text == "" || forenameBox.Text == "" || dobBox.Text == "" || emailBox.Text == "" || phoneBox.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (staffIDTxt.Text == "")
                {
                    staffIDTxt.Focus();
                }

                else if (surnameBox.Text == "")
                {
                    surnameBox.Focus();
                }

                     else if (forenameBox.Text == "")
                     {
                         forenameBox.Focus();
                     }

                         else if (dobBox.Text == "")
                        {
                          dobBox.Focus();
                        }

                             else if (emailBox.Text == "")
                             {
                              emailBox.Focus();
                             }

                                 else if (phoneBox.Text == "")
                                 {
                                    phoneBox.Focus();
                                 }

                return;
            }

            //update customer file
            UpdateStaff();

            //display confirmation message
            MessageBox.Show("Staff Member Updated");
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchID.Text.Equals(""))
                getStaff(Convert.ToInt32(txtSearchID.Text));
            else
                grpStaff.Hide();
        }


        private void searchName_TextChanged(object sender, EventArgs e)
        {
            if (!searchName.Text.Equals(""))
                getMatchingStaff(searchName.Text);
            else
                grpAllStaff.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegisterStaff nf = new RegisterStaff();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AmendStaff nf = new AmendStaff();

            this.Close();
            nf.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ListStaff nf = new ListStaff();

            this.Close();
            nf.Show();
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CancelRequest nf = new CancelRequest();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RecordOrder nf = new RecordOrder();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            EditOrder nf = new EditOrder();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ListOrder nf = new ListOrder();

            this.Close();
            nf.Show();

        }


        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            RecordPayment nf = new RecordPayment();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            CancelOrder nf = new CancelOrder();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            AddFood nf = new AddFood();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            ChangeFood nf = new ChangeFood();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            RemoveFood nf = new RemoveFood();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            ListFood1 nf = new ListFood1();

            this.Close();
            nf.Show();

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            ViewSales nf = new ViewSales();

            this.Close();
            nf.Show();

        }
    }
}
