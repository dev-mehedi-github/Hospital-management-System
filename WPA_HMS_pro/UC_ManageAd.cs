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
    public partial class UC_ManageAd : UserControl
    {
        private FrmAdminHome frmAdminHome { get; set; }
        private DataAccess Da;
        public UC_ManageAd(FrmAdminHome frmAdminHome)
        {
            InitializeComponent();
            this.frmAdminHome = frmAdminHome;
            this.Da = new DataAccess();
            this.AutoGenerateAdminID();
            this.PopulateAdminGrid();
        }
        private void PopulateAdminGrid()
        {
            string sql = "Select UserID, Username,Password, Role from LoginUsers where Role = 'admin'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            dgvAdmins.AutoGenerateColumns = true;
            dgvAdmins.DataSource = dt;
        }
        private void UC_ManageAd_Load(object sender, EventArgs e)
        {
            this.PopulateAdminGrid();
        }

        private string AutoGenerateAdminID()
        {
            string sql = "Select max(UserID) from LoginUsers where UserID LIKE 'A-%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return "A-001";
            string oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            return "A-" + (++num).ToString("D3");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = this.frmAdminHome.AdminUserID;
                string sql = "Update LoginUsers  Usetername = '" + txtNewUsername.Text + "', Password = '" + txtNewPassword.Text + "' where UserID = '" + userId + "' AND Role = 'admin'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1) MessageBox.Show("Admin details updated successfully.");
                else MessageBox.Show("Failed to update admin details. Please try again.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string newId = AutoGenerateAdminID();
                var checkSql = "select count(*) from LoginUsers where Username = '" + txtAdminUsername.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0) { MessageBox.Show("Username already exists."); return; }

                var sql = "Insert into LoginUsers values('" + newId + "', '" + txtAdminUsername.Text + "', '" + txtAdminPassword.Text + "', 'admin')";
                int count = this.Da.ExecuteDMLQuery(sql);
                PopulateAdminGrid();
                if (count == 1) {MessageBox.Show("New admin added successfully "); txtAdminUsername.Clear(); txtAdminPassword.Clear();} 
                else MessageBox.Show("Failed to add new admin. Please try again."); 
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0) { MessageBox.Show("Please select an admin to remove.");return;}
            
            string userId = dgvAdmins.SelectedRows[0].Cells[0].Value.ToString();
            try{
                string sql = $"Delete from LoginUsers where UserID = '{userId}' AND Role = 'admin'";
                int count = this.Da.ExecuteDMLQuery(sql);
                PopulateAdminGrid();
                if (count == 1) MessageBox.Show("Admin removed successfully.");
                else MessageBox.Show("Failed to remove admin. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

