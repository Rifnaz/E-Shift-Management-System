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
    public partial class frmAdminProducts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminProducts()
        {
            InitializeComponent();

            // Empty error labels
            Clear_labels();

        }

        private void frmAdminProducts_Load(object sender, EventArgs e)
        {
            // Check the connection Status & close/Open it
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Load_Products();

            // Fill Items to Customer Name to combobox
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select ProductID from products", con);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cmbox_productidsearch.Items.Add(dr["ProductID"].ToString());
            }
        }

        public void Load_Products()
        {
            // Load Products to Admin dgv
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_aproducts.DataSource = dt;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // Read form values
            String ProName = txtbox_prorname.Text;
            String PMade = txtbox_made.Text;
            String Quantity = txtbox_quantity.Text;

            // Empty error labels
            Clear_labels();

            // Validations

            if (ProName == "" || PMade == "" || Quantity == "")
            {
                lbl_createproduct_error.Text = "All fields are required !";
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into products (ProductName, Made, Quantity) values('" + ProName + "', '" + PMade + "', '" + Quantity + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product has been created Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_Products();
                Clear_txtbox();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Read form values
            int ProductID;
            String Proid = cmbox_productidsearch.Text;
            String ProName = txtbox_prorname.Text;
            String PMade = txtbox_made.Text;
            String Quantity = txtbox_quantity.Text;

            Clear_labels();

            // Validation
            if (Proid == "")
            {
                lbl_productsearch_error.Text = "Please enter the ProductID Which you're desired to Update..!";
            }
            if (ProName == "" || PMade == "" || Quantity == "")
            {
                lbl_createproduct_error.Text = "All fields are required !";
            }
            else
            {
                //Update Products to database
                ProductID = int.Parse(cmbox_productidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update products set ProductName ='" + ProName + "', Made='" + PMade + "', Quantity='" + Quantity + "' where ProductID= '" + ProductID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details has been Updated Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_Products();
                Clear_txtbox();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Read form value
            int ProductID;
            String Proid = cmbox_productidsearch.Text;

            Clear_labels();

            //Validation
            if (Proid == "")
            {
                lbl_productsearch_error.Text = "Please enter the ProductID Which you're desired to Delete..!";
            }
            else
            {
                // Delete Load from database
                ProductID = int.Parse(cmbox_productidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete products where ProductID= '" + ProductID + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details has been deleted Successfuly !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_Products();
                Clear_txtbox();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Load_Products();
            Clear_txtbox();
            Clear_labels();
        }

        private void Clear_txtbox()
        {
            txtbox_prorname.Text = "";
            txtbox_made.Text = "";
            txtbox_quantity.Text = "";
            cmbox_productidsearch.Text = "";
        }

        private void Clear_labels()
        {
            lbl_createproduct_error.Text = "";
            lbl_productsearch_error.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Read form value
            int ProductID;
            String Proid = cmbox_productidsearch.Text;

            // Empty Label
            Clear_labels();

            //Validation
            if (Proid == "")
            {
                lbl_productsearch_error.Text = "This field is required !";
            }
            else
            {
                ProductID = int.Parse(cmbox_productidsearch.Text);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from products where ProductID = '" + ProductID + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_aproducts.DataSource = dt;

                txtbox_prorname.Text = dt.Rows[0][1].ToString();
                txtbox_made.Text = dt.Rows[0][2].ToString();
                txtbox_quantity.Text = dt.Rows[0][3].ToString();

            }
        }
    }
}
