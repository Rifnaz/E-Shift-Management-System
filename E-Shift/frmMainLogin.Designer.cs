namespace E_Shift
{
    partial class frmMainLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbtn_admin = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbtn_admin);
            this.panel1.Controls.Add(this.gbtn_customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 40);
            this.panel1.TabIndex = 0;
            // 
            // gbtn_admin
            // 
            this.gbtn_admin.BackColor = System.Drawing.Color.White;
            this.gbtn_admin.BorderColor = System.Drawing.Color.Empty;
            this.gbtn_admin.BorderThickness = 2;
            this.gbtn_admin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_admin.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.gbtn_admin.CheckedState.FillColor = System.Drawing.Color.White;
            this.gbtn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_admin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.gbtn_admin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gbtn_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_admin.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbtn_admin.FillColor = System.Drawing.Color.White;
            this.gbtn_admin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.gbtn_admin.Location = new System.Drawing.Point(149, 0);
            this.gbtn_admin.Name = "gbtn_admin";
            this.gbtn_admin.Size = new System.Drawing.Size(149, 40);
            this.gbtn_admin.TabIndex = 1;
            this.gbtn_admin.Text = "Admin";
            this.gbtn_admin.Click += new System.EventHandler(this.gbtn_admin_Click);
            // 
            // gbtn_customer
            // 
            this.gbtn_customer.BackColor = System.Drawing.Color.White;
            this.gbtn_customer.BorderColor = System.Drawing.Color.Empty;
            this.gbtn_customer.BorderThickness = 2;
            this.gbtn_customer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_customer.Checked = true;
            this.gbtn_customer.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.gbtn_customer.CheckedState.FillColor = System.Drawing.Color.White;
            this.gbtn_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_customer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.gbtn_customer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gbtn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbtn_customer.FillColor = System.Drawing.Color.White;
            this.gbtn_customer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.gbtn_customer.Location = new System.Drawing.Point(0, 0);
            this.gbtn_customer.Name = "gbtn_customer";
            this.gbtn_customer.Size = new System.Drawing.Size(149, 40);
            this.gbtn_customer.TabIndex = 0;
            this.gbtn_customer.Text = "Customer";
            this.gbtn_customer.Click += new System.EventHandler(this.gbtn_customer_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 40);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(298, 450);
            this.pnl_main.TabIndex = 1;
            // 
            // frmMainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 490);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Login";
            this.Load += new System.EventHandler(this.frmMainLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_main;
        private Guna.UI2.WinForms.Guna2Button gbtn_customer;
        private Guna.UI2.WinForms.Guna2Button gbtn_admin;
    }
}