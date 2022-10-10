namespace E_Shift
{
    partial class frmAdminLogin
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
            this.btn_Acancel = new System.Windows.Forms.Button();
            this.btn_ALogin = new System.Windows.Forms.Button();
            this.checkBox_Ashow_password = new System.Windows.Forms.CheckBox();
            this.txtbox_Apassword = new System.Windows.Forms.TextBox();
            this.lbl_Apassword = new System.Windows.Forms.Label();
            this.txtbox_Ausername = new System.Windows.Forms.TextBox();
            this.lbl_Ausername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_auname_error = new System.Windows.Forms.Label();
            this.lbl_apwd_error = new System.Windows.Forms.Label();
            this.lbl_admin_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Acancel
            // 
            this.btn_Acancel.BackColor = System.Drawing.Color.White;
            this.btn_Acancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Acancel.Location = new System.Drawing.Point(40, 320);
            this.btn_Acancel.Name = "btn_Acancel";
            this.btn_Acancel.Size = new System.Drawing.Size(219, 35);
            this.btn_Acancel.TabIndex = 28;
            this.btn_Acancel.Text = "CANCEL";
            this.btn_Acancel.UseVisualStyleBackColor = false;
            this.btn_Acancel.Click += new System.EventHandler(this.btn_Acancel_Click);
            // 
            // btn_ALogin
            // 
            this.btn_ALogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ALogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ALogin.FlatAppearance.BorderSize = 0;
            this.btn_ALogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ALogin.ForeColor = System.Drawing.Color.White;
            this.btn_ALogin.Location = new System.Drawing.Point(40, 273);
            this.btn_ALogin.Name = "btn_ALogin";
            this.btn_ALogin.Size = new System.Drawing.Size(219, 35);
            this.btn_ALogin.TabIndex = 29;
            this.btn_ALogin.Text = "LOGIN";
            this.btn_ALogin.UseVisualStyleBackColor = false;
            this.btn_ALogin.Click += new System.EventHandler(this.btn_ALogin_Click);
            // 
            // checkBox_Ashow_password
            // 
            this.checkBox_Ashow_password.AutoSize = true;
            this.checkBox_Ashow_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Ashow_password.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Ashow_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBox_Ashow_password.Location = new System.Drawing.Point(159, 237);
            this.checkBox_Ashow_password.Name = "checkBox_Ashow_password";
            this.checkBox_Ashow_password.Size = new System.Drawing.Size(105, 17);
            this.checkBox_Ashow_password.TabIndex = 27;
            this.checkBox_Ashow_password.Text = "Show Password";
            this.checkBox_Ashow_password.UseVisualStyleBackColor = true;
            this.checkBox_Ashow_password.CheckedChanged += new System.EventHandler(this.checkBox_Ashow_password_CheckedChanged);
            // 
            // txtbox_Apassword
            // 
            this.txtbox_Apassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_Apassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Apassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Apassword.Location = new System.Drawing.Point(40, 205);
            this.txtbox_Apassword.Multiline = true;
            this.txtbox_Apassword.Name = "txtbox_Apassword";
            this.txtbox_Apassword.PasswordChar = '•';
            this.txtbox_Apassword.Size = new System.Drawing.Size(219, 27);
            this.txtbox_Apassword.TabIndex = 25;
            // 
            // lbl_Apassword
            // 
            this.lbl_Apassword.AutoSize = true;
            this.lbl_Apassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Apassword.Location = new System.Drawing.Point(37, 184);
            this.lbl_Apassword.Name = "lbl_Apassword";
            this.lbl_Apassword.Size = new System.Drawing.Size(66, 17);
            this.lbl_Apassword.TabIndex = 23;
            this.lbl_Apassword.Text = "Password";
            // 
            // txtbox_Ausername
            // 
            this.txtbox_Ausername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_Ausername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Ausername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Ausername.Location = new System.Drawing.Point(40, 137);
            this.txtbox_Ausername.Multiline = true;
            this.txtbox_Ausername.Name = "txtbox_Ausername";
            this.txtbox_Ausername.Size = new System.Drawing.Size(219, 27);
            this.txtbox_Ausername.TabIndex = 26;
            // 
            // lbl_Ausername
            // 
            this.lbl_Ausername.AutoSize = true;
            this.lbl_Ausername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_Ausername.Location = new System.Drawing.Point(37, 116);
            this.lbl_Ausername.Name = "lbl_Ausername";
            this.lbl_Ausername.Size = new System.Drawing.Size(69, 17);
            this.lbl_Ausername.TabIndex = 24;
            this.lbl_Ausername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(68, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Enter Username and Password";
            // 
            // lbl_auname_error
            // 
            this.lbl_auname_error.AutoSize = true;
            this.lbl_auname_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_auname_error.Location = new System.Drawing.Point(40, 167);
            this.lbl_auname_error.Name = "lbl_auname_error";
            this.lbl_auname_error.Size = new System.Drawing.Size(73, 12);
            this.lbl_auname_error.TabIndex = 32;
            this.lbl_auname_error.Text = "Error Username";
            // 
            // lbl_apwd_error
            // 
            this.lbl_apwd_error.AutoSize = true;
            this.lbl_apwd_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apwd_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_apwd_error.Location = new System.Drawing.Point(38, 235);
            this.lbl_apwd_error.Name = "lbl_apwd_error";
            this.lbl_apwd_error.Size = new System.Drawing.Size(72, 12);
            this.lbl_apwd_error.TabIndex = 32;
            this.lbl_apwd_error.Text = "Error Password";
            // 
            // lbl_admin_error
            // 
            this.lbl_admin_error.AutoSize = true;
            this.lbl_admin_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_admin_error.Location = new System.Drawing.Point(12, 9);
            this.lbl_admin_error.Name = "lbl_admin_error";
            this.lbl_admin_error.Size = new System.Drawing.Size(60, 12);
            this.lbl_admin_error.TabIndex = 32;
            this.lbl_admin_error.Text = "Error Invalid";
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.lbl_admin_error);
            this.Controls.Add(this.lbl_apwd_error);
            this.Controls.Add(this.lbl_auname_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Acancel);
            this.Controls.Add(this.btn_ALogin);
            this.Controls.Add(this.checkBox_Ashow_password);
            this.Controls.Add(this.txtbox_Apassword);
            this.Controls.Add(this.lbl_Apassword);
            this.Controls.Add(this.txtbox_Ausername);
            this.Controls.Add(this.lbl_Ausername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Acancel;
        private System.Windows.Forms.Button btn_ALogin;
        private System.Windows.Forms.CheckBox checkBox_Ashow_password;
        private System.Windows.Forms.TextBox txtbox_Apassword;
        private System.Windows.Forms.Label lbl_Apassword;
        private System.Windows.Forms.TextBox txtbox_Ausername;
        private System.Windows.Forms.Label lbl_Ausername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_auname_error;
        private System.Windows.Forms.Label lbl_apwd_error;
        private System.Windows.Forms.Label lbl_admin_error;
    }
}