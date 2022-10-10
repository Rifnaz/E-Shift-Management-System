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
using Microsoft.Reporting.WinForms;

namespace E_Shift
{
    public partial class frmAdminReports : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=E-Shift;Integrated Security=True");

        public frmAdminReports()
        {
            InitializeComponent();
        }

        private void frmAdminReports_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();

            // Fill Items to Status combobox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Status from jobs group by Status", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbox_jobsreport.Items.Add(dr["Status"].ToString());
            }

            // Fill Items to Name combobox
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select CustomerName from load group by CustomerName", con);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cmbox_loadreport.Items.Add(dr["CustomerName"].ToString());
            }

            // Fill Items to Made combobox
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select Made from products group by Made", con);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                cmbox_productreport.Items.Add(dr["Made"].ToString());
            }

            this.reportViewer1.RefreshReport();
        }

        private void btn_jobgen_Click(object sender, EventArgs e)
        {
            //Empty Combobox
            cmbox_loadreport.Text = "";
            cmbox_productreport.Text = "";

            if (cmbox_jobsreport.Text == "All")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from jobs", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\ReportJobs.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from jobs where Status ='" + cmbox_jobsreport.Text + "'", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\ReportJobs.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }

        }

        private void btn_loadgen_Click(object sender, EventArgs e)
        {
            //Empty Combobox
            cmbox_jobsreport.Text = "";
            cmbox_productreport.Text = "";

            if (cmbox_loadreport.Text == "All")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from load", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\Reportload.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from load where CustomerName ='" + cmbox_loadreport.Text + "'", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\Reportload.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }

        private void btn_progen_Click(object sender, EventArgs e)
        {
            //Empty Combobox
            cmbox_loadreport.Text = "";
            cmbox_jobsreport.Text = "";

            if (cmbox_productreport.Text == "All")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from products", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\Reportproducts.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from products where Made ='" + cmbox_productreport.Text + "'", con);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\source\repos\E-Shift\E-Shift\Reportproducts.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
