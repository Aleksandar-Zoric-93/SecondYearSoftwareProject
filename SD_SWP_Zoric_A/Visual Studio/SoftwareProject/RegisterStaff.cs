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
    public partial class RegisterStaff : Form
    {
        
        public RegisterStaff()//homePage parent
        {
            InitializeComponent();
            //Parent = parent;
           
        }

        public RegisterStaff(Control Parent)
        {
            // TODO: Complete member initialization
            this.Parent = Parent;
        }

        private void getNextStockNoStaff()
        {
            try
            {
                String AlexDB = "Data Source=Oracle; User ID=t00166011; password=4yybapkv";
                OracleConnection conn = new OracleConnection(AlexDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(StaffID) FROM Staff", conn);

                conn.Open();


                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                    
                    StaffIdTxt.Text = String.Format("{0:0000}", 1);
                }
                else
                {
                    StaffIdTxt.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                   
                }

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

      

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {

            new homePage().Show();
            this.Close();
        }

        private void RegisterStaff_Load(object sender, EventArgs e)
        {
            StaffIdTxt.MaxLength = 4;
            StatusTxt.MaxLength = 2;
            surnameBox.MaxLength = 20;
            forenameBox.MaxLength = 20;
            dobBox.MaxLength = 10;
            emailBox.MaxLength = 30;
            phoneBox.MaxLength = 10;

             getNextStockNoStaff();
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

       

      

      

        private void amendBtn_Click(object sender, EventArgs e)
        {
            //validate input
            if (StatusTxt.Text == "" || surnameBox.Text == "" || forenameBox.Text == "" || dobBox.Text == "" || emailBox.Text == "" || phoneBox.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (StatusTxt.Text == "")
                {
                    StatusTxt.Focus();
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
                                    
                                        else if (emailBox.Text == "")
                                        {
                                         phoneBox.Focus();
                                        }
                return;
            }
            try
            {
                String AlexDB = "Data Source=Oracle;User Id = t00166011;Password = 4yybapkv;";
                //Connect to Database
                OracleConnection conn = new OracleConnection(AlexDB);

                //Define SQL Query (UPDATE)
                String strSQL = "INSERT INTO Staff VALUES(" + StaffIdTxt.Text + ",'" + surnameBox.Text + "'," + "'" +
                forenameBox.Text + "','" + dobBox.Text + "','" + emailBox.Text + "','" + phoneBox.Text + "','" + StatusTxt.Text + "')";


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
            MessageBox.Show("Staff Member Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calling the method to clear the form
            clearForm();

            //reset the ID number
            getNextStockNoStaff();
        }

          //Method to clear the form
        private void clearForm()
        {
            StatusTxt.Text = String.Empty;
            surnameBox.Text = String.Empty;
            forenameBox.Text = String.Empty;
            dobBox.Text = String.Empty;
            emailBox.Text = String.Empty; 
            phoneBox.Text = String.Empty; 
        }

        }
    }

