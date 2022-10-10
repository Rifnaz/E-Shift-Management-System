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
    public partial class frmAdminLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminLogin()
        {
            InitializeComponent();

            // Empty Error labels
            lbl_admin_error.Text = "";
            lbl_auname_error.Text = "";
            lbl_apwd_error.Text = "";
        }

        private void btn_ALogin_Click(object sender, EventArgs e)
        {
            // Read form Values
            String AUsername = txtbox_Ausername.Text;
            String APassword = txtbox_Apassword.Text;

            // Empty Error labels
            lbl_admin_error.Text = "";
            lbl_auname_error.Text = "";
            lbl_apwd_error.Text = "";

            // Create the Admin Login Authentication
            SqlDataAdapter da = new SqlDataAdapter("select * from admin_registration where Username ='"+AUsername+"' and Password ='"+APassword+"' ", con);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            // Validations
            if (AUsername =="")
            {
                lbl_auname_error.Text = "This field is required !"; 
            }
            if (APassword =="")
            {
                lbl_apwd_error.Text = "This field is required !";
            }
            else if (dt.Rows.Count == 1)
            {
                frmMainLogin mainlogin = (frmMainLogin)Application.OpenForms["frmMainLogin"];
                mainlogin.Hide();

                frmAdminHome adminhome = new frmAdminHome();
                adminhome.Show();

            }
            else
            {
                lbl_admin_error.Text = "Invalid Username or Password !";
                txtbox_Ausername.Text = "";
                txtbox_Apassword.Text = "";
            }
        }

        private void btn_Acancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_Ashow_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ashow_password.Checked)
            {
                txtbox_Apassword.PasswordChar = '\0';
            }
            else
            {
                txtbox_Apassword.PasswordChar = '•';
            }
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
