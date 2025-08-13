namespace WPA_HMS_pro
{
    partial class UC_AdminBills
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePatientHistory = new System.Windows.Forms.Button();
            this.lblDischargeDate = new System.Windows.Forms.Label();
            this.lblBillCabinPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.lblBillDiscount = new System.Windows.Forms.Label();
            this.lblBillVAT = new System.Windows.Forms.Label();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.lblBillSubtotal = new System.Windows.Forms.Label();
            this.dgvBillTests = new System.Windows.Forms.DataGridView();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DBDataSet7 = new WPA_HMS_pro.HMS_DBDataSet7();
            this.lblBillCabinName = new System.Windows.Forms.Label();
            this.lblBillAdmissionStatus = new System.Windows.Forms.Label();
            this.lblBillDoctor = new System.Windows.Forms.Label();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.lblBillPatientName = new System.Windows.Forms.Label();
            this.lblBillPatientID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPatientID = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.testsTableAdapter = new WPA_HMS_pro.HMS_DBDataSet7TableAdapters.TestsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(50, 110);
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDeletePatientHistory);
            this.panel1.Controls.Add(this.lblDischargeDate);
            this.panel1.Controls.Add(this.lblBillCabinPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltest);
            this.panel1.Controls.Add(this.lblBillDiscount);
            this.panel1.Controls.Add(this.lblBillVAT);
            this.panel1.Controls.Add(this.lblBillTotal);
            this.panel1.Controls.Add(this.lblBillSubtotal);
            this.panel1.Controls.Add(this.dgvBillTests);
            this.panel1.Controls.Add(this.lblBillCabinName);
            this.panel1.Controls.Add(this.lblBillAdmissionStatus);
            this.panel1.Controls.Add(this.lblBillDoctor);
            this.panel1.Controls.Add(this.lblRegisterDate);
            this.panel1.Controls.Add(this.lblBillPatientName);
            this.panel1.Controls.Add(this.lblBillPatientID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchPatientID);
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 1231);
            this.panel1.TabIndex = 0;
            // 
            // btnDeletePatientHistory
            // 
            this.btnDeletePatientHistory.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePatientHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatientHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeletePatientHistory.Location = new System.Drawing.Point(703, 31);
            this.btnDeletePatientHistory.Name = "btnDeletePatientHistory";
            this.btnDeletePatientHistory.Size = new System.Drawing.Size(113, 38);
            this.btnDeletePatientHistory.TabIndex = 74;
            this.btnDeletePatientHistory.Text = "Delete";
            this.btnDeletePatientHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletePatientHistory.UseVisualStyleBackColor = false;
            this.btnDeletePatientHistory.Click += new System.EventHandler(this.btnDeletePatientHistory_Click);
            // 
            // lblDischargeDate
            // 
            this.lblDischargeDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDischargeDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDischargeDate.Location = new System.Drawing.Point(592, 209);
            this.lblDischargeDate.Name = "lblDischargeDate";
            this.lblDischargeDate.Size = new System.Drawing.Size(293, 29);
            this.lblDischargeDate.TabIndex = 73;
            this.lblDischargeDate.Text = "Discharge Date:";
            // 
            // lblBillCabinPrice
            // 
            this.lblBillCabinPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBillCabinPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCabinPrice.Location = new System.Drawing.Point(165, 296);
            this.lblBillCabinPrice.Name = "lblBillCabinPrice";
            this.lblBillCabinPrice.Size = new System.Drawing.Size(264, 29);
            this.lblBillCabinPrice.TabIndex = 72;
            this.lblBillCabinPrice.Text = "Cabin Price:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "Test Info: ";
            // 
            // lbltest
            // 
            this.lbltest.BackColor = System.Drawing.Color.Transparent;
            this.lbltest.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(173, 180);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(203, 29);
            this.lbltest.TabIndex = 70;
            this.lbltest.Text = "Admission Info: ";
            // 
            // lblBillDiscount
            // 
            this.lblBillDiscount.AutoSize = true;
            this.lblBillDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDiscount.Location = new System.Drawing.Point(445, 560);
            this.lblBillDiscount.Name = "lblBillDiscount";
            this.lblBillDiscount.Size = new System.Drawing.Size(111, 20);
            this.lblBillDiscount.TabIndex = 69;
            this.lblBillDiscount.Text = "Discount (BDT):";
            // 
            // lblBillVAT
            // 
            this.lblBillVAT.AutoSize = true;
            this.lblBillVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillVAT.Location = new System.Drawing.Point(493, 537);
            this.lblBillVAT.Name = "lblBillVAT";
            this.lblBillVAT.Size = new System.Drawing.Size(63, 20);
            this.lblBillVAT.TabIndex = 68;
            this.lblBillVAT.Text = "VAT (%):";
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(511, 590);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(45, 20);
            this.lblBillTotal.TabIndex = 67;
            this.lblBillTotal.Text = "Total:";
            // 
            // lblBillSubtotal
            // 
            this.lblBillSubtotal.AutoSize = true;
            this.lblBillSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSubtotal.Location = new System.Drawing.Point(486, 511);
            this.lblBillSubtotal.Name = "lblBillSubtotal";
            this.lblBillSubtotal.Size = new System.Drawing.Size(70, 20);
            this.lblBillSubtotal.TabIndex = 66;
            this.lblBillSubtotal.Text = "SubTotal:";
            // 
            // dgvBillTests
            // 
            this.dgvBillTests.AllowUserToAddRows = false;
            this.dgvBillTests.AllowUserToDeleteRows = false;
            this.dgvBillTests.AutoGenerateColumns = false;
            this.dgvBillTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvBillTests.DataSource = this.testsBindingSource;
            this.dgvBillTests.Location = new System.Drawing.Point(263, 358);
            this.dgvBillTests.Name = "dgvBillTests";
            this.dgvBillTests.ReadOnly = true;
            this.dgvBillTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillTests.Size = new System.Drawing.Size(386, 150);
            this.dgvBillTests.TabIndex = 65;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.hMS_DBDataSet7;
            // 
            // hMS_DBDataSet7
            // 
            this.hMS_DBDataSet7.DataSetName = "HMS_DBDataSet7";
            this.hMS_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBillCabinName
            // 
            this.lblBillCabinName.BackColor = System.Drawing.Color.Transparent;
            this.lblBillCabinName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCabinName.Location = new System.Drawing.Point(212, 267);
            this.lblBillCabinName.Name = "lblBillCabinName";
            this.lblBillCabinName.Size = new System.Drawing.Size(222, 29);
            this.lblBillCabinName.TabIndex = 64;
            this.lblBillCabinName.Text = "Cabin:";
            // 
            // lblBillAdmissionStatus
            // 
            this.lblBillAdmissionStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBillAdmissionStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAdmissionStatus.Location = new System.Drawing.Point(208, 238);
            this.lblBillAdmissionStatus.Name = "lblBillAdmissionStatus";
            this.lblBillAdmissionStatus.Size = new System.Drawing.Size(272, 29);
            this.lblBillAdmissionStatus.TabIndex = 63;
            this.lblBillAdmissionStatus.Text = "Status:";
            // 
            // lblBillDoctor
            // 
            this.lblBillDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblBillDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDoctor.Location = new System.Drawing.Point(157, 209);
            this.lblBillDoctor.Name = "lblBillDoctor";
            this.lblBillDoctor.Size = new System.Drawing.Size(382, 29);
            this.lblBillDoctor.TabIndex = 62;
            this.lblBillDoctor.Text = "Assigned Dr:";
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterDate.Location = new System.Drawing.Point(592, 120);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(293, 29);
            this.lblRegisterDate.TabIndex = 61;
            this.lblRegisterDate.Text = "Registration Date:";
            // 
            // lblBillPatientName
            // 
            this.lblBillPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblBillPatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPatientName.Location = new System.Drawing.Point(143, 149);
            this.lblBillPatientName.Name = "lblBillPatientName";
            this.lblBillPatientName.Size = new System.Drawing.Size(367, 29);
            this.lblBillPatientName.TabIndex = 60;
            this.lblBillPatientName.Text = "Patient Name:";
            // 
            // lblBillPatientID
            // 
            this.lblBillPatientID.BackColor = System.Drawing.Color.Transparent;
            this.lblBillPatientID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPatientID.Location = new System.Drawing.Point(111, 120);
            this.lblBillPatientID.Name = "lblBillPatientID";
            this.lblBillPatientID.Size = new System.Drawing.Size(349, 29);
            this.lblBillPatientID.TabIndex = 59;
            this.lblBillPatientID.Text = "Patient Id/Invoice: ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(566, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 38);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPatientID
            // 
            this.txtSearchPatientID.Location = new System.Drawing.Point(342, 39);
            this.txtSearchPatientID.Name = "txtSearchPatientID";
            this.txtSearchPatientID.Size = new System.Drawing.Size(214, 20);
            this.txtSearchPatientID.TabIndex = 2;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBill.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBill.Location = new System.Drawing.Point(32, 21);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(133, 40);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Billings:";
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // UC_AdminBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(50, 100);
            this.Controls.Add(this.panel1);
            this.Name = "UC_AdminBills";
            this.Size = new System.Drawing.Size(963, 686);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtSearchPatientID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDischargeDate;
        private System.Windows.Forms.Label lblBillCabinPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblBillDiscount;
        private System.Windows.Forms.Label lblBillVAT;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label lblBillSubtotal;
        private System.Windows.Forms.DataGridView dgvBillTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private HMS_DBDataSet7 hMS_DBDataSet7;
        private System.Windows.Forms.Label lblBillCabinName;
        private System.Windows.Forms.Label lblBillAdmissionStatus;
        private System.Windows.Forms.Label lblBillDoctor;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.Label lblBillPatientName;
        private System.Windows.Forms.Label lblBillPatientID;
        private HMS_DBDataSet7TableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.Button btnDeletePatientHistory;
    }
}
