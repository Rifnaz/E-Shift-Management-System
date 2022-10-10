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
    public partial class frmAdminJobs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminJobs()
        {
            InitializeComponent();

            lbl_search_error.Text = "";
        }

        private void frmAdminJobs_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            load_selected_products();
            load_jobs();
            fillcombo();
        }

        private void fillcombo()
        {
            // Fill the Items to Jobserch Combo
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Status from jobs group by Status", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbox_sjob.Items.Add(dr["Status"].ToString());
            }

            // Fill the Items to JobID combo
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select JobID from jobs where Status = '"+"Processing..."+"'", con);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                cmbox_jobidsearch.Items.Add(dr["JobID"].ToString());
            }
        }

        public void load_selected_products()
        {
            // Load selected products to Admin dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from selected_products";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_selectedproducts.DataSource = dt;

        }

        public void load_jobs()
        {
            // Load jobs to Admin dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from jobs";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_ajobs.DataSource = dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_search_error.Text = "";
            // Read form values
            int JID;
            String Jobid = cmbox_jobidsearch.Text;

            // Validations
            if (Jobid == "")
            {
                lbl_search_error.Text = "Please Enter a Job ID to search !";
            }
            else
            {
                JID = int.Parse(cmbox_jobidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from selected_products where JobID ='" + JID + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_selectedproducts.DataSource = dt;


            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            // Read form values
            int JID;
            String Jobid = cmbox_jobidsearch.Text;

            // Validations
            if (Jobid == "")
            {
                lbl_search_error.Text = "Please Enter a Job ID to Accept paticular Job !";
            }
            else
            {
                JID = int.Parse(cmbox_jobidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update jobs set status ='" + "Accepted" + "' where JobID ='" + JID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("The Job has been Accepted Successfully !", "Accept", MessageBoxButtons.OK, MessageBoxIcon.Information);

                load_selected_products();
                load_jobs();
                cmbox_sjob.Items.Clear();
                cmbox_jobidsearch.Items.Clear();
                fillcombo();
            }
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            // Read form values
            int JID;
            String Jobid = cmbox_jobidsearch.Text;

            // Validations

            if (Jobid == "")
            {
                lbl_search_error.Text = "Please select a Job ID to Decline paticular Job !";
            }
            else
            {
                JID = int.Parse(cmbox_jobidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update jobs set status ='" + "Declined" + "' where JobID ='" + JID + "'";
                cmd.ExecuteNonQuery();

                // Delete the selected products
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete selected_products where JobID ='" + JID + "'";
                cmd2.ExecuteNonQuery();

                MessageBox.Show("The Job has been Declined Successfully !", "Decline", MessageBoxButtons.OK, MessageBoxIcon.Information);

                load_selected_products();
                load_jobs();
                cmbox_sjob.Items.Clear();
                cmbox_jobidsearch.Items.Clear();
                fillcombo();
            }
        }

        private void btn_searchjob_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from jobs where Status = '" + cmbox_sjob.Text + "' ", con);
            da.Fill(dt);
            dgv_ajobs.DataSource = dt;
        }
    }
}
