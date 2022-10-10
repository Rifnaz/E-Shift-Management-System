using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace E_Shift
{
    public partial class frmAdminCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminCustomer()
        {
            InitializeComponent();

            // Empty error labels
            Clear_Labels();
        }

        private void frmAdminCustomer_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            LoadCustomer();
            fill_custidcombo();
        }

        private void fill_custidcombo()
        {
            // Fill customer ID combo
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select CustomerID from customer_registration", con);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                cmbox_custidsearch.Items.Add(dr["CustomerID"].ToString());
            }
        }

        public void LoadCustomer()
        {
            // Retrive the Data from the table
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer_registration";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_customers.DataSource = dt;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // Read form Values
            String CDUsername = txtbox_cdusername.Text;
            String CDmail = txtbox_cdemail.Text;
            String CDContact = txtbox_cdcontact.Text;
            String CDPassword = txtbox_cdpwd.Text;
            String CDConfirm = txtbox_cdconfirm.Text;
            String Cid = cmbox_custidsearch.Text;

            // Empty error labels
            Clear_Labels();

            // Validations
            if (CDUsername =="")
            {
                lbl_cduname_error.Text = "This field is required !";
            }
            if (CDmail == "")
            {
                lbl_cdmail_error.Text = "This field is required !";
            }
            if (CDContact == "")
            {
                lbl_cdcontact_error.Text = "This field is required !";
            }
            if (CDPassword == "")
            {
                lbl_cdpwd_error.Text = "This field is required !";
            }
            if (CDConfirm == "")
            {
                lbl_cdconfirm_error.Text = "This field is required !";
            }
            else if (CDPassword == CDConfirm)
            {
                //Interact with Tables to create new customer
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into customer_registration(Username, Email, ContactNo, Password, ConfirmPassword) values('" + CDUsername + "', '" + CDmail + "', '" + CDContact + "', '" + CDPassword + "', '" + CDConfirm + "' )";
                cmd.ExecuteNonQuery();

                MessageBox.Show("New Customer has been Registered Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadCustomer();
                Clear_txtboxes();
                cmbox_custidsearch.Items.Clear();
                fill_custidcombo();

            }
            else
            {
                lbl_cdconfirm_error.Text = "Password does not match !";
                txtbox_cdpwd.Text = "";
                txtbox_cdconfirm.Text = "";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Read form values
            int CustomerID;
            String Cid = cmbox_custidsearch.Text;
            String CDUsername = txtbox_cdusername.Text;
            String CDmail = txtbox_cdemail.Text;
            String CDContact = txtbox_cdcontact.Text;
            String CDPassword = txtbox_cdpwd.Text;
            String CDConfirm = txtbox_cdconfirm.Text;

            Clear_Labels();

            // Validation
            if (Cid == "")
            {
                lbl_uid_search_error.Text = "Please enter the CustomerID Which you're desired to Updated..!";
            }
            if (CDUsername == "" || CDmail == "" || CDContact == "" || CDPassword == "" || CDConfirm == "")
            {
                lbl_cdconfirm_error.Text = "All fields are required !";
            }
            else if(CDPassword == CDConfirm)
            {
                //Update customer to database
                CustomerID = int.Parse(cmbox_custidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update customer_registration set Username ='" + CDUsername + "', Email='" + CDmail + "', ContactNo='" + CDContact + "', Password='" + CDPassword + "', ConfirmPassword='" + CDConfirm + "' where CustomerID= '" + CustomerID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Details has been Updated Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                LoadCustomer();
                Clear_txtboxes();
                cmbox_custidsearch.Items.Clear();
                fill_custidcombo();
            }
            else
            {
                lbl_cdconfirm_error.Text = "Password does not match !";
                txtbox_cdpwd.Text = "";
                txtbox_cdconfirm.Text = "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Read form value
            int CustomerID;
            String Cid = cmbox_custidsearch.Text;

            Clear_Labels();

            //Validation
            if (Cid =="")
            {
                lbl_uid_search_error.Text = "Please enter the CustomerID Which you're desired to Deleted..!";
            }
            else
            {
                // Delete customer from database
                CustomerID = int.Parse(cmbox_custidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete customer_registration where CustomerID= '" + CustomerID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Details has been deleted Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                LoadCustomer();
                Clear_txtboxes();
                cmbox_custidsearch.Items.Clear();
                fill_custidcombo();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Read form value
            int CustomerID;
            String Cid = cmbox_custidsearch.Text;

            Clear_Labels();

            //Validation
            if (Cid == "")
            {
                lbl_uid_search_error.Text = "This field is required !";
            }
            else
            {
                CustomerID = int.Parse(cmbox_custidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from customer_registration where CustomerID = '" + CustomerID + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_customers.DataSource = dt;

                txtbox_cdusername.Text = dt.Rows[0][1].ToString();
                txtbox_cdemail.Text = dt.Rows[0][2].ToString();
                txtbox_cdcontact.Text = dt.Rows[0][3].ToString();
                txtbox_cdpwd.Text = dt.Rows[0][4].ToString();
                txtbox_cdconfirm.Text = dt.Rows[0][5].ToString();
                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear_txtboxes();
            Clear_Labels();
            LoadCustomer();
        }

        private void Clear_txtboxes()
        {
            txtbox_cdusername.Text = "";
            txtbox_cdemail.Text = "";
            txtbox_cdcontact.Text = "";
            txtbox_cdpwd.Text = "";
            txtbox_cdconfirm.Text = "";
            cmbox_custidsearch.Text = "";
        }

        private void Clear_Labels()
        {
            lbl_cduname_error.Text = "";
            lbl_cdmail_error.Text = "";
            lbl_cdcontact_error.Text = "";
            lbl_cdpwd_error.Text = "";
            lbl_cdconfirm_error.Text = "";
            lbl_uid_search_error.Text = "";
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                txtbox_cdpwd.PasswordChar = '\0';
                txtbox_cdconfirm.PasswordChar = '\0';
            }
            else
            {
                txtbox_cdpwd.PasswordChar = '•';
                txtbox_cdconfirm.PasswordChar = '•';
            }
        }
    }
}
