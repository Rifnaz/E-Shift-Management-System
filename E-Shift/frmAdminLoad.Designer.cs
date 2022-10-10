namespace E_Shift
{
    partial class frmAdminLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLoad));
            this.dgv_aloads = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_lorry = new System.Windows.Forms.Label();
            this.lbl_jobID = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.txtbox_productsL = new System.Windows.Forms.TextBox();
            this.lbl_products = new System.Windows.Forms.Label();
            this.lbl_container = new System.Windows.Forms.Label();
            this.lbl_assistant = new System.Windows.Forms.Label();
            this.btn_delete_load = new System.Windows.Forms.Button();
            this.btn_update_load = new System.Windows.Forms.Button();
            this.btn_clear_load = new System.Windows.Forms.Button();
            this.btn_create_load = new System.Windows.Forms.Button();
            this.cmbox_lorry = new System.Windows.Forms.ComboBox();
            this.cmbox_driver = new System.Windows.Forms.ComboBox();
            this.cmbox_assistant = new System.Windows.Forms.ComboBox();
            this.cmbox_container = new System.Windows.Forms.ComboBox();
            this.lbl_loadsearch_error = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_loadcreate_error = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.cmbox_jobid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_loadidselect = new System.Windows.Forms.ComboBox();
            this.dgv_selectedproductsinload = new System.Windows.Forms.DataGridView();
            this.btn_jobidsearchinload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_jobid_error = new System.Windows.Forms.Label();
            this.txtbox_custname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedproductsinload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aloads
            // 
            this.dgv_aloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aloads.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_aloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aloads.Location = new System.Drawing.Point(31, 66);
            this.dgv_aloads.Name = "dgv_aloads";
            this.dgv_aloads.Size = new System.Drawing.Size(611, 282);
            this.dgv_aloads.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 72;
            this.label1.Text = "Loads";
            // 
            // lbl_lorry
            // 
            this.lbl_lorry.AutoSize = true;
            this.lbl_lorry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_lorry.Location = new System.Drawing.Point(28, 498);
            this.lbl_lorry.Name = "lbl_lorry";
            this.lbl_lorry.Size = new System.Drawing.Size(41, 17);
            this.lbl_lorry.TabIndex = 74;
            this.lbl_lorry.Text = "Lorry";
            // 
            // lbl_jobID
            // 
            this.lbl_jobID.AutoSize = true;
            this.lbl_jobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_jobID.Location = new System.Drawing.Point(28, 351);
            this.lbl_jobID.Name = "lbl_jobID";
            this.lbl_jobID.Size = new System.Drawing.Size(48, 17);
            this.lbl_jobID.TabIndex = 75;
            this.lbl_jobID.Text = "Job ID";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_driver.Location = new System.Drawing.Point(335, 351);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(46, 17);
            this.lbl_driver.TabIndex = 80;
            this.lbl_driver.Text = "Driver";
            // 
            // txtbox_productsL
            // 
            this.txtbox_productsL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_productsL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_productsL.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_productsL.Location = new System.Drawing.Point(647, 374);
            this.txtbox_productsL.Name = "txtbox_productsL";
            this.txtbox_productsL.Size = new System.Drawing.Size(219, 18);
            this.txtbox_productsL.TabIndex = 90;
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_products.Location = new System.Drawing.Point(644, 353);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(62, 17);
            this.lbl_products.TabIndex = 89;
            this.lbl_products.Text = "Products";
            // 
            // lbl_container
            // 
            this.lbl_container.AutoSize = true;
            this.lbl_container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_container.Location = new System.Drawing.Point(335, 426);
            this.lbl_container.Name = "lbl_container";
            this.lbl_container.Size = new System.Drawing.Size(68, 17);
            this.lbl_container.TabIndex = 83;
            this.lbl_container.Text = "Container";
            // 
            // lbl_assistant
            // 
            this.lbl_assistant.AutoSize = true;
            this.lbl_assistant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_assistant.Location = new System.Drawing.Point(334, 500);
            this.lbl_assistant.Name = "lbl_assistant";
            this.lbl_assistant.Size = new System.Drawing.Size(64, 17);
            this.lbl_assistant.TabIndex = 84;
            this.lbl_assistant.Text = "Assistant";
            // 
            // btn_delete_load
            // 
            this.btn_delete_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_delete_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_load.FlatAppearance.BorderSize = 0;
            this.btn_delete_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_load.ForeColor = System.Drawing.Color.White;
            this.btn_delete_load.Location = new System.Drawing.Point(647, 500);
            this.btn_delete_load.Name = "btn_delete_load";
            this.btn_delete_load.Size = new System.Drawing.Size(219, 35);
            this.btn_delete_load.TabIndex = 94;
            this.btn_delete_load.Text = "DELETE";
            this.btn_delete_load.UseVisualStyleBackColor = false;
            this.btn_delete_load.Click += new System.EventHandler(this.btn_delete_load_Click);
            // 
            // btn_update_load
            // 
            this.btn_update_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_update_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_load.FlatAppearance.BorderSize = 0;
            this.btn_update_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_load.ForeColor = System.Drawing.Color.White;
            this.btn_update_load.Location = new System.Drawing.Point(647, 459);
            this.btn_update_load.Name = "btn_update_load";
            this.btn_update_load.Size = new System.Drawing.Size(219, 35);
            this.btn_update_load.TabIndex = 93;
            this.btn_update_load.Text = "UPDATE";
            this.btn_update_load.UseVisualStyleBackColor = false;
            this.btn_update_load.Click += new System.EventHandler(this.btn_update_load_Click);
            // 
            // btn_clear_load
            // 
            this.btn_clear_load.BackColor = System.Drawing.Color.White;
            this.btn_clear_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_clear_load.Location = new System.Drawing.Point(647, 541);
            this.btn_clear_load.Name = "btn_clear_load";
            this.btn_clear_load.Size = new System.Drawing.Size(219, 35);
            this.btn_clear_load.TabIndex = 92;
            this.btn_clear_load.Text = "CLEAR";
            this.btn_clear_load.UseVisualStyleBackColor = false;
            this.btn_clear_load.Click += new System.EventHandler(this.btn_clear_load_Click);
            // 
            // btn_create_load
            // 
            this.btn_create_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_create_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_load.FlatAppearance.BorderSize = 0;
            this.btn_create_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_load.ForeColor = System.Drawing.Color.White;
            this.btn_create_load.Location = new System.Drawing.Point(647, 418);
            this.btn_create_load.Name = "btn_create_load";
            this.btn_create_load.Size = new System.Drawing.Size(219, 35);
            this.btn_create_load.TabIndex = 91;
            this.btn_create_load.Text = "CREATE";
            this.btn_create_load.UseVisualStyleBackColor = false;
            this.btn_create_load.Click += new System.EventHandler(this.btn_create_load_Click);
            // 
            // cmbox_lorry
            // 
            this.cmbox_lorry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_lorry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_lorry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_lorry.FormattingEnabled = true;
            this.cmbox_lorry.Items.AddRange(new object[] {
            "Mahindra Bolero",
            "Mahindra Maximo",
            "Tata Dimo",
            "Tata Canter",
            "Fuso canter",
            "Izusu Elf",
            "Izusu Crewcab",
            "Ashok leyland",
            "",
            "",
            ""});
            this.cmbox_lorry.Location = new System.Drawing.Point(31, 521);
            this.cmbox_lorry.Name = "cmbox_lorry";
            this.cmbox_lorry.Size = new System.Drawing.Size(219, 25);
            this.cmbox_lorry.TabIndex = 95;
            // 
            // cmbox_driver
            // 
            this.cmbox_driver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_driver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_driver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_driver.FormattingEnabled = true;
            this.cmbox_driver.Items.AddRange(new object[] {
            "Paul Markey",
            "Salamon",
            "Janaka",
            "Azaam",
            "Pavithran",
            "Muhammed",
            "Yohan",
            "Lakshitha"});
            this.cmbox_driver.Location = new System.Drawing.Point(338, 374);
            this.cmbox_driver.Name = "cmbox_driver";
            this.cmbox_driver.Size = new System.Drawing.Size(219, 25);
            this.cmbox_driver.TabIndex = 96;
            // 
            // cmbox_assistant
            // 
            this.cmbox_assistant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_assistant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_assistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_assistant.FormattingEnabled = true;
            this.cmbox_assistant.Items.AddRange(new object[] {
            "Arham",
            "Wazeem",
            "Kumar",
            "Hentry",
            "Vijay",
            "Akash",
            "Anusha",
            "Wasantha"});
            this.cmbox_assistant.Location = new System.Drawing.Point(337, 523);
            this.cmbox_assistant.Name = "cmbox_assistant";
            this.cmbox_assistant.Size = new System.Drawing.Size(219, 25);
            this.cmbox_assistant.TabIndex = 97;
            // 
            // cmbox_container
            // 
            this.cmbox_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_container.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_container.FormattingEnabled = true;
            this.cmbox_container.Items.AddRange(new object[] {
            "NA-3342",
            "LQ-5463",
            "LM-2253",
            "LW-2226",
            "NA-4646",
            "NC-4312",
            "LA-4921",
            "NE-5675"});
            this.cmbox_container.Location = new System.Drawing.Point(338, 449);
            this.cmbox_container.Name = "cmbox_container";
            this.cmbox_container.Size = new System.Drawing.Size(219, 25);
            this.cmbox_container.TabIndex = 98;
            // 
            // lbl_loadsearch_error
            // 
            this.lbl_loadsearch_error.AutoSize = true;
            this.lbl_loadsearch_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadsearch_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_loadsearch_error.Location = new System.Drawing.Point(387, 20);
            this.lbl_loadsearch_error.Name = "lbl_loadsearch_error";
            this.lbl_loadsearch_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_loadsearch_error.TabIndex = 99;
            this.lbl_loadsearch_error.Text = "Error required";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(614, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 28);
            this.btn_search.TabIndex = 101;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_loadcreate_error
            // 
            this.lbl_loadcreate_error.AutoSize = true;
            this.lbl_loadcreate_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadcreate_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_loadcreate_error.Location = new System.Drawing.Point(645, 403);
            this.lbl_loadcreate_error.Name = "lbl_loadcreate_error";
            this.lbl_loadcreate_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_loadcreate_error.TabIndex = 102;
            this.lbl_loadcreate_error.Text = "Error required";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl_lname.Location = new System.Drawing.Point(28, 426);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(107, 17);
            this.lbl_lname.TabIndex = 103;
            this.lbl_lname.Text = "Customer Name";
            // 
            // cmbox_jobid
            // 
            this.cmbox_jobid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_jobid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_jobid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_jobid.FormattingEnabled = true;
            this.cmbox_jobid.Location = new System.Drawing.Point(31, 374);
            this.cmbox_jobid.Name = "cmbox_jobid";
            this.cmbox_jobid.Size = new System.Drawing.Size(219, 25);
            this.cmbox_jobid.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(283, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Select Load ID ";
            // 
            // cmbox_loadidselect
            // 
            this.cmbox_loadidselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbox_loadidselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_loadidselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_loadidselect.FormattingEnabled = true;
            this.cmbox_loadidselect.Location = new System.Drawing.Point(389, 35);
            this.cmbox_loadidselect.Name = "cmbox_loadidselect";
            this.cmbox_loadidselect.Size = new System.Drawing.Size(219, 25);
            this.cmbox_loadidselect.TabIndex = 145;
            // 
            // dgv_selectedproductsinload
            // 
            this.dgv_selectedproductsinload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_selectedproductsinload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_selectedproductsinload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_selectedproductsinload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectedproductsinload.Location = new System.Drawing.Point(647, 66);
            this.dgv_selectedproductsinload.Name = "dgv_selectedproductsinload";
            this.dgv_selectedproductsinload.Size = new System.Drawing.Size(219, 282);
            this.dgv_selectedproductsinload.TabIndex = 146;
            this.dgv_selectedproductsinload.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectedproductsinload_CellClick);
            // 
            // btn_jobidsearchinload
            // 
            this.btn_jobidsearchinload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_jobidsearchinload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_jobidsearchinload.BackgroundImage")));
            this.btn_jobidsearchinload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jobidsearchinload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jobidsearchinload.ForeColor = System.Drawing.Color.White;
            this.btn_jobidsearchinload.Location = new System.Drawing.Point(256, 371);
            this.btn_jobidsearchinload.Name = "btn_jobidsearchinload";
            this.btn_jobidsearchinload.Size = new System.Drawing.Size(28, 28);
            this.btn_jobidsearchinload.TabIndex = 147;
            this.btn_jobidsearchinload.UseVisualStyleBackColor = false;
            this.btn_jobidsearchinload.Click += new System.EventHandler(this.btn_jobidsearchinload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(696, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 148;
            this.label3.Text = "Products of Job ID";
            // 
            // lbl_jobid_error
            // 
            this.lbl_jobid_error.AutoSize = true;
            this.lbl_jobid_error.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jobid_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_jobid_error.Location = new System.Drawing.Point(29, 402);
            this.lbl_jobid_error.Name = "lbl_jobid_error";
            this.lbl_jobid_error.Size = new System.Drawing.Size(68, 12);
            this.lbl_jobid_error.TabIndex = 149;
            this.lbl_jobid_error.Text = "Error required";
            // 
            // txtbox_custname
            // 
            this.txtbox_custname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbox_custname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_custname.Enabled = false;
            this.txtbox_custname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_custname.Location = new System.Drawing.Point(31, 449);
            this.txtbox_custname.Multiline = true;
            this.txtbox_custname.Name = "txtbox_custname";
            this.txtbox_custname.Size = new System.Drawing.Size(219, 25);
            this.txtbox_custname.TabIndex = 150;
            // 
            // frmAdminLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.txtbox_custname);
            this.Controls.Add(this.lbl_jobid_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_jobidsearchinload);
            this.Controls.Add(this.dgv_selectedproductsinload);
            this.Controls.Add(this.cmbox_loadidselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_jobid);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_loadcreate_error);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_loadsearch_error);
            this.Controls.Add(this.cmbox_container);
            this.Controls.Add(this.cmbox_assistant);
            this.Controls.Add(this.cmbox_driver);
            this.Controls.Add(this.cmbox_lorry);
            this.Controls.Add(this.btn_delete_load);
            this.Controls.Add(this.btn_update_load);
            this.Controls.Add(this.btn_clear_load);
            this.Controls.Add(this.btn_create_load);
            this.Controls.Add(this.txtbox_productsL);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_container);
            this.Controls.Add(this.lbl_assistant);
            this.Controls.Add(this.lbl_driver);
            this.Controls.Add(this.lbl_lorry);
            this.Controls.Add(this.lbl_jobID);
            this.Controls.Add(this.dgv_aloads);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminLoad";
            this.Text = "frmAdminLoad";
            this.Load += new System.EventHandler(this.frmAdminLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedproductsinload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aloads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lorry;
        private System.Windows.Forms.Label lbl_jobID;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.TextBox txtbox_productsL;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label lbl_container;
        private System.Windows.Forms.Label lbl_assistant;
        private System.Windows.Forms.Button btn_delete_load;
        private System.Windows.Forms.Button btn_update_load;
        private System.Windows.Forms.Button btn_clear_load;
        private System.Windows.Forms.Button btn_create_load;
        private System.Windows.Forms.ComboBox cmbox_lorry;
        private System.Windows.Forms.ComboBox cmbox_driver;
        private System.Windows.Forms.ComboBox cmbox_assistant;
        private System.Windows.Forms.ComboBox cmbox_container;
        private System.Windows.Forms.Label lbl_loadsearch_error;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_loadcreate_error;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.ComboBox cmbox_jobid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_loadidselect;
        private System.Windows.Forms.DataGridView dgv_selectedproductsinload;
        private System.Windows.Forms.Button btn_jobidsearchinload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_jobid_error;
        private System.Windows.Forms.TextBox txtbox_custname;
    }
}