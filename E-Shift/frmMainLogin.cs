using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    public partial class frmMainLogin : Form
    {
        public frmMainLogin()
        {
            InitializeComponent();
        }

        private void frmMainLogin_Load(object sender, EventArgs e)
        {
            loadform(new frmCustomerLogin());
        }
        public void loadform(object Form)
        {
            if(this.pnl_main.Controls.Count > 0)
                this.pnl_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(f);
            this.pnl_main.Tag = f;
            f.Show();
        }

        private void gbtn_customer_Click(object sender, EventArgs e)
        {
            loadform(new frmCustomerLogin());
        }

        private void gbtn_admin_Click(object sender, EventArgs e)
        {
            loadform(new frmAdminLogin());
        }
    }
}
