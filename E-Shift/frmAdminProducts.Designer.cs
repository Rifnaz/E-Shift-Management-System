namespace E_Shift
{
    partial class frmAdminProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminProducts));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txtbox_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txtbox_made = new System.Windows.Forms.TextBox();
            this.lbl_made = new System.Windows.Forms.Label();
            this.txtbox_prorname = new System.Windows.Forms.TextBox();
            this.lbl_proname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_aproducts = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_createproduct_error = new System.Windows.Forms.Label();
            this.cmbox_productidsearch = new System.Windows.Forms.ComboBox();
            this.lbl_productsearch_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_clear.Location = new System.Drawing.Point(36, 432);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(219, 35);
            this.btn_clear.TabIndex = 47;
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
            this.btn_create.Location = new System.Drawing.Point(36, 309);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(219, 35);
            this.btn_create.TabIndex = 46;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txtbox_quantity
            // 
            this.txtbox_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_quantity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_quantity.Location = new System.Drawing.Point(36, 260);
            this.txtbox_quantity.Multiline = true;
            this.txtbox_quantity.Name = "txtbox_quantity";
            this.txtbox_quantity.Size = new System.Drawing.Size(53, 27);
            this.txtbox_quantity.TabIndex = 43;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_quantity.Location = new System.Drawing.Point(33, 239);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(62, 17);
            this.lbl_quantity.TabIndex = 37;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txtbox_made
            // 
            this.txtbox_made.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_made.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_made.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_made.Location = new System.Drawing.Point(36, 190);
            this.txtbox_made.Multiline = true;
            this.txtbox_made.Name = "txtbox_made";
            this.txtbox_made.Size = new System.Drawing.Size(219, 27);
            this.txtbox_made.TabIndex = 42;
            // 
            // lbl_made
            // 
            this.lbl_made.AutoSize = true;
            this.lbl_made.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_made.Location = new System.Drawing.Point(33, 169);
            this.lbl_made.Name = "lbl_made";
            this.lbl_made.Size = new System.Drawing.Size(42, 17);
            this.lbl_made.TabIndex = 36;
            this.lbl_made.Text = "Made";
            // 
            // txtbox_prorname
            // 
            this.txtbox_prorname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_prorname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_prorname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_prorname.Location = new System.Drawing.Point(36, 120);
            this.txtbox_prorname.Multiline = true;
            this.txtbox_prorname.Name = "txtbox_prorname";
            this.txtbox_prorname.Size = new System.Drawing.Size(219, 27);
            this.txtbox_prorname.TabIndex = 40;
            // 
            // lbl_proname
            // 
            this.lbl_proname.AutoSize = true;
            this.lbl_proname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_proname.Location = new System.Drawing.Point(33, 99);
            this.lbl_proname.Name = "lbl_proname";
            this.lbl_proname.Size = new System.Drawing.Size(96, 17);
            this.lbl_proname.TabIndex = 39;
            this.lbl_proname.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Products";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(36, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(219, 35);
            this.btn_update.TabIndex = 52;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(36, 391);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(219, 35);
            this.btn_delete.TabIndex = 53;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_aproducts
            // 
            this.dgv_aproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_aproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aproducts.Location = new System.Drawing.Point(261, 99);
            this.dgv_aproducts.Name = "dgv_aproducts";
            this.dgv_aproducts.Size = new System.Drawing.Size(600, 375);
            this.dgv_aproducts.TabIndex = 54;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(833, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 28);
            this.btn_search.TabIndex = 104;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_createproduct_error
            // 
            this.lbl_createproduct_error.AutoSize = true;
            this.lbl_createproduct_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createproduct_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_createproduct_error.Location = new System.Drawing.Point(34, 294);
            this.lbl_createproduct_error.Name = "lbl_createproduct_error";
            this.lbl_createproduct_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_createproduct_error.TabIndex = 105;
            this.lbl_createproduct_error.Text = "Error required";
            // 
            // cmbox_productidsearch
            // 
            this.cmbox_productidsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_productidsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_productidsearch.FormattingEnabled = true;
            this.cmbox_productidsearch.Location = new System.Drawing.Point(608, 68);
            this.cmbox_productidsearch.Name = "cmbox_productidsearch";
            this.cmbox_productidsearch.Size = new System.Drawing.Size(219, 25);
            this.cmbox_productidsearch.TabIndex = 132;
            // 
            // lbl_productsearch_error
            // 
            this.lbl_productsearch_error.AutoSize = true;
            this.lbl_productsearch_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productsearch_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_productsearch_error.Location = new System.Drawing.Point(606, 53);
            this.lbl_productsearch_error.Name = "lbl_productsearch_error";
            this.lbl_productsearch_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_productsearch_error.TabIndex = 133;
            this.lbl_productsearch_error.Text = "Error required";
            // 
            // frmAdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.lbl_productsearch_error);
            this.Controls.Add(this.cmbox_productidsearch);
            this.Controls.Add(this.lbl_createproduct_error);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_aproducts);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txtbox_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txtbox_made);
            this.Controls.Add(this.lbl_made);
            this.Controls.Add(this.txtbox_prorname);
            this.Controls.Add(this.lbl_proname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminProducts";
            this.Text = "frmAdminProducts";
            this.Load += new System.EventHandler(this.frmAdminProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txtbox_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txtbox_made;
        private System.Windows.Forms.Label lbl_made;
        private System.Windows.Forms.TextBox txtbox_prorname;
        private System.Windows.Forms.Label lbl_proname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_aproducts;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_createproduct_error;
        private System.Windows.Forms.ComboBox cmbox_productidsearch;
        private System.Windows.Forms.Label lbl_productsearch_error;
    }
}