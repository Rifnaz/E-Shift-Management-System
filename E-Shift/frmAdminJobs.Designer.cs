namespace E_Shift
{
    partial class frmAdminJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminJobs));
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ajobs = new System.Windows.Forms.DataGridView();
            this.dgv_selectedproducts = new System.Windows.Forms.DataGridView();
            this.lbl_search_error = new System.Windows.Forms.Label();
            this.cmbox_jobidsearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_sjob = new System.Windows.Forms.ComboBox();
            this.btn_searchjob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ajobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(611, 410);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(219, 35);
            this.btn_accept.TabIndex = 69;
            this.btn_accept.Text = "ACCEPT";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.BackColor = System.Drawing.Color.White;
            this.btn_decline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_decline.Location = new System.Drawing.Point(611, 451);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(219, 35);
            this.btn_decline.TabIndex = 64;
            this.btn_decline.Text = "DECLINE";
            this.btn_decline.UseVisualStyleBackColor = false;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(836, 363);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 28);
            this.btn_search.TabIndex = 63;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "Jobs";
            // 
            // dgv_ajobs
            // 
            this.dgv_ajobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ajobs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_ajobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ajobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ajobs.Location = new System.Drawing.Point(65, 58);
            this.dgv_ajobs.Name = "dgv_ajobs";
            this.dgv_ajobs.Size = new System.Drawing.Size(799, 276);
            this.dgv_ajobs.TabIndex = 71;
            // 
            // dgv_selectedproducts
            // 
            this.dgv_selectedproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_selectedproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_selectedproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_selectedproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectedproducts.Location = new System.Drawing.Point(65, 354);
            this.dgv_selectedproducts.Name = "dgv_selectedproducts";
            this.dgv_selectedproducts.Size = new System.Drawing.Size(528, 197);
            this.dgv_selectedproducts.TabIndex = 72;
            // 
            // lbl_search_error
            // 
            this.lbl_search_error.AutoSize = true;
            this.lbl_search_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_search_error.Location = new System.Drawing.Point(609, 391);
            this.lbl_search_error.Name = "lbl_search_error";
            this.lbl_search_error.Size = new System.Drawing.Size(58, 12);
            this.lbl_search_error.TabIndex = 73;
            this.lbl_search_error.Text = "Error Search";
            // 
            // cmbox_jobidsearch
            // 
            this.cmbox_jobidsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_jobidsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_jobidsearch.FormattingEnabled = true;
            this.cmbox_jobidsearch.Location = new System.Drawing.Point(611, 366);
            this.cmbox_jobidsearch.Name = "cmbox_jobidsearch";
            this.cmbox_jobidsearch.Size = new System.Drawing.Size(219, 25);
            this.cmbox_jobidsearch.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(608, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 146;
            this.label2.Text = "Select the  Job ID ";
            // 
            // cmbox_sjob
            // 
            this.cmbox_sjob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_sjob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_sjob.FormattingEnabled = true;
            this.cmbox_sjob.Location = new System.Drawing.Point(611, 27);
            this.cmbox_sjob.Name = "cmbox_sjob";
            this.cmbox_sjob.Size = new System.Drawing.Size(219, 25);
            this.cmbox_sjob.TabIndex = 148;
            // 
            // btn_searchjob
            // 
            this.btn_searchjob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_searchjob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchjob.BackgroundImage")));
            this.btn_searchjob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchjob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchjob.ForeColor = System.Drawing.Color.White;
            this.btn_searchjob.Location = new System.Drawing.Point(836, 24);
            this.btn_searchjob.Name = "btn_searchjob";
            this.btn_searchjob.Size = new System.Drawing.Size(28, 28);
            this.btn_searchjob.TabIndex = 147;
            this.btn_searchjob.UseVisualStyleBackColor = false;
            this.btn_searchjob.Click += new System.EventHandler(this.btn_searchjob_Click);
            // 
            // frmAdminJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.cmbox_sjob);
            this.Controls.Add(this.btn_searchjob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_jobidsearch);
            this.Controls.Add(this.lbl_search_error);
            this.Controls.Add(this.dgv_selectedproducts);
            this.Controls.Add(this.dgv_ajobs);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminJobs";
            this.Text = "frmAdminJobs";
            this.Load += new System.EventHandler(this.frmAdminJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ajobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_decline;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ajobs;
        private System.Windows.Forms.DataGridView dgv_selectedproducts;
        private System.Windows.Forms.Label lbl_search_error;
        private System.Windows.Forms.ComboBox cmbox_jobidsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_sjob;
        private System.Windows.Forms.Button btn_searchjob;
    }
}