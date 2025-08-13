using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WPA_HMS_pro
{
    public partial class FrmReceptionist : Form
    {
       private FrmLogin Fl { get; set; }
        public FrmReceptionist()
        {
            InitializeComponent();

        }
        public FrmReceptionist( string name,FrmLogin fl) : this()
        {
            this.Fl = fl;
            this.lblName.Text= "Welcome " + name + "!";

        }
        internal void LoadUserControl(UserControl uc)
        {
            this.pnlReceHome.Controls.Clear();
            this.pnlReceHome.Controls.Add(uc);
        }

        private void btnPaitentReg_Click(object sender, EventArgs e)
        {
            UC_Manage_Patient uc = new UC_Manage_Patient(this);
            pnlReceHome.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlReceHome.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Fl.Visible = true;
            this.Fl.Show();
            
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Uc_PaitentBill puc = new Uc_PaitentBill(this);
            pnlReceHome.Controls.Clear();
            puc.Dock = DockStyle.Fill;
            pnlReceHome.Controls.Add(puc);
        }

        private void btnBtnOnlyAppointment_Click(object sender, EventArgs e)
        {
            UC_Appointment auc = new UC_Appointment(this);
            pnlReceHome.Controls.Clear();
            auc.Dock = DockStyle.Fill;
            pnlReceHome.Controls.Add(auc);
        }
    }
}
