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
    public partial class frmAdminLoad : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminLoad()
        {
            InitializeComponent();

            // Empty error labels
            lbl_loadsearch_error.Text = "";
            lbl_loadcreate_error.Text = "";
            lbl_jobid_error.Text = "";
        }

        private void frmAdminLoad_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Load_loads();
            fillloadcombo();

            // Fill Items to JobID to combobox
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select JobID from jobs where Status ='"+"Accepted"+"'" , con);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cmbox_jobid.Items.Add(dr["JobID"].ToString());
            }
        }

        private void fillloadcombo()
        {
            // Fill Items to Loadid select combo
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select LoadID from Load", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbox_loadidselect.Items.Add(dr["LoadID"].ToString());
            }
        }

        public void Load_loads()
        {
            // Load loads to Admin dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from load";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_aloads.DataSource = dt;
        }

        private void btn_create_load_Click(object sender, EventArgs e)
        {
            // Read form values
            String LJobID = cmbox_jobid.Text;
            String LCname = txtbox_custname.Text;
            String Lorry = cmbox_lorry.Text;
            String Driver = cmbox_driver.Text;
            String Assistant = cmbox_assistant.Text;
            String Container = cmbox_container.Text;
            String LProducts = txtbox_productsL.Text;

            // Empty error labels
            lbl_loadsearch_error.Text = "";
            lbl_loadcreate_error.Text = "";

            // Validations
            if (LJobID == "" || Lorry == "" || Driver == "" || Assistant == "" || Container == "" || LProducts == "")
            {
                lbl_loadcreate_error.Text = "All fields are required !";
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into load (JobID,CustomerName, Lorry, Driver, Assistant, Container, Products) values('" + LJobID + "', '" + LCname + "', '" + Lorry + "', '" + Driver + "', '" + Assistant + "', '" + Container + "', '" + LProducts + "')";
                cmd.ExecuteNonQuery();

                //change status to laoded
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update jobs set status ='" + "Loaded" + "' where JobID ='" + LJobID + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Load has been created Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_loads();
                Clear_txtboxes();
                cmbox_loadidselect.Items.Clear();
                fillloadcombo();
            }
        }

        private void btn_update_load_Click(object sender, EventArgs e)
        {
            lbl_loadsearch_error.Text = "";

            // Read form values
            int LoadID;
            String Lid = cmbox_loadidselect.Text;
            String LJobID = cmbox_jobid.Text;
            String LCname = txtbox_custname.Text;
            String Lorry = cmbox_lorry.Text;
            String Driver = cmbox_driver.Text;
            String Assistant = cmbox_assistant.Text;
            String Container = cmbox_container.Text;
            String Lproducts = txtbox_productsL.Text;

            // Validation
            if (Lid == "")
            {
                lbl_loadsearch_error.Text = "Please enter the LoadID Which you're desired to Update..!";
            }
            else
            {
                //Update Load to database
                LoadID = int.Parse(cmbox_jobid.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update load set JobID ='" + LJobID + "', CustomerName ='" + LCname + "', Lorry='" + Lorry + "', Driver='" + Driver + "', Assistant='" + Assistant + "', Container='" + Container + "', Products='" + Lproducts + "' where LoadID= '" + LoadID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Load Details has been Updated Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_loads();
                Clear_txtboxes();
                cmbox_loadidselect.Items.Clear();
                fillloadcombo();
            }
        }

        private void btn_delete_load_Click(object sender, EventArgs e)
        {
            lbl_loadsearch_error.Text = "";

            // Read form value
            int LoadID;
            String Lid = cmbox_loadidselect.Text;
            String LJobID = cmbox_jobid.Text;


            //Validation
            if (cmbox_loadidselect.Text == "")
            {
                lbl_loadsearch_error.Text = "Please enter the LoadID Which you're desired to Delete..!";
            }
            else
            {
                // Delete Load from database
                LoadID = int.Parse(cmbox_loadidselect.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete load where LoadID= '" + LoadID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Load Details has been deleted Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_loads();
                Clear_txtboxes();
                cmbox_loadidselect.Items.Clear();
                fillloadcombo();
            }
        }

        private void btn_clear_load_Click(object sender, EventArgs e)
        {

            Clear_txtboxes();
            Load_loads();
            
            // Empty error labels
            lbl_loadsearch_error.Text = "";
            lbl_loadcreate_error.Text = "";
            lbl_jobid_error.Text = "";
        }

        private void Clear_txtboxes()
        {
            cmbox_loadidselect.Text = "";
            txtbox_productsL.Text = "";
            cmbox_lorry.Text = "";
            cmbox_driver.Text = "";
            cmbox_assistant.Text = "";
            cmbox_container.Text = "";
            cmbox_jobid.Text = "";
            txtbox_custname.Text = "";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_loadsearch_error.Text = "";

            // Read form value
            int LoadID;
            String Lid = cmbox_loadidselect.Text;
            Load_loads();

            //Validation
            if (Lid == "")
            {
                lbl_loadsearch_error.Text = "This field is required !";
                Clear_txtboxes();
            }
            else
            {
                LoadID = int.Parse(cmbox_loadidselect.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from load where LoadID = '" + LoadID + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_aloads.DataSource = dt;

                cmbox_jobid.Text = dt.Rows[0][1].ToString();
                txtbox_custname.Text = dt.Rows[0][2].ToString();
                cmbox_lorry.Text = dt.Rows[0][3].ToString();
                cmbox_driver.Text = dt.Rows[0][4].ToString();
                cmbox_container.Text = dt.Rows[0][5].ToString();
                cmbox_assistant.Text = dt.Rows[0][6].ToString();
                txtbox_productsL.Text = dt.Rows[0][7].ToString();
            }
        }

        private void btn_jobidsearchinload_Click(object sender, EventArgs e)
        {
            lbl_jobid_error.Text = "";

            // Read form value
            int Jobid;
            String Jid = cmbox_jobid.Text;
            Load_loads();

            //Validation
            if (Jid == "")
            {
                lbl_jobid_error.Text = "This field is required !";

            }
            else
            {
                Jobid = int.Parse(cmbox_jobid.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from selected_products where JobID ='" + Jobid + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_selectedproductsinload.DataSource = dt;

                // Fill TextBox from Selected products table
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("select ProductName from selected_products where JobID ='" + Jobid + "'", con);
                da1.Fill(dt1);
                List<string> lines = new List<string>();
                foreach (DataRow dr in dt1.Rows)
                {
                    lines.Add((string)dr["ProductName"]+","+" ");
                }
                txtbox_productsL.Lines = lines.ToArray();

                // Fill the Username Textbox
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("select CustomerName from Jobs where JobID = '" +Jobid+ "'", con);
                da2.Fill(dt2);

                txtbox_custname.Text = dt2.Rows[0][0].ToString();

            }
        }

        private void dgv_selectedproductsinload_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> lines = new List<string>();
            if (e.RowIndex >=0) // to disable the rpw and column headers
             {

                 lines.Add((string)dgv_selectedproductsinload.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

             }
            txtbox_productsL.Lines = lines.ToArray();
        }

    }
}
