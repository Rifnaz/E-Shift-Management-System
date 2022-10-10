namespace E_Shift
{
    partial class frmCustomerProfile
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
            this.btn_cpclear = new System.Windows.Forms.Button();
            this.btn_cpupdate = new System.Windows.Forms.Button();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.txtbox_cpconfirm = new System.Windows.Forms.TextBox();
            this.txtbox_cppwd = new System.Windows.Forms.TextBox();
            this.lbl_cpconfirm = new System.Windows.Forms.Label();
            this.lbl_cppassword = new System.Windows.Forms.Label();
            this.txtbox_cpcontact = new System.Windows.Forms.TextBox();
            this.lbl_cpcontact = new System.Windows.Forms.Label();
            this.txtbox_cpemail = new System.Windows.Forms.TextBox();
            this.lbl_cpsemail = new System.Windows.Forms.Label();
            this.txtbox_cpsusername = new System.Windows.Forms.TextBox();
            this.lbl_cpsusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cpuname_error = new System.Windows.Forms.Label();
            this.lbl_cpmail_error = new System.Windows.Forms.Label();
            this.lbl_cpcontactno_error = new System.Windows.Forms.Label();
            this.lbl_cppwd_error = new System.Windows.Forms.Label();
            this.lbl_cpconfirm_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cpclear
            // 
            this.btn_cpclear.BackColor = System.Drawing.Color.White;
            this.btn_cpclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cpclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cpclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_cpclear.Location = new System.Drawing.Point(341, 507);
            this.btn_cpclear.Name = "btn_cpclear";
            this.btn_cpclear.Size = new System.Drawing.Size(219, 35);
            this.btn_cpclear.TabIndex = 66;
            this.btn_cpclear.Text = "CLEAR";
            this.btn_cpclear.UseVisualStyleBackColor = false;
            this.btn_cpclear.Click += new System.EventHandler(this.btn_cpclear_Click);
            // 
            // btn_cpupdate
            // 
            this.btn_cpupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_cpupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cpupdate.FlatAppearance.BorderSize = 0;
            this.btn_cpupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cpupdate.ForeColor = System.Drawing.Color.White;
            this.btn_cpupdate.Location = new System.Drawing.Point(341, 460);
            this.btn_cpupdate.Name = "btn_cpupdate";
            this.btn_cpupdate.Size = new System.Drawing.Size(219, 35);
            this.btn_cpupdate.TabIndex = 65;
            this.btn_cpupdate.Text = "UPDATE";
            this.btn_cpupdate.UseVisualStyleBackColor = false;
            this.btn_cpupdate.Click += new System.EventHandler(this.btn_cpupdate_Click);
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_show_password.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBox_show_password.Location = new System.Drawing.Point(462, 424);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(105, 17);
            this.checkBox_show_password.TabIndex = 64;
            this.checkBox_show_password.Text = "Show Password";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // txtbox_cpconfirm
            // 
            this.txtbox_cpconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cpconfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cpconfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpconfirm.Location = new System.Drawing.Point(341, 390);
            this.txtbox_cpconfirm.Multiline = true;
            this.txtbox_cpconfirm.Name = "txtbox_cpconfirm";
            this.txtbox_cpconfirm.PasswordChar = '•';
            this.txtbox_cpconfirm.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cpconfirm.TabIndex = 63;
            // 
            // txtbox_cppwd
            // 
            this.txtbox_cppwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cppwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cppwd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cppwd.Location = new System.Drawing.Point(341, 318);
            this.txtbox_cppwd.Multiline = true;
            this.txtbox_cppwd.Name = "txtbox_cppwd";
            this.txtbox_cppwd.PasswordChar = '•';
            this.txtbox_cppwd.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cppwd.TabIndex = 62;
            // 
            // lbl_cpconfirm
            // 
            this.lbl_cpconfirm.AutoSize = true;
            this.lbl_cpconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cpconfirm.Location = new System.Drawing.Point(338, 369);
            this.lbl_cpconfirm.Name = "lbl_cpconfirm";
            this.lbl_cpconfirm.Size = new System.Drawing.Size(120, 17);
            this.lbl_cpconfirm.TabIndex = 57;
            this.lbl_cpconfirm.Text = "Confirm Password";
            // 
            // lbl_cppassword
            // 
            this.lbl_cppassword.AutoSize = true;
            this.lbl_cppassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cppassword.Location = new System.Drawing.Point(338, 297);
            this.lbl_cppassword.Name = "lbl_cppassword";
            this.lbl_cppassword.Size = new System.Drawing.Size(66, 17);
            this.lbl_cppassword.TabIndex = 56;
            this.lbl_cppassword.Text = "Password";
            // 
            // txtbox_cpcontact
            // 
            this.txtbox_cpcontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cpcontact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cpcontact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpcontact.Location = new System.Drawing.Point(341, 248);
            this.txtbox_cpcontact.Multiline = true;
            this.txtbox_cpcontact.Name = "txtbox_cpcontact";
            this.txtbox_cpcontact.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cpcontact.TabIndex = 61;
            // 
            // lbl_cpcontact
            // 
            this.lbl_cpcontact.AutoSize = true;
            this.lbl_cpcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cpcontact.Location = new System.Drawing.Point(338, 227);
            this.lbl_cpcontact.Name = "lbl_cpcontact";
            this.lbl_cpcontact.Size = new System.Drawing.Size(77, 17);
            this.lbl_cpcontact.TabIndex = 55;
            this.lbl_cpcontact.Text = "Contact No";
            // 
            // txtbox_cpemail
            // 
            this.txtbox_cpemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cpemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cpemail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpemail.Location = new System.Drawing.Point(341, 178);
            this.txtbox_cpemail.Multiline = true;
            this.txtbox_cpemail.Name = "txtbox_cpemail";
            this.txtbox_cpemail.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cpemail.TabIndex = 60;
            // 
            // lbl_cpsemail
            // 
            this.lbl_cpsemail.AutoSize = true;
            this.lbl_cpsemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cpsemail.Location = new System.Drawing.Point(338, 157);
            this.lbl_cpsemail.Name = "lbl_cpsemail";
            this.lbl_cpsemail.Size = new System.Drawing.Size(42, 17);
            this.lbl_cpsemail.TabIndex = 54;
            this.lbl_cpsemail.Text = "Email";
            // 
            // txtbox_cpsusername
            // 
            this.txtbox_cpsusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cpsusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cpsusername.Enabled = false;
            this.txtbox_cpsusername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpsusername.Location = new System.Drawing.Point(341, 110);
            this.txtbox_cpsusername.Multiline = true;
            this.txtbox_cpsusername.Name = "txtbox_cpsusername";
            this.txtbox_cpsusername.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cpsusername.TabIndex = 59;
            // 
            // lbl_cpsusername
            // 
            this.lbl_cpsusername.AutoSize = true;
            this.lbl_cpsusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cpsusername.Location = new System.Drawing.Point(338, 89);
            this.lbl_cpsusername.Name = "lbl_cpsusername";
            this.lbl_cpsusername.Size = new System.Drawing.Size(69, 17);
            this.lbl_cpsusername.TabIndex = 58;
            this.lbl_cpsusername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer Profile";
            // 
            // lbl_cpuname_error
            // 
            this.lbl_cpuname_error.AutoSize = true;
            this.lbl_cpuname_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpuname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpuname_error.Location = new System.Drawing.Point(339, 140);
            this.lbl_cpuname_error.Name = "lbl_cpuname_error";
            this.lbl_cpuname_error.Size = new System.Drawing.Size(73, 12);
            this.lbl_cpuname_error.TabIndex = 67;
            this.lbl_cpuname_error.Text = "Error Username";
            // 
            // lbl_cpmail_error
            // 
            this.lbl_cpmail_error.AutoSize = true;
            this.lbl_cpmail_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpmail_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpmail_error.Location = new System.Drawing.Point(339, 208);
            this.lbl_cpmail_error.Name = "lbl_cpmail_error";
            this.lbl_cpmail_error.Size = new System.Drawing.Size(54, 12);
            this.lbl_cpmail_error.TabIndex = 68;
            this.lbl_cpmail_error.Text = "Error Email";
            // 
            // lbl_cpcontactno_error
            // 
            this.lbl_cpcontactno_error.AutoSize = true;
            this.lbl_cpcontactno_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpcontactno_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpcontactno_error.Location = new System.Drawing.Point(339, 278);
            this.lbl_cpcontactno_error.Name = "lbl_cpcontactno_error";
            this.lbl_cpcontactno_error.Size = new System.Drawing.Size(64, 12);
            this.lbl_cpcontactno_error.TabIndex = 69;
            this.lbl_cpcontactno_error.Text = "Error Contact";
            // 
            // lbl_cppwd_error
            // 
            this.lbl_cppwd_error.AutoSize = true;
            this.lbl_cppwd_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cppwd_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cppwd_error.Location = new System.Drawing.Point(339, 348);
            this.lbl_cppwd_error.Name = "lbl_cppwd_error";
            this.lbl_cppwd_error.Size = new System.Drawing.Size(72, 12);
            this.lbl_cppwd_error.TabIndex = 70;
            this.lbl_cppwd_error.Text = "Error Password";
            // 
            // lbl_cpconfirm_error
            // 
            this.lbl_cpconfirm_error.AutoSize = true;
            this.lbl_cpconfirm_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpconfirm_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpconfirm_error.Location = new System.Drawing.Point(339, 420);
            this.lbl_cpconfirm_error.Name = "lbl_cpconfirm_error";
            this.lbl_cpconfirm_error.Size = new System.Drawing.Size(65, 12);
            this.lbl_cpconfirm_error.TabIndex = 71;
            this.lbl_cpconfirm_error.Text = "Error Confirm";
            // 
            // frmCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.lbl_cpconfirm_error);
            this.Controls.Add(this.lbl_cppwd_error);
            this.Controls.Add(this.lbl_cpcontactno_error);
            this.Controls.Add(this.lbl_cpmail_error);
            this.Controls.Add(this.lbl_cpuname_error);
            this.Controls.Add(this.btn_cpclear);
            this.Controls.Add(this.btn_cpupdate);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(this.txtbox_cpconfirm);
            this.Controls.Add(this.txtbox_cppwd);
            this.Controls.Add(this.lbl_cpconfirm);
            this.Controls.Add(this.lbl_cppassword);
            this.Controls.Add(this.txtbox_cpcontact);
            this.Controls.Add(this.lbl_cpcontact);
            this.Controls.Add(this.txtbox_cpemail);
            this.Controls.Add(this.lbl_cpsemail);
            this.Controls.Add(this.txtbox_cpsusername);
            this.Controls.Add(this.lbl_cpsusername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerProfile";
            this.Text = "frmCustomerProfile";
            this.Load += new System.EventHandler(this.frmCustomerProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cpclear;
        private System.Windows.Forms.Button btn_cpupdate;
        private System.Windows.Forms.CheckBox checkBox_show_password;
        private System.Windows.Forms.TextBox txtbox_cpconfirm;
        private System.Windows.Forms.TextBox txtbox_cppwd;
        private System.Windows.Forms.Label lbl_cpconfirm;
        private System.Windows.Forms.Label lbl_cppassword;
        private System.Windows.Forms.TextBox txtbox_cpcontact;
        private System.Windows.Forms.Label lbl_cpcontact;
        private System.Windows.Forms.TextBox txtbox_cpemail;
        private System.Windows.Forms.Label lbl_cpsemail;
        private System.Windows.Forms.TextBox txtbox_cpsusername;
        private System.Windows.Forms.Label lbl_cpsusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cpuname_error;
        private System.Windows.Forms.Label lbl_cpmail_error;
        private System.Windows.Forms.Label lbl_cpcontactno_error;
        private System.Windows.Forms.Label lbl_cppwd_error;
        private System.Windows.Forms.Label lbl_cpconfirm_error;
    }
}