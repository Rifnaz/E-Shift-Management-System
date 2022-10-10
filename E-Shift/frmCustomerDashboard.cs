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
    public partial class frmCustomerDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmCustomerDashboard()
        {
            InitializeComponent();
        }

        private void frmCustomerDashboard_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            customer_dashboard();
        }
        public void customer_dashboard()
        {
            String cname = frmCustomerLogin.CustName;

            // Retrive total of Accepted jobs to dashboard
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from jobs where  CustomerName ='" + cname + "' and Status = '" + "Accepted" + "'", con);
            da.Fill(dt);
            lbl_acceptedjob.Text = dt.Rows[0][0].ToString();

            // Retrive total of Declined jobs to dashboard
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from jobs where CustomerName ='" + cname + "' and Status = '" + "Declined" + "'", con);
            da2.Fill(dt2);
            lbl_declinedjobs.Text = dt2.Rows[0][0].ToString();

            // Retrive total of Pending jobs to dashboard
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select count(*) from jobs where CustomerName ='" + cname + "' and Status ='" + "Processing..." + "'", con);
            da3.Fill(dt3);
            lbl_pendingjobs.Text = dt3.Rows[0][0].ToString();

            // Retrive total of loads to dashboard
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select count(*) from load where CustomerName = '"+cname+"'", con);
            da4.Fill(dt4);
            lbl_totalloads.Text = dt4.Rows[0][0].ToString();
        
        }
    }
}
