namespace WPA_HMS_pro
{
    partial class Uc_PaitentBill
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
            this.lblBillCabinPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.lblBillDiscount = new System.Windows.Forms.Label();
            this.lblBillVAT = new System.Windows.Forms.Label();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.lblBillSubtotal = new System.Windows.Forms.Label();
            this.dgvBillTests = new System.Windows.Forms.DataGridView();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DBDataSet15 = new WPA_HMS_pro.HMS_DBDataSet15();
            this.lblBillCabinName = new System.Windows.Forms.Label();
            this.lblBillAdmissionStatus = new System.Windows.Forms.Label();
            this.lblBillDoctor = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillPatientName = new System.Windows.Forms.Label();
            this.lblBillPatientID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPatientID = new System.Windows.Forms.TextBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.testsTableAdapter = new WPA_HMS_pro.HMS_DBDataSet15TableAdapters.TestsTableAdapter();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.lblBillCabinPrice);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.lbltest);
            this.panelMain.Controls.Add(this.btnDischarge);
            this.panelMain.Controls.Add(this.lblBillDiscount);
            this.panelMain.Controls.Add(this.lblBillVAT);
            this.panelMain.Controls.Add(this.lblBillTotal);
            this.panelMain.Controls.Add(this.lblBillSubtotal);
            this.panelMain.Controls.Add(this.dgvBillTests);
            this.panelMain.Controls.Add(this.lblBillCabinName);
            this.panelMain.Controls.Add(this.lblBillAdmissionStatus);
            this.panelMain.Controls.Add(this.lblBillDoctor);
            this.panelMain.Controls.Add(this.lblBillDate);
            this.panelMain.Controls.Add(this.lblBillPatientName);
            this.panelMain.Controls.Add(this.lblBillPatientID);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.txtSearchPatientID);
            this.panelMain.Controls.Add(this.lblTittle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(997, 720);
            this.panelMain.TabIndex = 0;
            // 
            // lblBillCabinPrice
            // 
            this.lblBillCabinPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBillCabinPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCabinPrice.Location = new System.Drawing.Point(406, 261);
            this.lblBillCabinPrice.Name = "lblBillCabinPrice";
            this.lblBillCabinPrice.Size = new System.Drawing.Size(264, 29);
            this.lblBillCabinPrice.TabIndex = 51;
            this.lblBillCabinPrice.Text = "Cabin Price:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Test Info: ";
            // 
            // lbltest
            // 
            this.lbltest.BackColor = System.Drawing.Color.Transparent;
            this.lbltest.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(139, 174);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(203, 29);
            this.lbltest.TabIndex = 49;
            this.lbltest.Text = "Admission Info: ";
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDischarge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDischarge.Location = new System.Drawing.Point(522, 613);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(98, 32);
            this.btnDischarge.TabIndex = 48;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // lblBillDiscount
            // 
            this.lblBillDiscount.AutoSize = true;
            this.lblBillDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDiscount.Location = new System.Drawing.Point(416, 545);
            this.lblBillDiscount.Name = "lblBillDiscount";
            this.lblBillDiscount.Size = new System.Drawing.Size(111, 20);
            this.lblBillDiscount.TabIndex = 46;
            this.lblBillDiscount.Text = "Discount (BDT):";
            // 
            // lblBillVAT
            // 
            this.lblBillVAT.AutoSize = true;
            this.lblBillVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillVAT.Location = new System.Drawing.Point(459, 519);
            this.lblBillVAT.Name = "lblBillVAT";
            this.lblBillVAT.Size = new System.Drawing.Size(63, 20);
            this.lblBillVAT.TabIndex = 45;
            this.lblBillVAT.Text = "VAT (%):";
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(482, 575);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(45, 20);
            this.lblBillTotal.TabIndex = 44;
            this.lblBillTotal.Text = "Total:";
            // 
            // lblBillSubtotal
            // 
            this.lblBillSubtotal.AutoSize = true;
            this.lblBillSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSubtotal.Location = new System.Drawing.Point(457, 490);
            this.lblBillSubtotal.Name = "lblBillSubtotal";
            this.lblBillSubtotal.Size = new System.Drawing.Size(70, 20);
            this.lblBillSubtotal.TabIndex = 43;
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
            this.dgvBillTests.Location = new System.Drawing.Point(234, 337);
            this.dgvBillTests.Name = "dgvBillTests";
            this.dgvBillTests.ReadOnly = true;
            this.dgvBillTests.Size = new System.Drawing.Size(386, 150);
            this.dgvBillTests.TabIndex = 42;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            this.testNameDataGridViewTextBoxColumn.HeaderText = "Test Name";
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
            this.testsBindingSource.DataSource = this.hMS_DBDataSet15;
            // 
            // hMS_DBDataSet15
            // 
            this.hMS_DBDataSet15.DataSetName = "HMS_DBDataSet15";
            this.hMS_DBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBillCabinName
            // 
            this.lblBillCabinName.BackColor = System.Drawing.Color.Transparent;
            this.lblBillCabinName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCabinName.Location = new System.Drawing.Point(178, 261);
            this.lblBillCabinName.Name = "lblBillCabinName";
            this.lblBillCabinName.Size = new System.Drawing.Size(222, 29);
            this.lblBillCabinName.TabIndex = 40;
            this.lblBillCabinName.Text = "Cabin:";
            // 
            // lblBillAdmissionStatus
            // 
            this.lblBillAdmissionStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBillAdmissionStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAdmissionStatus.Location = new System.Drawing.Point(174, 232);
            this.lblBillAdmissionStatus.Name = "lblBillAdmissionStatus";
            this.lblBillAdmissionStatus.Size = new System.Drawing.Size(272, 29);
            this.lblBillAdmissionStatus.TabIndex = 39;
            this.lblBillAdmissionStatus.Text = "Status:";
            // 
            // lblBillDoctor
            // 
            this.lblBillDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblBillDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDoctor.Location = new System.Drawing.Point(123, 203);
            this.lblBillDoctor.Name = "lblBillDoctor";
            this.lblBillDoctor.Size = new System.Drawing.Size(382, 29);
            this.lblBillDoctor.TabIndex = 36;
            this.lblBillDoctor.Text = "Assigned Dr:";
            // 
            // lblBillDate
            // 
            this.lblBillDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(558, 114);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(293, 29);
            this.lblBillDate.TabIndex = 35;
            this.lblBillDate.Text = "Registration Date:";
            // 
            // lblBillPatientName
            // 
            this.lblBillPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblBillPatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPatientName.Location = new System.Drawing.Point(109, 143);
            this.lblBillPatientName.Name = "lblBillPatientName";
            this.lblBillPatientName.Size = new System.Drawing.Size(367, 29);
            this.lblBillPatientName.TabIndex = 34;
            this.lblBillPatientName.Text = "Patient Name:";
            // 
            // lblBillPatientID
            // 
            this.lblBillPatientID.BackColor = System.Drawing.Color.Transparent;
            this.lblBillPatientID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPatientID.Location = new System.Drawing.Point(77, 114);
            this.lblBillPatientID.Name = "lblBillPatientID";
            this.lblBillPatientID.Size = new System.Drawing.Size(349, 29);
            this.lblBillPatientID.TabIndex = 33;
            this.lblBillPatientID.Text = "Patient Id/Invoice: ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(572, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 32);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPatientID
            // 
            this.txtSearchPatientID.Location = new System.Drawing.Point(350, 48);
            this.txtSearchPatientID.Name = "txtSearchPatientID";
            this.txtSearchPatientID.Size = new System.Drawing.Size(216, 20);
            this.txtSearchPatientID.TabIndex = 26;
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Poor Richard", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(997, 35);
            this.lblTittle.TabIndex = 25;
            this.lblTittle.Text = "Billing Section";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // Uc_PaitentBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Uc_PaitentBill";
            this.Size = new System.Drawing.Size(997, 720);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DBDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtSearchPatientID;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBillDoctor;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblBillPatientName;
        private System.Windows.Forms.Label lblBillPatientID;
        private System.Windows.Forms.Label lblBillCabinName;
        private System.Windows.Forms.Label lblBillAdmissionStatus;
        private System.Windows.Forms.DataGridView dgvBillTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private HMS_DBDataSet15 hMS_DBDataSet15;
        private HMS_DBDataSet15TableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.Label lblBillDiscount;
        private System.Windows.Forms.Label lblBillVAT;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label lblBillSubtotal;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblBillCabinPrice;
    }
}
