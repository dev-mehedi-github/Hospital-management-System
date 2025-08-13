using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WPA_HMS_pro
{
    public partial class FrmAddReceptionist : Form
    {
        private FrmAdminHome FrmAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FrmAddReceptionist()
        {
            InitializeComponent();
            
            this.AutoIdGenerate();
            this.Da = new DataAccess();
           
        }

        private string AutoIdGenerate()
        {
            var sql = "Select max(UserID) from LoginUsers where UserID like 'R-%';";

            if (this.Da == null)
                this.Da = new DataAccess();
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return "R-001";

            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            return "R-" + (++num).ToString("D3");
        }

        private void btnR_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtR_UserName.Text) ||
                 string.IsNullOrWhiteSpace(txtR_pass.Text) ||
                 string.IsNullOrWhiteSpace(textRName.Text) ||
                 string.IsNullOrWhiteSpace(txtRphone.Text) ||
                 string.IsNullOrWhiteSpace(txtRAddress.Text) ||
                 cmbR_Sex.SelectedIndex == -1 ||
                cmbRBloodGrp.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields before registering.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string id = this.AutoIdGenerate();
                var checkQuery=$"select count(*) from LoginUsers where Username = '{txtR_UserName.Text}' ;";
                DataTable dt = this.Da.ExecuteQueryTable(checkQuery);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Username already exists. Please use a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql1 = "insert into LoginUsers values('" + id + "', '" + txtR_UserName.Text + "', '" + txtR_pass.Text + "', 'receptionist');";
                int count1 = this.Da.ExecuteDMLQuery(sql1);

                string recId = "RC-" + id;
                string sql2 = "insert into Receptionists values('" + recId + "', '" + id + "', '" + textRName.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                    " '" + cmbR_Sex.Text + "', '" + txtRphone.Text + "', '" + txtRAddress.Text + "', '" + cmbRBloodGrp.Text + "');";
                int count2 = this.Da.ExecuteDMLQuery(sql2);

                if (count1 == 1 && count2 == 1){ MessageBox.Show("Receptionist added successfully.");}
                else {MessageBox.Show("Failed to add receptionist."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            textRName.Clear();
            txtR_UserName.Clear();
            txtR_pass.Clear();
            txtRAddress.Clear();
            txtRphone.Clear();
            cmbR_Sex.SelectedIndex = -1;
            cmbRBloodGrp.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUserControl(UserControl uc)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(uc); 
        }

        private void btnExistingREC_Click(object sender, EventArgs e)
        {
            var uc = new UC_Rece_MAnage(this);
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}       
    
