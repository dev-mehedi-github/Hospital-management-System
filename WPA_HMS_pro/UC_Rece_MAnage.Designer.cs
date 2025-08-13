namespace WPA_HMS_pro
{
    partial class UC_Rece_MAnage
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearchRec = new System.Windows.Forms.Button();
            this.lblmanageREC = new System.Windows.Forms.Label();
            this.btnDltRec = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvReceptionist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSearchRec
            // 
            this.btnSearchRec.Location = new System.Drawing.Point(276, 61);
            this.btnSearchRec.Name = "btnSearchRec";
            this.btnSearchRec.Size = new System.Drawing.Size(85, 33);
            this.btnSearchRec.TabIndex = 3;
            this.btnSearchRec.Text = "Search";
            this.btnSearchRec.UseVisualStyleBackColor = true;
            this.btnSearchRec.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblmanageREC
            // 
            this.lblmanageREC.AutoSize = true;
            this.lblmanageREC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanageREC.Location = new System.Drawing.Point(3, 14);
            this.lblmanageREC.Name = "lblmanageREC";
            this.lblmanageREC.Size = new System.Drawing.Size(213, 30);
            this.lblmanageREC.TabIndex = 4;
            this.lblmanageREC.Text = "Manage Receptionist";
            // 
            // btnDltRec
            // 
            this.btnDltRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDltRec.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDltRec.Location = new System.Drawing.Point(367, 61);
            this.btnDltRec.Name = "btnDltRec";
            this.btnDltRec.Size = new System.Drawing.Size(102, 33);
            this.btnDltRec.TabIndex = 43;
            this.btnDltRec.Text = "Delete";
            this.btnDltRec.UseVisualStyleBackColor = false;
            this.btnDltRec.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(687, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 42);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvReceptionist
            // 
            this.dgvReceptionist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReceptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReceptionist.Location = new System.Drawing.Point(0, 113);
            this.dgvReceptionist.Name = "dgvReceptionist";
            this.dgvReceptionist.Size = new System.Drawing.Size(755, 567);
            this.dgvReceptionist.TabIndex = 0;
            // 
            // UC_Rece_MAnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDltRec);
            this.Controls.Add(this.lblmanageREC);
            this.Controls.Add(this.btnSearchRec);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvReceptionist);
            this.Name = "UC_Rece_MAnage";
            this.Size = new System.Drawing.Size(755, 680);
            this.Load += new System.EventHandler(this.UC_Rece_MAnage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearchRec;
        private System.Windows.Forms.Label lblmanageREC;
        private System.Windows.Forms.Button btnDltRec;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvReceptionist;
    }
}
