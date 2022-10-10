namespace E_Shift
{
    partial class frmAdminCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCustomer));
            this.txtbox_cdcontact = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txtbox_cdemail = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbox_cdusername = new System.Windows.Forms.TextBox();
            this.lbl_rusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txtbox_cdpwd = new System.Windows.Forms.TextBox();
            this.lbl_rpassword = new System.Windows.Forms.Label();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.txtbox_cdconfirm = new System.Windows.Forms.TextBox();
            this.lbl_rpconfirm = new System.Windows.Forms.Label();
            this.lbl_cdconfirm_error = new System.Windows.Forms.Label();
            this.lbl_cdpwd_error = new System.Windows.Forms.Label();
            this.lbl_cdcontact_error = new System.Windows.Forms.Label();
            this.lbl_cdmail_error = new System.Windows.Forms.Label();
            this.lbl_cduname_error = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_uid_search_error = new System.Windows.Forms.Label();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.cmbox_custidsearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_cdcontact
            // 
            this.txtbox_cdcontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cdcontact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cdcontact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cdcontact.Location = new System.Drawing.Point(28, 216);
            this.txtbox_cdcontact.Multiline = true;
            this.txtbox_cdcontact.Name = "txtbox_cdcontact";
            this.txtbox_cdcontact.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cdcontact.TabIndex = 39;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_contact.Location = new System.Drawing.Point(25, 195);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(77, 17);
            this.lbl_contact.TabIndex = 36;
            this.lbl_contact.Text = "Contact No";
            // 
            // txtbox_cdemail
            // 
            this.txtbox_cdemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cdemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cdemail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cdemail.Location = new System.Drawing.Point(28, 146);
            this.txtbox_cdemail.Multiline = true;
            this.txtbox_cdemail.Name = "txtbox_cdemail";
            this.txtbox_cdemail.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cdemail.TabIndex = 40;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_email.Location = new System.Drawing.Point(25, 125);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 37;
            this.lbl_email.Text = "Email";
            // 
            // txtbox_cdusername
            // 
            this.txtbox_cdusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cdusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cdusername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cdusername.Location = new System.Drawing.Point(28, 78);
            this.txtbox_cdusername.Multiline = true;
            this.txtbox_cdusername.Name = "txtbox_cdusername";
            this.txtbox_cdusername.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cdusername.TabIndex = 41;
            // 
            // lbl_rusername
            // 
            this.lbl_rusername.AutoSize = true;
            this.lbl_rusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_rusername.Location = new System.Drawing.Point(25, 57);
            this.lbl_rusername.Name = "lbl_rusername";
            this.lbl_rusername.Size = new System.Drawing.Size(69, 17);
            this.lbl_rusername.TabIndex = 38;
            this.lbl_rusername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Customer Details";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(28, 495);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(219, 35);
            this.btn_delete.TabIndex = 57;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(28, 454);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(219, 35);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_clear.Location = new System.Drawing.Point(28, 536);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(219, 35);
            this.btn_clear.TabIndex = 55;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(28, 413);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(219, 35);
            this.btn_create.TabIndex = 54;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txtbox_cdpwd
            // 
            this.txtbox_cdpwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cdpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cdpwd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cdpwd.Location = new System.Drawing.Point(28, 283);
            this.txtbox_cdpwd.Multiline = true;
            this.txtbox_cdpwd.Name = "txtbox_cdpwd";
            this.txtbox_cdpwd.PasswordChar = '•';
            this.txtbox_cdpwd.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cdpwd.TabIndex = 59;
            // 
            // lbl_rpassword
            // 
            this.lbl_rpassword.AutoSize = true;
            this.lbl_rpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_rpassword.Location = new System.Drawing.Point(25, 262);
            this.lbl_rpassword.Name = "lbl_rpassword";
            this.lbl_rpassword.Size = new System.Drawing.Size(66, 17);
            this.lbl_rpassword.TabIndex = 58;
            this.lbl_rpassword.Text = "Password";
            // 
            // dgv_customers
            // 
            this.dgv_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(253, 64);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.Size = new System.Drawing.Size(635, 507);
            this.dgv_customers.TabIndex = 60;
            // 
            // txtbox_cdconfirm
            // 
            this.txtbox_cdconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cdconfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cdconfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cdconfirm.Location = new System.Drawing.Point(28, 352);
            this.txtbox_cdconfirm.Multiline = true;
            this.txtbox_cdconfirm.Name = "txtbox_cdconfirm";
            this.txtbox_cdconfirm.PasswordChar = '•';
            this.txtbox_cdconfirm.Size = new System.Drawing.Size(219, 27);
            this.txtbox_cdconfirm.TabIndex = 65;
            // 
            // lbl_rpconfirm
            // 
            this.lbl_rpconfirm.AutoSize = true;
            this.lbl_rpconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_rpconfirm.Location = new System.Drawing.Point(25, 331);
            this.lbl_rpconfirm.Name = "lbl_rpconfirm";
            this.lbl_rpconfirm.Size = new System.Drawing.Size(120, 17);
            this.lbl_rpconfirm.TabIndex = 64;
            this.lbl_rpconfirm.Text = "Confirm Password";
            // 
            // lbl_cdconfirm_error
            // 
            this.lbl_cdconfirm_error.AutoSize = true;
            this.lbl_cdconfirm_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdconfirm_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cdconfirm_error.Location = new System.Drawing.Point(26, 382);
            this.lbl_cdconfirm_error.Name = "lbl_cdconfirm_error";
            this.lbl_cdconfirm_error.Size = new System.Drawing.Size(65, 12);
            this.lbl_cdconfirm_error.TabIndex = 66;
            this.lbl_cdconfirm_error.Text = "Error Confirm";
            // 
            // lbl_cdpwd_error
            // 
            this.lbl_cdpwd_error.AutoSize = true;
            this.lbl_cdpwd_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdpwd_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cdpwd_error.Location = new System.Drawing.Point(26, 313);
            this.lbl_cdpwd_error.Name = "lbl_cdpwd_error";
            this.lbl_cdpwd_error.Size = new System.Drawing.Size(72, 12);
            this.lbl_cdpwd_error.TabIndex = 67;
            this.lbl_cdpwd_error.Text = "Error Password";
            // 
            // lbl_cdcontact_error
            // 
            this.lbl_cdcontact_error.AutoSize = true;
            this.lbl_cdcontact_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdcontact_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cdcontact_error.Location = new System.Drawing.Point(26, 244);
            this.lbl_cdcontact_error.Name = "lbl_cdcontact_error";
            this.lbl_cdcontact_error.Size = new System.Drawing.Size(64, 12);
            this.lbl_cdcontact_error.TabIndex = 68;
            this.lbl_cdcontact_error.Text = "Error Contact";
            // 
            // lbl_cdmail_error
            // 
            this.lbl_cdmail_error.AutoSize = true;
            this.lbl_cdmail_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdmail_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cdmail_error.Location = new System.Drawing.Point(26, 174);
            this.lbl_cdmail_error.Name = "lbl_cdmail_error";
            this.lbl_cdmail_error.Size = new System.Drawing.Size(54, 12);
            this.lbl_cdmail_error.TabIndex = 69;
            this.lbl_cdmail_error.Text = "Error Email";
            // 
            // lbl_cduname_error
            // 
            this.lbl_cduname_error.AutoSize = true;
            this.lbl_cduname_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cduname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_cduname_error.Location = new System.Drawing.Point(26, 106);
            this.lbl_cduname_error.Name = "lbl_cduname_error";
            this.lbl_cduname_error.Size = new System.Drawing.Size(73, 12);
            this.lbl_cduname_error.TabIndex = 70;
            this.lbl_cduname_error.Text = "Error Username";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(860, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 28);
            this.btn_search.TabIndex = 72;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_uid_search_error
            // 
            this.lbl_uid_search_error.AutoSize = true;
            this.lbl_uid_search_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uid_search_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_uid_search_error.Location = new System.Drawing.Point(633, 16);
            this.lbl_uid_search_error.Name = "lbl_uid_search_error";
            this.lbl_uid_search_error.Size = new System.Drawing.Size(58, 12);
            this.lbl_uid_search_error.TabIndex = 73;
            this.lbl_uid_search_error.Text = "Error Search";
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_show_password.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBox_show_password.Location = new System.Drawing.Point(142, 382);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(105, 17);
            this.checkBox_show_password.TabIndex = 74;
            this.checkBox_show_password.Text = "Show Password";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // cmbox_custidsearch
            // 
            this.cmbox_custidsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_custidsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_custidsearch.FormattingEnabled = true;
            this.cmbox_custidsearch.Location = new System.Drawing.Point(635, 33);
            this.cmbox_custidsearch.Name = "cmbox_custidsearch";
            this.cmbox_custidsearch.Size = new System.Drawing.Size(219, 25);
            this.cmbox_custidsearch.TabIndex = 146;
            // 
            // frmAdminCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.cmbox_custidsearch);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(this.lbl_uid_search_error);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_cdconfirm_error);
            this.Controls.Add(this.lbl_cdpwd_error);
            this.Controls.Add(this.lbl_cdcontact_error);
            this.Controls.Add(this.lbl_cdmail_error);
            this.Controls.Add(this.lbl_cduname_error);
            this.Controls.Add(this.txtbox_cdconfirm);
            this.Controls.Add(this.lbl_rpconfirm);
            this.Controls.Add(this.dgv_customers);
            this.Controls.Add(this.txtbox_cdpwd);
            this.Controls.Add(this.lbl_rpassword);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txtbox_cdcontact);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.txtbox_cdemail);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtbox_cdusername);
            this.Controls.Add(this.lbl_rusername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminCustomer";
            this.Text = "frmAdminCustomer";
            this.Load += new System.EventHandler(this.frmAdminCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_cdcontact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txtbox_cdemail;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbox_cdusername;
        private System.Windows.Forms.Label lbl_rusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txtbox_cdpwd;
        private System.Windows.Forms.Label lbl_rpassword;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.TextBox txtbox_cdconfirm;
        private System.Windows.Forms.Label lbl_rpconfirm;
        private System.Windows.Forms.Label lbl_cdconfirm_error;
        private System.Windows.Forms.Label lbl_cdpwd_error;
        private System.Windows.Forms.Label lbl_cdcontact_error;
        private System.Windows.Forms.Label lbl_cdmail_error;
        private System.Windows.Forms.Label lbl_cduname_error;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_uid_search_error;
        private System.Windows.Forms.CheckBox checkBox_show_password;
        private System.Windows.Forms.ComboBox cmbox_custidsearch;
    }
}