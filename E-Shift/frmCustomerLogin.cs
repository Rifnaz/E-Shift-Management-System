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
    public partial class frmCustomerLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmCustomerLogin()
        {
            InitializeComponent();

            // Empty Error Labels when form load
            lbl_customer_error.Text = "";
            lbl_cuname_error.Text = "";
            lbl_cpwd_error.Text = "";
        }

        public static String CustName = "";

        private void btn_CLogin_Click(object sender, EventArgs e)
        {


            // Read Form Value
            String CUsername = txtbox_Cusername.Text;
            String CPassword = txtbox_Cpassword.Text;

            // Empty Error Labels
            lbl_customer_error.Text = "";
            lbl_cuname_error.Text = "";
            lbl_cpwd_error.Text = "";

            // Create the Admin Login Authentication
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_registration where Username ='" + CUsername + "' and Password ='" + CPassword + "' ", con);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            // Validations
            if (CUsername == "")
            {
                lbl_cuname_error.Text = "This field is required !";
                
            }
            if (CPassword == "")
            {
                lbl_cpwd_error.Text = "This field is required !";
            }
            else if (dt.Rows.Count == 1)
            {
                CustName = txtbox_Cusername.Text;

                frmCustomerHome customerhome = new frmCustomerHome();
                customerhome.Show();
            }
            else
            {
                lbl_customer_error.Text = "Invalid Username or Password !";
                txtbox_Cusername.Text = "";
                txtbox_Cpassword.Text = "";
            }
        }

        private void lbl_createAccount_Click(object sender, EventArgs e)
        {
            frmMainLogin mainlogin = (frmMainLogin)Application.OpenForms["frmMainLogin"];
            mainlogin.Hide();

            frmRegistration reg = new frmRegistration();
            reg.Show();  
        }

        private void btn_Ccancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_Cshow_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cshow_password.Checked)
            {
                txtbox_Cpassword.PasswordChar = '\0';
            }
            else
            {
                txtbox_Cpassword.PasswordChar = '•';
            }
        }
    }
}
