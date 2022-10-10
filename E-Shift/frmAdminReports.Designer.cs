namespace E_Shift
{
    partial class frmAdminReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rusername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_jobsreport = new System.Windows.Forms.ComboBox();
            this.btn_jobgen = new System.Windows.Forms.Button();
            this.btn_loadgen = new System.Windows.Forms.Button();
            this.cmbox_loadreport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_progen = new System.Windows.Forms.Button();
            this.cmbox_productreport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Reports";
            // 
            // lbl_rusername
            // 
            this.lbl_rusername.AutoSize = true;
            this.lbl_rusername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_rusername.Location = new System.Drawing.Point(31, 124);
            this.lbl_rusername.Name = "lbl_rusername";
            this.lbl_rusername.Size = new System.Drawing.Size(161, 21);
            this.lbl_rusername.TabIndex = 36;
            this.lbl_rusername.Text = "E-Shift Jobs Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(34, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status";
            // 
            // cmbox_jobsreport
            // 
            this.cmbox_jobsreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_jobsreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_jobsreport.FormattingEnabled = true;
            this.cmbox_jobsreport.Items.AddRange(new object[] {
            "All"});
            this.cmbox_jobsreport.Location = new System.Drawing.Point(86, 165);
            this.cmbox_jobsreport.Name = "cmbox_jobsreport";
            this.cmbox_jobsreport.Size = new System.Drawing.Size(120, 25);
            this.cmbox_jobsreport.TabIndex = 133;
            // 
            // btn_jobgen
            // 
            this.btn_jobgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_jobgen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jobgen.FlatAppearance.BorderSize = 0;
            this.btn_jobgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jobgen.ForeColor = System.Drawing.Color.White;
            this.btn_jobgen.Location = new System.Drawing.Point(217, 161);
            this.btn_jobgen.Name = "btn_jobgen";
            this.btn_jobgen.Size = new System.Drawing.Size(90, 30);
            this.btn_jobgen.TabIndex = 134;
            this.btn_jobgen.Text = "GENERATE";
            this.btn_jobgen.UseVisualStyleBackColor = false;
            this.btn_jobgen.Click += new System.EventHandler(this.btn_jobgen_Click);
            // 
            // btn_loadgen
            // 
            this.btn_loadgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_loadgen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadgen.FlatAppearance.BorderSize = 0;
            this.btn_loadgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadgen.ForeColor = System.Drawing.Color.White;
            this.btn_loadgen.Location = new System.Drawing.Point(219, 318);
            this.btn_loadgen.Name = "btn_loadgen";
            this.btn_loadgen.Size = new System.Drawing.Size(90, 30);
            this.btn_loadgen.TabIndex = 138;
            this.btn_loadgen.Text = "GENERATE";
            this.btn_loadgen.UseVisualStyleBackColor = false;
            this.btn_loadgen.Click += new System.EventHandler(this.btn_loadgen_Click);
            // 
            // cmbox_loadreport
            // 
            this.cmbox_loadreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_loadreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_loadreport.FormattingEnabled = true;
            this.cmbox_loadreport.Items.AddRange(new object[] {
            "All"});
            this.cmbox_loadreport.Location = new System.Drawing.Point(88, 322);
            this.cmbox_loadreport.Name = "cmbox_loadreport";
            this.cmbox_loadreport.Size = new System.Drawing.Size(120, 25);
            this.cmbox_loadreport.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(36, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(33, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 135;
            this.label4.Text = "E-Shift Load Reports";
            // 
            // btn_progen
            // 
            this.btn_progen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_progen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_progen.FlatAppearance.BorderSize = 0;
            this.btn_progen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_progen.ForeColor = System.Drawing.Color.White;
            this.btn_progen.Location = new System.Drawing.Point(219, 471);
            this.btn_progen.Name = "btn_progen";
            this.btn_progen.Size = new System.Drawing.Size(90, 30);
            this.btn_progen.TabIndex = 142;
            this.btn_progen.Text = "GENERATE";
            this.btn_progen.UseVisualStyleBackColor = false;
            this.btn_progen.Click += new System.EventHandler(this.btn_progen_Click);
            // 
            // cmbox_productreport
            // 
            this.cmbox_productreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_productreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_productreport.FormattingEnabled = true;
            this.cmbox_productreport.Items.AddRange(new object[] {
            "All"});
            this.cmbox_productreport.Location = new System.Drawing.Point(88, 475);
            this.cmbox_productreport.Name = "cmbox_productreport";
            this.cmbox_productreport.Size = new System.Drawing.Size(120, 25);
            this.cmbox_productreport.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(36, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 140;
            this.label5.Text = "Made";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(33, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 139;
            this.label6.Text = "E-Shift Products  Reports";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(338, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(533, 480);
            this.reportViewer1.TabIndex = 143;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmAdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_progen);
            this.Controls.Add(this.cmbox_productreport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_loadgen);
            this.Controls.Add(this.cmbox_loadreport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_jobgen);
            this.Controls.Add(this.cmbox_jobsreport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rusername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminReports";
            this.Text = "frmAdminReports";
            this.Load += new System.EventHandler(this.frmAdminReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_jobsreport;
        private System.Windows.Forms.Button btn_jobgen;
        private System.Windows.Forms.Button btn_loadgen;
        private System.Windows.Forms.ComboBox cmbox_loadreport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_progen;
        private System.Windows.Forms.ComboBox cmbox_productreport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}