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
    public partial class frmAdminProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminProfile()
        {
            InitializeComponent();

            // Empty Labels
            lbl_aduname_error.Text = "";
            lbl_admail_error.Text = "";
            lbl_adcontact_error.Text = "";
            lbl_adpwd_error.Text = "";
            lbl_adconfirm_error.Text = "";
        }

        private void frmAdminProfile_Load(object sender, EventArgs e)
        {
            // Check the connection status & close/Open
            if (con.State == ConnectionState.Open )
            {
                con.Close();
            }
            con.Open();

            // Fill the Username Textbox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Username, Email, ContactNo from admin_registration", con);
            da.Fill(dt);

            txtbox_adusername.Text = dt.Rows[0][0].ToString();
            txtbox_ademail.Text = dt.Rows[0][1].ToString();
            txtbox_adcontact.Text = dt.Rows[0][2].ToString();
        }

        private void btn_apupdate_Click(object sender, EventArgs e)
        {
            // Read form value
            String AUsername = txtbox_adusername.Text;
            String AEmail = txtbox_ademail.Text;
            String AContact = txtbox_adcontact.Text;
            String APassword = txtbox_adpwd.Text;
            String AConfirm = txtbox_adconfirm.Text;

            // Empty error Labels
            lbl_aduname_error.Text = "";
            lbl_admail_error.Text = "";
            lbl_adcontact_error.Text = "";
            lbl_adpwd_error.Text = "";
            lbl_adconfirm_error.Text = "";

            // Validations
            if (AUsername == "")
            {
                lbl_aduname_error.Text = "This field is required !";
            }
            if (AEmail == "")
            {
                lbl_admail_error.Text = "This field is required !";
            }
            if (AContact == "")
            {
                lbl_adcontact_error.Text = "This field is required !";
            }
            if (APassword == "")
            {
                lbl_adpwd_error.Text = "This field is required !";
            }
            if (AConfirm == "")
            {
                lbl_adconfirm_error.Text = "This field is required !";
            }
            else if(APassword == AConfirm)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update admin_registration set Username ='" + AUsername + "', Email='" + AEmail + "', ContactNo='" + AContact + "', Password='" + APassword + "', ConfirmPassword='" + AConfirm + "' where AdminID= '" + 1 + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your account details has been Updated Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CleartxtBoxes();
            }
            else
            {
                lbl_adconfirm_error.Text = "Password does not match !";
                txtbox_adpwd.Text = "";
                txtbox_adconfirm.Text = "";
            }
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                txtbox_adpwd.PasswordChar = '\0';
                txtbox_adconfirm.PasswordChar = '\0';
            }
            else
            {
                txtbox_adpwd.PasswordChar = '•';
                txtbox_adconfirm.PasswordChar = '•';
            }
        }

        private void btn_apclear_Click(object sender, EventArgs e)
        {
            CleartxtBoxes();
        }

        private void CleartxtBoxes()
        {
            txtbox_adusername.Text = "";
            txtbox_ademail.Text = "";
            txtbox_adcontact.Text = "";
            txtbox_adpwd.Text = "";
            txtbox_adconfirm.Text = "";
        }
    }
}
