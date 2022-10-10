namespace E_Shift
{
    partial class frmCustomerLogin
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
            this.lbl_createAccount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ccancel = new System.Windows.Forms.Button();
            this.btn_CLogin = new System.Windows.Forms.Button();
            this.checkBox_Cshow_password = new System.Windows.Forms.CheckBox();
            this.txtbox_Cpassword = new System.Windows.Forms.TextBox();
            this.lbl_Cpassword = new System.Windows.Forms.Label();
            this.txtbox_Cusername = new System.Windows.Forms.TextBox();
            this.lbl_Cusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_customer_error = new System.Windows.Forms.Label();
            this.lbl_cpwd_error = new System.Windows.Forms.Label();
            this.lbl_cuname_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_createAccount
            // 
            this.lbl_createAccount.AutoSize = true;
            this.lbl_createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_createAccount.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbl_createAccount.Location = new System.Drawing.Point(106, 385);
            this.lbl_createAccount.Name = "lbl_createAccount";
            this.lbl_createAccount.Size = new System.Drawing.Size(86, 13);
            this.lbl_createAccount.TabIndex = 20;
            this.lbl_createAccount.Text = "Create Account";
            this.lbl_createAccount.Click += new System.EventHandler(this.lbl_createAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(86, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Don\'t Have an Account";
            // 
            // btn_Ccancel
            // 
            this.btn_Ccancel.BackColor = System.Drawing.Color.White;
            this.btn_Ccancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ccancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ccancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Ccancel.Location = new System.Drawing.Point(40, 320);
            this.btn_Ccancel.Name = "btn_Ccancel";
            this.btn_Ccancel.Size = new System.Drawing.Size(219, 35);
            this.btn_Ccancel.TabIndex = 18;
            this.btn_Ccancel.Text = "CANCEL";
            this.btn_Ccancel.UseVisualStyleBackColor = false;
            this.btn_Ccancel.Click += new System.EventHandler(this.btn_Ccancel_Click);
            // 
            // btn_CLogin
            // 
            this.btn_CLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_CLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CLogin.FlatAppearance.BorderSize = 0;
            this.btn_CLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLogin.ForeColor = System.Drawing.Color.White;
            this.btn_CLogin.Location = new System.Drawing.Point(40, 273);
            this.btn_CLogin.Name = "btn_CLogin";
            this.btn_CLogin.Size = new System.Drawing.Size(219, 35);
            this.btn_CLogin.TabIndex = 19;
            this.btn_CLogin.Text = "LOGIN";
            this.btn_CLogin.UseVisualStyleBackColor = false;
            this.btn_CLogin.Click += new System.EventHandler(this.btn_CLogin_Click);
            // 
            // checkBox_Cshow_password
            // 
            this.checkBox_Cshow_password.AutoSize = true;
            this.checkBox_Cshow_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Cshow_password.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cshow_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBox_Cshow_password.Location = new System.Drawing.Point(159, 237);
            this.checkBox_Cshow_password.Name = "checkBox_Cshow_password";
            this.checkBox_Cshow_password.Size = new System.Drawing.Size(105, 17);
            this.checkBox_Cshow_password.TabIndex = 17;
            this.checkBox_Cshow_password.Text = "Show Password";
            this.checkBox_Cshow_password.UseVisualStyleBackColor = true;
            this.checkBox_Cshow_password.CheckedChanged += new System.EventHandler(this.checkBox_Cshow_password_CheckedChanged);
            // 
            // txtbox_Cpassword
            // 
            this.txtbox_Cpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_Cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Cpassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Cpassword.Location = new System.Drawing.Point(40, 205);
            this.txtbox_Cpassword.Multiline = true;
            this.txtbox_Cpassword.Name = "txtbox_Cpassword";
            this.txtbox_Cpassword.PasswordChar = '•';
            this.txtbox_Cpassword.Size = new System.Drawing.Size(219, 27);
            this.txtbox_Cpassword.TabIndex = 15;
            // 
            // lbl_Cpassword
            // 
            this.lbl_Cpassword.AutoSize = true;
            this.lbl_Cpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Cpassword.Location = new System.Drawing.Point(37, 184);
            this.lbl_Cpassword.Name = "lbl_Cpassword";
            this.lbl_Cpassword.Size = new System.Drawing.Size(66, 17);
            this.lbl_Cpassword.TabIndex = 10;
            this.lbl_Cpassword.Text = "Password";
            // 
            // txtbox_Cusername
            // 
            this.txtbox_Cusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_Cusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Cusername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Cusername.Location = new System.Drawing.Point(40, 137);
            this.txtbox_Cusername.Multiline = true;
            this.txtbox_Cusername.Name = "txtbox_Cusername";
            this.txtbox_Cusername.Size = new System.Drawing.Size(219, 27);
            this.txtbox_Cusername.TabIndex = 16;
            // 
            // lbl_Cusername
            // 
            this.lbl_Cusername.AutoSize = true;
            this.lbl_Cusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Cusername.Location = new System.Drawing.Point(37, 116);
            this.lbl_Cusername.Name = "lbl_Cusername";
            this.lbl_Cusername.Size = new System.Drawing.Size(69, 17);
            this.lbl_Cusername.TabIndex = 11;
            this.lbl_Cusername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer";
            // 
            // lbl_customer_error
            // 
            this.lbl_customer_error.AutoSize = true;
            this.lbl_customer_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_customer_error.Location = new System.Drawing.Point(12, 9);
            this.lbl_customer_error.Name = "lbl_customer_error";
            this.lbl_customer_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_customer_error.TabIndex = 33;
            this.lbl_customer_error.Text = "Cerror Invalid ";
            // 
            // lbl_cpwd_error
            // 
            this.lbl_cpwd_error.AutoSize = true;
            this.lbl_cpwd_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpwd_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpwd_error.Location = new System.Drawing.Point(38, 235);
            this.lbl_cpwd_error.Name = "lbl_cpwd_error";
            this.lbl_cpwd_error.Size = new System.Drawing.Size(78, 12);
            this.lbl_cpwd_error.TabIndex = 34;
            this.lbl_cpwd_error.Text = "Cerror Password";
            // 
            // lbl_cuname_error
            // 
            this.lbl_cuname_error.AutoSize = true;
            this.lbl_cuname_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cuname_error.Location = new System.Drawing.Point(40, 167);
            this.lbl_cuname_error.Name = "lbl_cuname_error";
            this.lbl_cuname_error.Size = new System.Drawing.Size(79, 12);
            this.lbl_cuname_error.TabIndex = 35;
            this.lbl_cuname_error.Text = "Cerror Username";
            // 
            // frmCustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.lbl_customer_error);
            this.Controls.Add(this.lbl_cpwd_error);
            this.Controls.Add(this.lbl_cuname_error);
            this.Controls.Add(this.lbl_createAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Ccancel);
            this.Controls.Add(this.btn_CLogin);
            this.Controls.Add(this.checkBox_Cshow_password);
            this.Controls.Add(this.txtbox_Cpassword);
            this.Controls.Add(this.lbl_Cpassword);
            this.Controls.Add(this.txtbox_Cusername);
            this.Controls.Add(this.lbl_Cusername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_createAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Ccancel;
        private System.Windows.Forms.Button btn_CLogin;
        private System.Windows.Forms.CheckBox checkBox_Cshow_password;
        private System.Windows.Forms.TextBox txtbox_Cpassword;
        private System.Windows.Forms.Label lbl_Cpassword;
        private System.Windows.Forms.TextBox txtbox_Cusername;
        private System.Windows.Forms.Label lbl_Cusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_customer_error;
        private System.Windows.Forms.Label lbl_cpwd_error;
        private System.Windows.Forms.Label lbl_cuname_error;
    }
}