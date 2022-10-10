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
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminDashboard());

            // Check the connection status & close/Open
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            // Fill the Username Textbox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Username from admin_registration", con);
            da.Fill(dt);

            lbl_aname.Text = dt.Rows[0][0].ToString();
        }
        public void loadadhomeform(object Form)
        {
            if (this.pnl_adminhome.Controls.Count > 0)
                this.pnl_adminhome.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_adminhome.Controls.Add(f);
            this.pnl_adminhome.Tag = f;
            f.Show();
        }

        private void btn_adashboard_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminDashboard());
        }

        private void btn_aprofile_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminProfile());
        }

        private void btn_aproduct_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminProducts());
        }

        private void btn_ajobs_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminJobs());
        }

        private void btn_aloads_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminLoad());
        }

        private void btn_acustomer_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminCustomer());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            loadadhomeform(new frmAdminReports());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainLogin mainlogin = new frmMainLogin();
            mainlogin.Show(); 
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
