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
    public partial class frmRegistration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmRegistration()
        {
            InitializeComponent();

            // Empty Error Labels
            lbl_runame_error.Text = "";
            lbl_rmail_error.Text = "";
            lbl_rcontact_error.Text = "";
            lbl_rpwd_error.Text = "";
            lbl_rconfirm_error.Text = "";

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Read from values
            String RUsername = txtbox_rusername.Text;
            String REmail = txtbox_remail.Text;
            String RContact = txtbox_rcontact.Text;
            String RPassword = txtbox_rpwd.Text;
            String RConfirm = txtbox_rconfirm.Text;

            // Empty Error Labels
            lbl_runame_error.Text = "";
            lbl_rmail_error.Text = "";
            lbl_rcontact_error.Text = "";
            lbl_rpwd_error.Text = "";
            lbl_rconfirm_error.Text = "";

            // Validations
            if (RUsername =="")
            {
                lbl_runame_error.Text = "This field is required !";
            }
            if (REmail == "")
            {
                lbl_rmail_error.Text = "This field is required !";
            }
            if (RContact == "")
            {
                lbl_rcontact_error.Text = "This field is required !";
            }
            if (RPassword == "")
            {
                lbl_rpwd_error.Text = "This field is required !";
            }
            if (RConfirm == "")
            {
                lbl_rconfirm_error.Text = "This field is required !";
            }
            else if (RConfirm == RPassword)
            {
                //Interact with Table
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into customer_registration(Username, Email, ContactNo, Password, ConfirmPassword) values('" + RUsername + "', '" + REmail + "', '" + RContact + "', '" + RPassword + "', '" + RConfirm + "' )";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your Account has been Registered Successfully !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_txtboxes();
            }
            else
            {
                lbl_rconfirm_error.Text = "Password does not match !";
                txtbox_rpwd.Text = "";
                txtbox_rconfirm.Text = "";
            }
        }

        private void btn_rcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_toLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainLogin mainlogin = new frmMainLogin();
            mainlogin.Show();
            
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                txtbox_rpwd.PasswordChar = '\0';
                txtbox_rconfirm.PasswordChar = '\0';
            }
            else
            {
                txtbox_rpwd.PasswordChar = '•';
                txtbox_rconfirm.PasswordChar = '•';
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            // Check the Connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
        
        private void Clear_txtboxes()
        {
            txtbox_rusername.Text = "";
            txtbox_rpwd.Text = "";
            txtbox_remail.Text = "";
            txtbox_rcontact.Text = "";
            txtbox_rconfirm.Text = "";
        }
    }
}
