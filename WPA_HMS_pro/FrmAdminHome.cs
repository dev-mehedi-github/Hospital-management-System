using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPA_HMS_pro
{
    
    public partial class FrmAdminHome : Form
    {
        private FrmLogin Fl { get; set; }
        internal string AdminUserID { get; set; }
        internal string AdminUsername { get; set; }
        public FrmAdminHome()
        {
            InitializeComponent();
            
        }
       
        public FrmAdminHome (string userId, string name,FrmLogin fl) :this ()
        {
            this.Fl = fl;
            this.lblName.Text = "Welcome, " + name + "!";
            this.AdminUserID = userId;
        }

        internal void LoadUserControl(UserControl uc)
        {
            this.pnlAdminHome.Controls.Clear();           
            this.pnlAdminHome.Controls.Add(uc);
        }

        private void btnAddFacilities_Click(object sender, EventArgs e)
        {
            UC_Facilities uc = new UC_Facilities(this); 
            pnlAdminHome.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlAdminHome.Controls.Add(uc);
        }

        private void btnRecAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddReceptionist addRec = new FrmAddReceptionist();
            addRec.ShowDialog();
            this.Show();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeeBills_Click(object sender, EventArgs e)
        {
            UC_AdminBills uc = new UC_AdminBills(this);
            pnlAdminHome.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlAdminHome.Controls.Add(uc);
        }

        private void btnMAnageAdmin_Click_1(object sender, EventArgs e)
        {
            UC_ManageAd uc = new UC_ManageAd(this);
            pnlAdminHome.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlAdminHome.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Fl.Visible = true;
            Fl.Show();
            this.Close();
        }
    }
}
