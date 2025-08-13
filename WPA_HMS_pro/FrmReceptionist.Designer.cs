using System.Windows.Forms;

namespace WPA_HMS_pro
{
    partial class FrmReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceptionist));
            this.pnlReceHome = new System.Windows.Forms.Panel();
            this.pnlPaitentReg = new System.Windows.Forms.Panel();
            this.btnPaitentReg = new System.Windows.Forms.Button();
            this.lblbtnpRegText = new System.Windows.Forms.Label();
            this.pnlbill = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.btnBilling = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOnlyAPPtextbtn = new System.Windows.Forms.Label();
            this.btnBtnOnlyAppointment = new System.Windows.Forms.Button();
            this.lblDashBord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMAnageAdmin = new System.Windows.Forms.Button();
            this.pictureBoxAdminProfile = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlPaitentReg.SuspendLayout();
            this.pnlbill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReceHome
            // 
            this.pnlReceHome.BackColor = System.Drawing.Color.SlateGray;
            this.pnlReceHome.Location = new System.Drawing.Point(278, 0);
            this.pnlReceHome.Name = "pnlReceHome";
            this.pnlReceHome.Size = new System.Drawing.Size(1004, 695);
            this.pnlReceHome.TabIndex = 0;
            // 
            // pnlPaitentReg
            // 
            this.pnlPaitentReg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlPaitentReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPaitentReg.Controls.Add(this.btnPaitentReg);
            this.pnlPaitentReg.Controls.Add(this.lblbtnpRegText);
            this.pnlPaitentReg.Location = new System.Drawing.Point(19, 333);
            this.pnlPaitentReg.Name = "pnlPaitentReg";
            this.pnlPaitentReg.Size = new System.Drawing.Size(253, 86);
            this.pnlPaitentReg.TabIndex = 1;
            // 
            // btnPaitentReg
            // 
            this.btnPaitentReg.BackColor = System.Drawing.Color.Transparent;
            this.btnPaitentReg.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.Paitent_Icon;
            this.btnPaitentReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaitentReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaitentReg.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaitentReg.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPaitentReg.ImageKey = "(none)";
            this.btnPaitentReg.Location = new System.Drawing.Point(3, 20);
            this.btnPaitentReg.Name = "btnPaitentReg";
            this.btnPaitentReg.Size = new System.Drawing.Size(250, 61);
            this.btnPaitentReg.TabIndex = 7;
            this.btnPaitentReg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaitentReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaitentReg.UseVisualStyleBackColor = false;
            this.btnPaitentReg.Click += new System.EventHandler(this.btnPaitentReg_Click);
            // 
            // lblbtnpRegText
            // 
            this.lblbtnpRegText.BackColor = System.Drawing.Color.Transparent;
            this.lblbtnpRegText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnpRegText.Location = new System.Drawing.Point(52, -4);
            this.lblbtnpRegText.Name = "lblbtnpRegText";
            this.lblbtnpRegText.Size = new System.Drawing.Size(154, 29);
            this.lblbtnpRegText.TabIndex = 10;
            this.lblbtnpRegText.Text = "Manage Patient";
            // 
            // pnlbill
            // 
            this.pnlbill.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlbill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlbill.Controls.Add(this.lblBill);
            this.pnlbill.Controls.Add(this.btnBilling);
            this.pnlbill.Location = new System.Drawing.Point(22, 542);
            this.pnlbill.Name = "pnlbill";
            this.pnlbill.Size = new System.Drawing.Size(250, 87);
            this.pnlbill.TabIndex = 11;
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(83, -2);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(70, 29);
            this.lblBill.TabIndex = 12;
            this.lblBill.Text = "Billing";
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.Transparent;
            this.btnBilling.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.payment;
            this.btnBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilling.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBilling.ImageKey = "(none)";
            this.btnBilling.Location = new System.Drawing.Point(3, 24);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(243, 58);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblOnlyAPPtextbtn);
            this.panel1.Controls.Add(this.btnBtnOnlyAppointment);
            this.panel1.Location = new System.Drawing.Point(19, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 89);
            this.panel1.TabIndex = 9;
            // 
            // lblOnlyAPPtextbtn
            // 
            this.lblOnlyAPPtextbtn.BackColor = System.Drawing.Color.Transparent;
            this.lblOnlyAPPtextbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlyAPPtextbtn.Location = new System.Drawing.Point(39, 0);
            this.lblOnlyAPPtextbtn.Name = "lblOnlyAPPtextbtn";
            this.lblOnlyAPPtextbtn.Size = new System.Drawing.Size(158, 29);
            this.lblOnlyAPPtextbtn.TabIndex = 11;
            this.lblOnlyAPPtextbtn.Text = "Dr. Appointment";
            // 
            // btnBtnOnlyAppointment
            // 
            this.btnBtnOnlyAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnBtnOnlyAppointment.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.Appointment_Icon;
            this.btnBtnOnlyAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBtnOnlyAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBtnOnlyAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtnOnlyAppointment.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBtnOnlyAppointment.ImageKey = "(none)";
            this.btnBtnOnlyAppointment.Location = new System.Drawing.Point(3, 22);
            this.btnBtnOnlyAppointment.Name = "btnBtnOnlyAppointment";
            this.btnBtnOnlyAppointment.Size = new System.Drawing.Size(247, 61);
            this.btnBtnOnlyAppointment.TabIndex = 7;
            this.btnBtnOnlyAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBtnOnlyAppointment.UseVisualStyleBackColor = false;
            this.btnBtnOnlyAppointment.Click += new System.EventHandler(this.btnBtnOnlyAppointment_Click);
            // 
            // lblDashBord
            // 
            this.lblDashBord.AutoSize = true;
            this.lblDashBord.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBord.ForeColor = System.Drawing.Color.Azure;
            this.lblDashBord.Location = new System.Drawing.Point(72, 18);
            this.lblDashBord.Name = "lblDashBord";
            this.lblDashBord.Size = new System.Drawing.Size(173, 45);
            this.lblDashBord.TabIndex = 2;
            this.lblDashBord.Text = "Dashbord";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblDashBord);
            this.panel2.Controls.Add(this.pnlbill);
            this.panel2.Controls.Add(this.pnlPaitentReg);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnMAnageAdmin);
            this.panel2.Controls.Add(this.pictureBoxAdminProfile);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 681);
            this.panel2.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(97, 637);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 32);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMAnageAdmin
            // 
            this.btnMAnageAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMAnageAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAnageAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMAnageAdmin.Location = new System.Drawing.Point(37, 277);
            this.btnMAnageAdmin.Name = "btnMAnageAdmin";
            this.btnMAnageAdmin.Size = new System.Drawing.Size(208, 41);
            this.btnMAnageAdmin.TabIndex = 41;
            this.btnMAnageAdmin.Text = "Manage Info";
            this.btnMAnageAdmin.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAdminProfile
            // 
            this.pictureBoxAdminProfile.Image = global::WPA_HMS_pro.Properties.Resources.Reception_ioc;
            this.pictureBoxAdminProfile.Location = new System.Drawing.Point(80, 81);
            this.pictureBoxAdminProfile.Name = "pictureBoxAdminProfile";
            this.pictureBoxAdminProfile.Size = new System.Drawing.Size(145, 132);
            this.pictureBoxAdminProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdminProfile.TabIndex = 15;
            this.pictureBoxAdminProfile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(12, 216);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(275, 45);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name: ";
            // 
            // FrmReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlReceHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receptionist Home";
            this.pnlPaitentReg.ResumeLayout(false);
            this.pnlbill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReceHome;
        private System.Windows.Forms.Label lblDashBord;
        private System.Windows.Forms.Button btnPaitentReg;
        private System.Windows.Forms.Panel pnlPaitentReg;
        private System.Windows.Forms.Button btnBtnOnlyAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOnlyAPPtextbtn;
        private System.Windows.Forms.Label lblbtnpRegText;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Panel pnlbill;
        private System.Windows.Forms.Button btnBilling;
        private Panel panel2;
        private Button btnMAnageAdmin;
        private Label lblName;
        private PictureBox pictureBoxAdminProfile;
        private Button btnLogout;
    }
}