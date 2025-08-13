namespace WPA_HMS_pro
{
    partial class UC_Manage_Patient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DBDataSet13 = new WPA_HMS_pro.HMS_DBDataSet13();
            this.cmbCabin = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dgvAdmissionInvoice = new System.Windows.Forms.DataGridView();
            this.cabinNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DBDataSet14 = new WPA_HMS_pro.HMS_DBDataSet14();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnltest = new System.Windows.Forms.Panel();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.dgvTestinfo = new System.Windows.Forms.DataGridView();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchTest = new System.Windows.Forms.TextBox();
            this.pnl_recipt = new System.Windows.Forms.Panel();
            this.dgvSelectedTest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveTest = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblrecipt = new System.Windows.Forms.Label();
            this.btnRecipt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnP_Register = new System.Windows.Forms.Button();
            this.lbltest = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lnlBloodGroup = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblPaitentName = new System.Windows.Forms.Label();
            this.lblGenerelInfo = new System.Windows.Forms.Label();
            this.testsTableAdapter = new WPA_HMS_pro.HMS_DBDataSet13TableAdapters.TestsTableAdapter();
            this.cabinsTableAdapter = new WPA_HMS_pro.HMS_DBDataSet14TableAdapters.CabinsTableAdapter();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmissionInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet14)).BeginInit();
            this.pnltest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestinfo)).BeginInit();
            this.pnl_recipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoScrollMargin = new System.Drawing.Size(50, 100);
            this.panelMain.BackColor = System.Drawing.Color.SlateGray;
            this.panelMain.Controls.Add(this.cmbCabin);
            this.panelMain.Controls.Add(this.cmbDoctor);
            this.panelMain.Controls.Add(this.dgvAdmissionInvoice);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.pnltest);
            this.panelMain.Controls.Add(this.pnl_recipt);
            this.panelMain.Controls.Add(this.btnRecipt);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnclr);
            this.panelMain.Controls.Add(this.btnP_Register);
            this.panelMain.Controls.Add(this.lbltest);
            this.panelMain.Controls.Add(this.txtAddress);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.txtAge);
            this.panelMain.Controls.Add(this.cmbBloodGroup);
            this.panelMain.Controls.Add(this.cmbGender);
            this.panelMain.Controls.Add(this.txtPName);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Controls.Add(this.lnlBloodGroup);
            this.panelMain.Controls.Add(this.lblSex);
            this.panelMain.Controls.Add(this.lblage);
            this.panelMain.Controls.Add(this.lbladdress);
            this.panelMain.Controls.Add(this.lblPaitentName);
            this.panelMain.Controls.Add(this.lblGenerelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(997, 720);
            this.panelMain.TabIndex = 2;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.hMS_DBDataSet13;
            // 
            // hMS_DBDataSet13
            // 
            this.hMS_DBDataSet13.DataSetName = "HMS_DBDataSet13";
            this.hMS_DBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCabin
            // 
            this.cmbCabin.FormattingEnabled = true;
            this.cmbCabin.Location = new System.Drawing.Point(521, 620);
            this.cmbCabin.Name = "cmbCabin";
            this.cmbCabin.Size = new System.Drawing.Size(257, 21);
            this.cmbCabin.TabIndex = 44;
            this.cmbCabin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCabin_MouseClick);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(154, 620);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(227, 21);
            this.cmbDoctor.TabIndex = 43;
            // 
            // dgvAdmissionInvoice
            // 
            this.dgvAdmissionInvoice.AllowUserToAddRows = false;
            this.dgvAdmissionInvoice.AllowUserToDeleteRows = false;
            this.dgvAdmissionInvoice.AutoGenerateColumns = false;
            this.dgvAdmissionInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmissionInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabinNumberDataGridViewTextBoxColumn,
            this.cabinNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.isAvailableDataGridViewTextBoxColumn});
            this.dgvAdmissionInvoice.DataSource = this.cabinsBindingSource;
            this.dgvAdmissionInvoice.Location = new System.Drawing.Point(52, 668);
            this.dgvAdmissionInvoice.Name = "dgvAdmissionInvoice";
            this.dgvAdmissionInvoice.ReadOnly = true;
            this.dgvAdmissionInvoice.Size = new System.Drawing.Size(478, 150);
            this.dgvAdmissionInvoice.TabIndex = 42;
            // 
            // cabinNumberDataGridViewTextBoxColumn
            // 
            this.cabinNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cabinNumberDataGridViewTextBoxColumn.DataPropertyName = "CabinNumber";
            this.cabinNumberDataGridViewTextBoxColumn.HeaderText = "Cabin Number";
            this.cabinNumberDataGridViewTextBoxColumn.Name = "cabinNumberDataGridViewTextBoxColumn";
            this.cabinNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cabinNameDataGridViewTextBoxColumn
            // 
            this.cabinNameDataGridViewTextBoxColumn.DataPropertyName = "CabinName";
            this.cabinNameDataGridViewTextBoxColumn.HeaderText = "Cabin Name";
            this.cabinNameDataGridViewTextBoxColumn.Name = "cabinNameDataGridViewTextBoxColumn";
            this.cabinNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.Name = "isAvailableDataGridViewTextBoxColumn";
            this.isAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cabinsBindingSource
            // 
            this.cabinsBindingSource.DataMember = "Cabins";
            this.cabinsBindingSource.DataSource = this.hMS_DBDataSet14;
            // 
            // hMS_DBDataSet14
            // 
            this.hMS_DBDataSet14.DataSetName = "HMS_DBDataSet14";
            this.hMS_DBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Assign Cabin: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Assign Doctor: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Admission:";
            // 
            // pnltest
            // 
            this.pnltest.Controls.Add(this.btnAddTest);
            this.pnltest.Controls.Add(this.dgvTestinfo);
            this.pnltest.Controls.Add(this.txtSearchTest);
            this.pnltest.Location = new System.Drawing.Point(33, 218);
            this.pnltest.Name = "pnltest";
            this.pnltest.Size = new System.Drawing.Size(420, 230);
            this.pnltest.TabIndex = 34;
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.Green;
            this.btnAddTest.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTest.Location = new System.Drawing.Point(186, 8);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(70, 33);
            this.btnAddTest.TabIndex = 32;
            this.btnAddTest.Text = "Add";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // dgvTestinfo
            // 
            this.dgvTestinfo.AllowUserToAddRows = false;
            this.dgvTestinfo.AllowUserToDeleteRows = false;
            this.dgvTestinfo.AutoGenerateColumns = false;
            this.dgvTestinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.testNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvTestinfo.DataSource = this.testsBindingSource;
            this.dgvTestinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTestinfo.Location = new System.Drawing.Point(0, 57);
            this.dgvTestinfo.Name = "dgvTestinfo";
            this.dgvTestinfo.ReadOnly = true;
            this.dgvTestinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestinfo.Size = new System.Drawing.Size(420, 173);
            this.dgvTestinfo.TabIndex = 24;
            this.dgvTestinfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTestinfo_MouseClick);
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "TestID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "TestID";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            this.testNameDataGridViewTextBoxColumn.HeaderText = "TestName";
            this.testNameDataGridViewTextBoxColumn.Name = "testNameDataGridViewTextBoxColumn";
            this.testNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.Location = new System.Drawing.Point(3, 15);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(177, 20);
            this.txtSearchTest.TabIndex = 23;
            this.txtSearchTest.TextChanged += new System.EventHandler(this.txtSearchTest_TextChanged);
            // 
            // pnl_recipt
            // 
            this.pnl_recipt.BackColor = System.Drawing.Color.LightCyan;
            this.pnl_recipt.Controls.Add(this.dgvSelectedTest);
            this.pnl_recipt.Controls.Add(this.label1);
            this.pnl_recipt.Controls.Add(this.lblvat);
            this.pnl_recipt.Controls.Add(this.txtDiscount);
            this.pnl_recipt.Controls.Add(this.txtVAT);
            this.pnl_recipt.Controls.Add(this.lblTotal);
            this.pnl_recipt.Controls.Add(this.btnRemoveTest);
            this.pnl_recipt.Controls.Add(this.lblSubtotal);
            this.pnl_recipt.Controls.Add(this.lblrecipt);
            this.pnl_recipt.Location = new System.Drawing.Point(459, 218);
            this.pnl_recipt.Name = "pnl_recipt";
            this.pnl_recipt.Size = new System.Drawing.Size(518, 352);
            this.pnl_recipt.TabIndex = 32;
            // 
            // dgvSelectedTest
            // 
            this.dgvSelectedTest.AllowUserToAddRows = false;
            this.dgvSelectedTest.AllowUserToDeleteRows = false;
            this.dgvSelectedTest.AutoGenerateColumns = false;
            this.dgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSelectedTest.DataSource = this.testsBindingSource;
            this.dgvSelectedTest.Location = new System.Drawing.Point(0, 63);
            this.dgvSelectedTest.Name = "dgvSelectedTest";
            this.dgvSelectedTest.ReadOnly = true;
            this.dgvSelectedTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedTest.Size = new System.Drawing.Size(512, 173);
            this.dgvSelectedTest.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TestID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TestID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TestName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TestName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Discount (BDT):";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.Location = new System.Drawing.Point(324, 269);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(63, 20);
            this.lblvat.TabIndex = 35;
            this.lblvat.Text = "VAT (%):";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(393, 295);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 34;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(393, 269);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(100, 20);
            this.txtVAT.TabIndex = 33;
            this.txtVAT.TextChanged += new System.EventHandler(this.txtVAT_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(347, 325);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total:";
            // 
            // btnRemoveTest
            // 
            this.btnRemoveTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTest.Location = new System.Drawing.Point(414, 25);
            this.btnRemoveTest.Name = "btnRemoveTest";
            this.btnRemoveTest.Size = new System.Drawing.Size(98, 32);
            this.btnRemoveTest.TabIndex = 31;
            this.btnRemoveTest.Text = "Remove";
            this.btnRemoveTest.UseVisualStyleBackColor = false;
            this.btnRemoveTest.Click += new System.EventHandler(this.btnRemoveTest_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(322, 240);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 20);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "SubTotal:";
            // 
            // lblrecipt
            // 
            this.lblrecipt.BackColor = System.Drawing.Color.Transparent;
            this.lblrecipt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecipt.Location = new System.Drawing.Point(13, 9);
            this.lblrecipt.Name = "lblrecipt";
            this.lblrecipt.Size = new System.Drawing.Size(149, 29);
            this.lblrecipt.TabIndex = 15;
            this.lblrecipt.Text = "Test Details: ";
            // 
            // btnRecipt
            // 
            this.btnRecipt.BackColor = System.Drawing.Color.Green;
            this.btnRecipt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecipt.Location = new System.Drawing.Point(293, 849);
            this.btnRecipt.Name = "btnRecipt";
            this.btnRecipt.Size = new System.Drawing.Size(124, 42);
            this.btnRecipt.TabIndex = 31;
            this.btnRecipt.Text = "Recipet";
            this.btnRecipt.UseVisualStyleBackColor = false;
            this.btnRecipt.Click += new System.EventHandler(this.btnRecipt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(423, 849);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 42);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclr.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclr.Location = new System.Drawing.Point(33, 849);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(124, 42);
            this.btnclr.TabIndex = 29;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnP_Register
            // 
            this.btnP_Register.BackColor = System.Drawing.Color.SteelBlue;
            this.btnP_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.btnP_Register.Location = new System.Drawing.Point(163, 849);
            this.btnP_Register.Name = "btnP_Register";
            this.btnP_Register.Size = new System.Drawing.Size(124, 42);
            this.btnP_Register.TabIndex = 28;
            this.btnP_Register.Text = "Register";
            this.btnP_Register.UseVisualStyleBackColor = false;
            this.btnP_Register.Click += new System.EventHandler(this.btnP_Register_Click);
            // 
            // lbltest
            // 
            this.lbltest.BackColor = System.Drawing.Color.Transparent;
            this.lbltest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(27, 186);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(72, 29);
            this.lbltest.TabIndex = 24;
            this.lbltest.Text = "Test: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(137, 145);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(691, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(629, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 22;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(507, 104);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 21;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "O+\t",
            "A+",
            "B+",
            "O-",
            "A-",
            "B-",
            "AB+",
            "AB-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(385, 104);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(83, 21);
            this.cmbBloodGroup.TabIndex = 20;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(302, 104);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(55, 21);
            this.cmbGender.TabIndex = 19;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(47, 104);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(226, 20);
            this.txtPName.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(624, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 29);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone:";
            // 
            // lnlBloodGroup
            // 
            this.lnlBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.lnlBloodGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlBloodGroup.Location = new System.Drawing.Point(380, 72);
            this.lnlBloodGroup.Name = "lnlBloodGroup";
            this.lnlBloodGroup.Size = new System.Drawing.Size(103, 29);
            this.lnlBloodGroup.TabIndex = 16;
            this.lnlBloodGroup.Text = "Blood Grp:";
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(297, 72);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(47, 29);
            this.lblSex.TabIndex = 15;
            this.lblSex.Text = "Sex:";
            // 
            // lblage
            // 
            this.lblage.BackColor = System.Drawing.Color.Transparent;
            this.lblage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(502, 72);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(53, 29);
            this.lblage.TabIndex = 14;
            this.lblage.Text = "Age:";
            // 
            // lbladdress
            // 
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(42, 143);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(87, 29);
            this.lbladdress.TabIndex = 13;
            this.lbladdress.Text = "Address:";
            // 
            // lblPaitentName
            // 
            this.lblPaitentName.BackColor = System.Drawing.Color.Transparent;
            this.lblPaitentName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaitentName.Location = new System.Drawing.Point(42, 72);
            this.lblPaitentName.Name = "lblPaitentName";
            this.lblPaitentName.Size = new System.Drawing.Size(70, 29);
            this.lblPaitentName.TabIndex = 12;
            this.lblPaitentName.Text = "Name:";
            // 
            // lblGenerelInfo
            // 
            this.lblGenerelInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerelInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerelInfo.ForeColor = System.Drawing.Color.Black;
            this.lblGenerelInfo.Location = new System.Drawing.Point(27, 31);
            this.lblGenerelInfo.Name = "lblGenerelInfo";
            this.lblGenerelInfo.Size = new System.Drawing.Size(354, 29);
            this.lblGenerelInfo.TabIndex = 11;
            this.lblGenerelInfo.Text = "Patient General Information:";
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // cabinsTableAdapter
            // 
            this.cabinsTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Manage_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_Manage_Patient";
            this.Size = new System.Drawing.Size(997, 720);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmissionInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet14)).EndInit();
            this.pnltest.ResumeLayout(false);
            this.pnltest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestinfo)).EndInit();
            this.pnl_recipt.ResumeLayout(false);
            this.pnl_recipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel pnl_recipt;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblrecipt;
        private System.Windows.Forms.Button btnRecipt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnP_Register;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lnlBloodGroup;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblPaitentName;
        private System.Windows.Forms.Label lblGenerelInfo;
        private System.Windows.Forms.Panel pnltest;
        private System.Windows.Forms.TextBox txtSearchTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.DataGridView dgvTestinfo;
        private System.Windows.Forms.Button btnRemoveTest;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAdmissionInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCabin;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private HMS_DBDataSet13 hMS_DBDataSet13;
        private HMS_DBDataSet13TableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.DataGridView dgvSelectedTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cabinsBindingSource;
        private HMS_DBDataSet14 hMS_DBDataSet14;
        private HMS_DBDataSet14TableAdapters.CabinsTableAdapter cabinsTableAdapter;
    }
}
