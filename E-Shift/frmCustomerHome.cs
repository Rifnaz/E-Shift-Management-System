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
    public partial class frmCustomerHome : Form
    {
        public frmCustomerHome()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        private void frmCustomerHome_Load(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerDashboard());

            // Check the connection status & close/Open
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            String cname = frmCustomerLogin.CustName;

            // Fill the Username Textbox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Username from customer_registration where Username ='"+cname+"'", con);
            da.Fill(dt);

            lbl_cname.Text = dt.Rows[0][0].ToString();
        }
        public void loadchomeform(object Form)
        {
            if (this.pnl_customerhome.Controls.Count > 0)
                this.pnl_customerhome.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_customerhome.Controls.Add(f);
            this.pnl_customerhome.Tag = f;
            f.Show();
        }

        private void btn_cdashboard_Click(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerDashboard());
        }

        private void btn_cprofile_Click(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerProfile());
        }

        private void btn_cproducts_Click(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerProducts());

        }

        private void btn_cjobs_Click(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerJobs());
        }

        private void btn_cload_Click(object sender, EventArgs e)
        {
            loadchomeform(new frmCustomerLoads());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frmMainLogin mainlogin = new frmMainLogin();
            mainlogin.Show();
            this.Hide();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_customerhome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
