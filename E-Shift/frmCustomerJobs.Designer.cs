namespace E_Shift
{
    partial class frmCustomerJobs
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
            this.btn_createjob = new System.Windows.Forms.Button();
            this.txtbox_custname = new System.Windows.Forms.TextBox();
            this.lbl_custname = new System.Windows.Forms.Label();
            this.txtbox_destination = new System.Windows.Forms.TextBox();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.dgv_cjobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cstartlocation = new System.Windows.Forms.Label();
            this.cmbox_slocation = new System.Windows.Forms.ComboBox();
            this.lbl_error_create = new System.Windows.Forms.Label();
            this.btn_deletejob = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_cproductname = new System.Windows.Forms.Label();
            this.lbl_cquantity = new System.Windows.Forms.Label();
            this.txtbox_cquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_error_select = new System.Windows.Forms.Label();
            this.dgv_productsjb = new System.Windows.Forms.DataGridView();
            this.cmbox_jobid = new System.Windows.Forms.ComboBox();
            this.cmbox_products = new System.Windows.Forms.ComboBox();
            this.cmbox_jobidsearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cjobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productsjb)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createjob
            // 
            this.btn_createjob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_createjob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createjob.FlatAppearance.BorderSize = 0;
            this.btn_createjob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createjob.ForeColor = System.Drawing.Color.White;
            this.btn_createjob.Location = new System.Drawing.Point(656, 266);
            this.btn_createjob.Name = "btn_createjob";
            this.btn_createjob.Size = new System.Drawing.Size(219, 35);
            this.btn_createjob.TabIndex = 128;
            this.btn_createjob.Text = "CREATE JOB";
            this.btn_createjob.UseVisualStyleBackColor = false;
            this.btn_createjob.Click += new System.EventHandler(this.btn_createjob_Click);
            // 
            // txtbox_custname
            // 
            this.txtbox_custname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_custname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_custname.Enabled = false;
            this.txtbox_custname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_custname.Location = new System.Drawing.Point(656, 87);
            this.txtbox_custname.Multiline = true;
            this.txtbox_custname.Name = "txtbox_custname";
            this.txtbox_custname.Size = new System.Drawing.Size(219, 27);
            this.txtbox_custname.TabIndex = 125;
            // 
            // lbl_custname
            // 
            this.lbl_custname.AutoSize = true;
            this.lbl_custname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_custname.Location = new System.Drawing.Point(653, 66);
            this.lbl_custname.Name = "lbl_custname";
            this.lbl_custname.Size = new System.Drawing.Size(107, 17);
            this.lbl_custname.TabIndex = 123;
            this.lbl_custname.Text = "Customer Name";
            // 
            // txtbox_destination
            // 
            this.txtbox_destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_destination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_destination.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_destination.Location = new System.Drawing.Point(656, 214);
            this.txtbox_destination.Multiline = true;
            this.txtbox_destination.Name = "txtbox_destination";
            this.txtbox_destination.Size = new System.Drawing.Size(219, 27);
            this.txtbox_destination.TabIndex = 121;
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_destination.Location = new System.Drawing.Point(653, 193);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(80, 17);
            this.lbl_destination.TabIndex = 119;
            this.lbl_destination.Text = "Destination";
            // 
            // dgv_cjobs
            // 
            this.dgv_cjobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cjobs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_cjobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cjobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cjobs.Location = new System.Drawing.Point(38, 77);
            this.dgv_cjobs.Name = "dgv_cjobs";
            this.dgv_cjobs.Size = new System.Drawing.Size(602, 264);
            this.dgv_cjobs.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 111;
            this.label1.Text = "Jobs";
            // 
            // lbl_cstartlocation
            // 
            this.lbl_cstartlocation.AutoSize = true;
            this.lbl_cstartlocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cstartlocation.Location = new System.Drawing.Point(653, 130);
            this.lbl_cstartlocation.Name = "lbl_cstartlocation";
            this.lbl_cstartlocation.Size = new System.Drawing.Size(94, 17);
            this.lbl_cstartlocation.TabIndex = 129;
            this.lbl_cstartlocation.Text = "Start Location";
            // 
            // cmbox_slocation
            // 
            this.cmbox_slocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_slocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_slocation.FormattingEnabled = true;
            this.cmbox_slocation.Items.AddRange(new object[] {
            "Colombo",
            "Kandy",
            "Kurunegala",
            "Gampaha",
            "Galle",
            "Trincomalee",
            "Jaffna",
            "Kegalle",
            "Badulla"});
            this.cmbox_slocation.Location = new System.Drawing.Point(656, 151);
            this.cmbox_slocation.Name = "cmbox_slocation";
            this.cmbox_slocation.Size = new System.Drawing.Size(219, 25);
            this.cmbox_slocation.TabIndex = 131;
            // 
            // lbl_error_create
            // 
            this.lbl_error_create.AutoSize = true;
            this.lbl_error_create.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_create.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_create.Location = new System.Drawing.Point(657, 250);
            this.lbl_error_create.Name = "lbl_error_create";
            this.lbl_error_create.Size = new System.Drawing.Size(63, 12);
            this.lbl_error_create.TabIndex = 136;
            this.lbl_error_create.Text = "Error reqired";
            // 
            // btn_deletejob
            // 
            this.btn_deletejob.BackColor = System.Drawing.Color.White;
            this.btn_deletejob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletejob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletejob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_deletejob.Location = new System.Drawing.Point(656, 306);
            this.btn_deletejob.Name = "btn_deletejob";
            this.btn_deletejob.Size = new System.Drawing.Size(219, 35);
            this.btn_deletejob.TabIndex = 113;
            this.btn_deletejob.Text = "DELETE";
            this.btn_deletejob.UseVisualStyleBackColor = false;
            this.btn_deletejob.Click += new System.EventHandler(this.btn_deletejob_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(656, 529);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(219, 35);
            this.btn_select.TabIndex = 114;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_cproductname
            // 
            this.lbl_cproductname.AutoSize = true;
            this.lbl_cproductname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cproductname.Location = new System.Drawing.Point(653, 415);
            this.lbl_cproductname.Name = "lbl_cproductname";
            this.lbl_cproductname.Size = new System.Drawing.Size(96, 17);
            this.lbl_cproductname.TabIndex = 116;
            this.lbl_cproductname.Text = "Product Name";
            // 
            // lbl_cquantity
            // 
            this.lbl_cquantity.AutoSize = true;
            this.lbl_cquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_cquantity.Location = new System.Drawing.Point(653, 472);
            this.lbl_cquantity.Name = "lbl_cquantity";
            this.lbl_cquantity.Size = new System.Drawing.Size(62, 17);
            this.lbl_cquantity.TabIndex = 115;
            this.lbl_cquantity.Text = "Quantity";
            // 
            // txtbox_cquantity
            // 
            this.txtbox_cquantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_cquantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cquantity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cquantity.Location = new System.Drawing.Point(656, 495);
            this.txtbox_cquantity.Multiline = true;
            this.txtbox_cquantity.Name = "txtbox_cquantity";
            this.txtbox_cquantity.Size = new System.Drawing.Size(53, 27);
            this.txtbox_cquantity.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(653, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 134;
            this.label3.Text = "Job ID";
            // 
            // lbl_error_select
            // 
            this.lbl_error_select.AutoSize = true;
            this.lbl_error_select.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_select.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_select.Location = new System.Drawing.Point(715, 510);
            this.lbl_error_select.Name = "lbl_error_select";
            this.lbl_error_select.Size = new System.Drawing.Size(63, 12);
            this.lbl_error_select.TabIndex = 137;
            this.lbl_error_select.Text = "Error reqired";
            // 
            // dgv_productsjb
            // 
            this.dgv_productsjb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productsjb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_productsjb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productsjb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productsjb.Location = new System.Drawing.Point(38, 355);
            this.dgv_productsjb.Name = "dgv_productsjb";
            this.dgv_productsjb.Size = new System.Drawing.Size(602, 209);
            this.dgv_productsjb.TabIndex = 127;
            // 
            // cmbox_jobid
            // 
            this.cmbox_jobid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_jobid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_jobid.FormattingEnabled = true;
            this.cmbox_jobid.Location = new System.Drawing.Point(656, 377);
            this.cmbox_jobid.Name = "cmbox_jobid";
            this.cmbox_jobid.Size = new System.Drawing.Size(219, 25);
            this.cmbox_jobid.TabIndex = 141;
            // 
            // cmbox_products
            // 
            this.cmbox_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_products.FormattingEnabled = true;
            this.cmbox_products.Location = new System.Drawing.Point(656, 435);
            this.cmbox_products.Name = "cmbox_products";
            this.cmbox_products.Size = new System.Drawing.Size(219, 25);
            this.cmbox_products.TabIndex = 142;
            // 
            // cmbox_jobidsearch
            // 
            this.cmbox_jobidsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_jobidsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_jobidsearch.FormattingEnabled = true;
            this.cmbox_jobidsearch.Location = new System.Drawing.Point(421, 46);
            this.cmbox_jobidsearch.Name = "cmbox_jobidsearch";
            this.cmbox_jobidsearch.Size = new System.Drawing.Size(219, 25);
            this.cmbox_jobidsearch.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(418, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 143;
            this.label2.Text = "Select the  Job ID ";
            // 
            // frmCustomerJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.cmbox_jobidsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_products);
            this.Controls.Add(this.cmbox_jobid);
            this.Controls.Add(this.lbl_error_select);
            this.Controls.Add(this.lbl_error_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbox_slocation);
            this.Controls.Add(this.lbl_cstartlocation);
            this.Controls.Add(this.btn_createjob);
            this.Controls.Add(this.dgv_productsjb);
            this.Controls.Add(this.txtbox_custname);
            this.Controls.Add(this.lbl_custname);
            this.Controls.Add(this.txtbox_destination);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.txtbox_cquantity);
            this.Controls.Add(this.lbl_cquantity);
            this.Controls.Add(this.lbl_cproductname);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_deletejob);
            this.Controls.Add(this.dgv_cjobs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerJobs";
            this.Text = "frmCustomerJobs";
            this.Load += new System.EventHandler(this.frmCustomerJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cjobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productsjb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createjob;
        private System.Windows.Forms.TextBox txtbox_custname;
        private System.Windows.Forms.Label lbl_custname;
        private System.Windows.Forms.TextBox txtbox_destination;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.DataGridView dgv_cjobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cstartlocation;
        private System.Windows.Forms.ComboBox cmbox_slocation;
        private System.Windows.Forms.Label lbl_error_create;
        private System.Windows.Forms.Button btn_deletejob;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lbl_cproductname;
        private System.Windows.Forms.Label lbl_cquantity;
        private System.Windows.Forms.TextBox txtbox_cquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_error_select;
        private System.Windows.Forms.DataGridView dgv_productsjb;
        private System.Windows.Forms.ComboBox cmbox_jobid;
        private System.Windows.Forms.ComboBox cmbox_products;
        private System.Windows.Forms.ComboBox cmbox_jobidsearch;
        private System.Windows.Forms.Label label2;
    }
}