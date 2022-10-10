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
    public partial class frmCustomerProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmCustomerProfile()
        {
            InitializeComponent();

            // Empty Error Labels
            Clear_Label();
        }

        private void frmCustomerProfile_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            String cname = frmCustomerLogin.CustName;

            // Fill the Username Textbox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Username, Email, ContactNo from customer_Registration where Username = '"+cname+"'", con);
            da.Fill(dt);

            txtbox_cpsusername.Text = dt.Rows[0][0].ToString();
            txtbox_cpemail.Text = dt.Rows[0][1].ToString();
            txtbox_cpcontact.Text = dt.Rows[0][2].ToString();
        }

        private void btn_cpupdate_Click(object sender, EventArgs e)
        {
            // Read form Values
            String CPUsername = txtbox_cpsusername.Text;
            String CPEmail = txtbox_cpemail.Text;
            String CPContact = txtbox_cpcontact.Text;
            String CPPassword = txtbox_cppwd.Text;
            String CPConfirm = txtbox_cpconfirm.Text;

            // Empty Error Labels
            Clear_Label();

            // Validations
            if (CPUsername == "")
            {
                lbl_cpuname_error.Text = "This field is required !";
            }
            if (CPEmail == "")
            {
                lbl_cpmail_error.Text = "This field is required !";
            }
            if (CPContact == "")
            {
                lbl_cpcontactno_error.Text = "This field is required !";
            }
            if (CPPassword == "")
            {
                lbl_cppwd_error.Text = "This field is required !";
            }
            if (CPConfirm == "")
            {
                lbl_cpconfirm_error.Text = "This field is required !";
            }
            else if (CPConfirm == CPPassword)
            {
                String Uname = frmCustomerLogin.CustName;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update customer_registration set Username ='" + CPUsername + "', Email='" + CPEmail + "', ContactNo='" + CPContact + "', Password='" + CPPassword + "', ConfirmPassword='" + CPConfirm + "' where Username= '" + Uname + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your account details has been Updated Successfuly !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_textboxes();
            }
            else
            {
                lbl_cpconfirm_error.Text = "Password does not match !";
                txtbox_cppwd.Text = "";
                txtbox_cpconfirm.Text = "";
            }
        }

        private void btn_cpclear_Click(object sender, EventArgs e)
        {
            Clear_textboxes();
            Clear_Label();
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                txtbox_cppwd.PasswordChar = '\0';
                txtbox_cpconfirm.PasswordChar = '\0';
            }
            else
            {
                txtbox_cppwd.PasswordChar = '•';
                txtbox_cpconfirm.PasswordChar = '•';
            }
        }

        private void Clear_Label()
        {
            lbl_cpuname_error.Text = "";
            lbl_cpmail_error.Text = "";
            lbl_cpcontactno_error.Text = "";
            lbl_cppwd_error.Text = "";
            lbl_cpconfirm_error.Text = "";
        }
        private void Clear_textboxes()
        {
            txtbox_cpsusername.Text = "";
            txtbox_cpemail.Text = "";
            txtbox_cpcontact.Text = "";
            txtbox_cppwd.Text = "";
            txtbox_cpconfirm.Text = "";
        }
    }
}
