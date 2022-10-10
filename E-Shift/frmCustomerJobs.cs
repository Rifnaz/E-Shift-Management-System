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
    public partial class frmCustomerJobs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmCustomerJobs()
        {
            InitializeComponent();

            // Empty error labels
            lbl_error_create.Text = "";
            lbl_error_select.Text = "";
        }

        private void frmCustomerJobs_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Load_jobs();
            Load_products();
            fillcombo();

        }

        private void fillcombo()
        {

            String cname = frmCustomerLogin.CustName;

            // Fill the Textbox(job) from Login username
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Username = '" + cname + "'", con);
            da.Fill(dt);

            txtbox_custname.Text = dt.Rows[0][0].ToString();

            // Fill Items to JobID combobox
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select JobID from jobs where CustomerName ='" + cname + "' and Status !='"+"Accepted"+"'", con);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cmbox_jobid.Items.Add(dr["JobID"].ToString());
                cmbox_jobidsearch.Items.Add(dr["JobID"].ToString());
            }

            // Fill Items to ProductName combobox
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select ProductName from products", con);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                cmbox_products.Items.Add(dr["ProductName"].ToString());
            }
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            // Read form values
            String CName = txtbox_custname.Text;
            String SLocation = cmbox_slocation.Text;
            String Desti = txtbox_destination.Text;


            // Empty error labels
            lbl_error_create.Text = "";

            // Validation
            if (CName == "" || SLocation == "" || Desti == "")
            {
                lbl_error_create.Text = "All fields are required !";
            }
            else
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into jobs(CustomerName, StartLocation, Destination, Status) values('" + CName + "', '" + SLocation + "', '" + Desti + "', '" + "Processing..." + "')";
                cmd.ExecuteNonQuery();

                Load_jobs();
                Clear_Create_txtBoxes();
                clear_combo_items();
                fillcombo();
               
            }
        }
        private void Clear_Create_txtBoxes()
        {
            txtbox_custname.Text = "";
            cmbox_slocation.Text = "";
            txtbox_destination.Text = "";
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            // Read form value
            String Jobid = cmbox_jobid.Text;
            String ProName = cmbox_products.Text;
            String Quanti = txtbox_cquantity.Text;


            // Empty error labels
            lbl_error_select.Text = "";

            // Validation
            if (cmbox_products.Text == "")
            {
                lbl_error_select.Text = "Please enter the JID..!";
            }

            if (Jobid == "" || ProName == "" || Quanti == "")
            {
                lbl_error_select.Text = "All fields are required !";
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into selected_products ( JobID, ProductName, Quantity) values('" + Jobid + "', '" + ProName + "', '" + Quanti + "')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update jobs set Status = '" + "Processing..." + "' where JobID = '"+Jobid+"'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("The Product has been Selected under the JobID -" +" "+ Jobid,  "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_select_txtBoxes();
            }
        }

        public void Load_products()
        {

            // Load selected products to customer dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_productsjb.DataSource = dt;
        }

        public void Load_jobs()
        {
            String cname = frmCustomerLogin.CustName;

            // Load jobs to customer dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from jobs where CustomerName = '" + cname + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_cjobs.DataSource = dt;
        }

        private void Clear_select_txtBoxes()
        {
            cmbox_jobid.Text = "";
            cmbox_products.Text = "";
            txtbox_cquantity.Text = "";
        }

        private void btn_deletejob_Click(object sender, EventArgs e)
        {
            // Read form value
            int JobID;
            String Jid = cmbox_jobidsearch.Text;

            //Validation
            if (cmbox_jobidsearch.Text == "")
            {
                lbl_error_create.Text = "Please enter the JID Which you're desired to Delete..!";
            }
            else
            {
                // Delete jobs
                JobID = int.Parse(cmbox_jobidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete jobs where JobID= '" + JobID + "'";
                cmd.ExecuteNonQuery();

                // Delete selected Products
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "delete selected_products where JobID= '" + JobID + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Job Details has been deleted Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_jobs();
                clear_combo_items();
                fillcombo();
            }
        }
        private void clear_combo_items()
        {
            cmbox_jobid.Items.Clear();
            cmbox_jobidsearch.Items.Clear();
            cmbox_products.Items.Clear();
        }

    }
}
