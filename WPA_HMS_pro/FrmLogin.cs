using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPA_HMS_pro
{
    public partial class FrmLogin : Form
    {
        private DataAccess Da { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        { 
            txtPassword.UseSystemPasswordChar = !chkBox.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from LoginUsers where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var userId = ds.Tables[0].Rows[0]["UserID"].ToString();
                    var name = ds.Tables[0].Rows[0]["Username"].ToString();
                    var role = ds.Tables[0].Rows[0]["Role"].ToString().ToLower();
                    this.Visible = false;
                    this.Hide();

                    if (role == "admin") new FrmAdminHome(userId,name, this).Visible = true;
                    
                    else if (role == "receptionist") new FrmReceptionist(name, this).Visible = true;
                }
                else MessageBox.Show("Invalid User ");
            } catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
           // this.Cursor = Cursors.Hand;
            this.btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            this.btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
           // this.Cursor = Cursors.Default;
            this.btnLogin.BackColor = Color.SteelBlue;
            this.btnLogin.ForeColor = Color.WhiteSmoke;

        }
    }
}
