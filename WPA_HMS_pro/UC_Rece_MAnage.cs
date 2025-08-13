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
    public partial class UC_Rece_MAnage : UserControl
    {
        private FrmAddReceptionist addRecForm { get; set; }
        public DataAccess Da { get; set; }
        public UC_Rece_MAnage(FrmAddReceptionist addRecForm)
        {
            InitializeComponent();
            this.addRecForm = addRecForm;
            
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "Select * from Receptionists;")
        {
            if (this.Da == null)
                this.Da = new DataAccess();
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvReceptionist.AutoGenerateColumns = true; 
            this.dgvReceptionist.DataSource = ds.Tables[0];
        }
        


        private void UC_Rece_MAnage_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            string sql = "Select * from Receptionists where Name LIKE '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {

            if (dgvReceptionist.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a receptionist to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string recId = dgvReceptionist.CurrentRow.Cells["ReceptionistID"].Value.ToString();
            string userId = dgvReceptionist.CurrentRow.Cells["UserID"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this receptionist?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql1 = $"Delete from Receptionists where ReceptionistID = '{recId}'";
                string sql2 = $"Delete from LoginUsers where UserID = '{userId}'";

                int r1 = this.Da.ExecuteDMLQuery(sql1);
                int r2 = this.Da.ExecuteDMLQuery(sql2);

                if (r1 == 1 && r2 == 1)
                {
                    MessageBox.Show("Receptionist deleted successfully.");
                    this.PopulateGridView(); 
                }
                else
                {
                    MessageBox.Show("Failed to delete receptionist.");
                }
            }
        }
    }
}

