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
    public partial class frmAdminDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

           // Retrive total of customer to dashboard
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from customer_registration", con);
            da.Fill(dt);
            lbl_totalcustomer.Text = dt.Rows[0][0].ToString();

            // Retrive total of products to dashboard
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from products", con);
            da2.Fill(dt2);
            lbl_totalproducts.Text = dt2.Rows[0][0].ToString();

            // Retrive total of loads to dashboard
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select count(*) from load", con);
            da3.Fill(dt3);
            lbl_totalloads.Text = dt3.Rows[0][0].ToString();

            // Retrive total of jobs to dashboard
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select count(*) from jobs", con);
            da4.Fill(dt4);
            lbl_totaljobs.Text = dt4.Rows[0][0].ToString();
        }
    }
}
