namespace WPA_HMS_pro
{
    partial class FrmAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminHome));
            this.pnlAdminHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSeeBills = new System.Windows.Forms.Panel();
            this.btnSeeBills = new System.Windows.Forms.Button();
            this.lblSeeBills = new System.Windows.Forms.Label();
            this.btnMAnageAdmin = new System.Windows.Forms.Button();
            this.pnlRecAdd = new System.Windows.Forms.Panel();
            this.btnRecAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddFacilities = new System.Windows.Forms.Panel();
            this.btnAddFacilities = new System.Windows.Forms.Button();
            this.lblManageFacilites = new System.Windows.Forms.Label();
            this.pictureBoxAdminProfile = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDashBord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlSeeBills.SuspendLayout();
            this.pnlRecAdd.SuspendLayout();
            this.pnlAddFacilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminHome
            // 
            this.pnlAdminHome.BackColor = System.Drawing.Color.Teal;
            this.pnlAdminHome.Location = new System.Drawing.Point(284, 1);
            this.pnlAdminHome.Name = "pnlAdminHome";
            this.pnlAdminHome.Size = new System.Drawing.Size(1000, 682);
            this.pnlAdminHome.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pnlSeeBills);
            this.panel1.Controls.Add(this.btnMAnageAdmin);
            this.panel1.Controls.Add(this.pnlRecAdd);
            this.panel1.Controls.Add(this.pnlAddFacilities);
            this.panel1.Controls.Add(this.pictureBoxAdminProfile);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblDashBord);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 689);
            this.panel1.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(91, 627);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 32);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSeeBills
            // 
            this.pnlSeeBills.BackColor = System.Drawing.Color.Teal;
            this.pnlSeeBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSeeBills.Controls.Add(this.btnSeeBills);
            this.pnlSeeBills.Controls.Add(this.lblSeeBills);
            this.pnlSeeBills.Location = new System.Drawing.Point(12, 518);
            this.pnlSeeBills.Name = "pnlSeeBills";
            this.pnlSeeBills.Size = new System.Drawing.Size(260, 82);
            this.pnlSeeBills.TabIndex = 14;
            // 
            // btnSeeBills
            // 
            this.btnSeeBills.BackColor = System.Drawing.Color.Transparent;
            this.btnSeeBills.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.payment;
            this.btnSeeBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeeBills.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeBills.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeBills.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSeeBills.ImageKey = "(none)";
            this.btnSeeBills.Location = new System.Drawing.Point(3, 23);
            this.btnSeeBills.Name = "btnSeeBills";
            this.btnSeeBills.Size = new System.Drawing.Size(254, 56);
            this.btnSeeBills.TabIndex = 7;
            this.btnSeeBills.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeeBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeeBills.UseVisualStyleBackColor = false;
            this.btnSeeBills.Click += new System.EventHandler(this.btnSeeBills_Click);
            // 
            // lblSeeBills
            // 
            this.lblSeeBills.BackColor = System.Drawing.Color.Transparent;
            this.lblSeeBills.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeBills.Location = new System.Drawing.Point(28, -4);
            this.lblSeeBills.Name = "lblSeeBills";
            this.lblSeeBills.Size = new System.Drawing.Size(211, 29);
            this.lblSeeBills.TabIndex = 10;
            this.lblSeeBills.Text = "See Bills";
            this.lblSeeBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMAnageAdmin
            // 
            this.btnMAnageAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMAnageAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAnageAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMAnageAdmin.Location = new System.Drawing.Point(37, 264);
            this.btnMAnageAdmin.Name = "btnMAnageAdmin";
            this.btnMAnageAdmin.Size = new System.Drawing.Size(208, 41);
            this.btnMAnageAdmin.TabIndex = 41;
            this.btnMAnageAdmin.Text = "Manage Info";
            this.btnMAnageAdmin.UseVisualStyleBackColor = false;
            this.btnMAnageAdmin.Click += new System.EventHandler(this.btnMAnageAdmin_Click_1);
            // 
            // pnlRecAdd
            // 
            this.pnlRecAdd.BackColor = System.Drawing.Color.Teal;
            this.pnlRecAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRecAdd.Controls.Add(this.btnRecAdd);
            this.pnlRecAdd.Controls.Add(this.label1);
            this.pnlRecAdd.Location = new System.Drawing.Point(12, 320);
            this.pnlRecAdd.Name = "pnlRecAdd";
            this.pnlRecAdd.Size = new System.Drawing.Size(260, 87);
            this.pnlRecAdd.TabIndex = 12;
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnRecAdd.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.receptionist;
            this.btnRecAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecAdd.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRecAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecAdd.ImageKey = "(none)";
            this.btnRecAdd.Location = new System.Drawing.Point(6, 23);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(251, 61);
            this.btnRecAdd.TabIndex = 7;
            this.btnRecAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRecAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecAdd.UseVisualStyleBackColor = false;
            this.btnRecAdd.Click += new System.EventHandler(this.btnRecAdd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Receptionist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAddFacilities
            // 
            this.pnlAddFacilities.BackColor = System.Drawing.Color.Teal;
            this.pnlAddFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlAddFacilities.Controls.Add(this.btnAddFacilities);
            this.pnlAddFacilities.Controls.Add(this.lblManageFacilites);
            this.pnlAddFacilities.Location = new System.Drawing.Point(12, 423);
            this.pnlAddFacilities.Name = "pnlAddFacilities";
            this.pnlAddFacilities.Size = new System.Drawing.Size(260, 79);
            this.pnlAddFacilities.TabIndex = 15;
            // 
            // btnAddFacilities
            // 
            this.btnAddFacilities.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFacilities.BackgroundImage = global::WPA_HMS_pro.Properties.Resources.add;
            this.btnAddFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFacilities.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFacilities.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddFacilities.ImageKey = "(none)";
            this.btnAddFacilities.Location = new System.Drawing.Point(3, 20);
            this.btnAddFacilities.Name = "btnAddFacilities";
            this.btnAddFacilities.Size = new System.Drawing.Size(254, 56);
            this.btnAddFacilities.TabIndex = 7;
            this.btnAddFacilities.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddFacilities.UseVisualStyleBackColor = false;
            this.btnAddFacilities.Click += new System.EventHandler(this.btnAddFacilities_Click);
            // 
            // lblManageFacilites
            // 
            this.lblManageFacilites.BackColor = System.Drawing.Color.Transparent;
            this.lblManageFacilites.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageFacilites.Location = new System.Drawing.Point(29, -6);
            this.lblManageFacilites.Name = "lblManageFacilites";
            this.lblManageFacilites.Size = new System.Drawing.Size(211, 29);
            this.lblManageFacilites.TabIndex = 10;
            this.lblManageFacilites.Text = "Manage Facilities";
            this.lblManageFacilites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAdminProfile
            // 
            this.pictureBoxAdminProfile.Image = global::WPA_HMS_pro.Properties.Resources.Ad;
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
            // lblDashBord
            // 
            this.lblDashBord.AutoSize = true;
            this.lblDashBord.BackColor = System.Drawing.Color.GreenYellow;
            this.lblDashBord.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBord.ForeColor = System.Drawing.Color.Teal;
            this.lblDashBord.Location = new System.Drawing.Point(72, 8);
            this.lblDashBord.Name = "lblDashBord";
            this.lblDashBord.Size = new System.Drawing.Size(173, 45);
            this.lblDashBord.TabIndex = 13;
            this.lblDashBord.Text = "Dashbord";
            // 
            // FrmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdminHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSeeBills.ResumeLayout(false);
            this.pnlRecAdd.ResumeLayout(false);
            this.pnlAddFacilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.Panel pnlAdminHome;
        //internal System.Windows.Forms.Panel pnlAdminHome;
        public System.Windows.Forms.Panel pnlAdminHome;


        private System.Windows.Forms.Panel pnlRecAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecAdd;
        private System.Windows.Forms.Label lblDashBord;
        private System.Windows.Forms.Panel pnlSeeBills;
        private System.Windows.Forms.Label lblSeeBills;
        private System.Windows.Forms.Button btnSeeBills;
        private System.Windows.Forms.Panel pnlAddFacilities;
        private System.Windows.Forms.Label lblManageFacilites;
        private System.Windows.Forms.Button btnAddFacilities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBoxAdminProfile;
        private System.Windows.Forms.Button btnMAnageAdmin;
        private System.Windows.Forms.Button btnLogout;
    }
}