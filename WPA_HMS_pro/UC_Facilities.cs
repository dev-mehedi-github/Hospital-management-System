using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPA_HMS_pro
{
    public partial class UC_Facilities : UserControl
    {
        private DataAccess Da;
        private FrmAdminHome AdminRef { get; set; }

        public UC_Facilities(FrmAdminHome AdminRef)
        {
            InitializeComponent();
            this.AdminRef = AdminRef;
            this.Da = new DataAccess();

        }

        private void btnviewDeptTable_Click(object sender, EventArgs e)
        {
            pnlViewtbl.Visible = true;
            pnlViewtbl.BringToFront();
            PopulateDeptGrid();
            PopulateDoctorGrid();
            PopulateTestGrid();
            PopulateCabinGrid();
        }

        private void PopulateDeptGrid(string sql = "Select * from Departments;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvDept.AutoGenerateColumns = true;
            dgvDept.DataSource = ds.Tables[0];
        }

        private void PopulateDoctorGrid(string sql = "Select * from Doctors;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvDr.AutoGenerateColumns = true;
            dgvDr.DataSource = ds.Tables[0];
        }

        private void PopulateTestGrid(string sql = "Select * from Tests;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvTest.AutoGenerateColumns = true;
            dgvTest.DataSource = ds.Tables[0];
        }

        private void PopulateCabinGrid(string sql = "Select * from Cabins;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvCabin.AutoGenerateColumns = true;
            dgvCabin.DataSource = ds.Tables[0];
        }


        private void pnlViewtbl_Paint(object sender, PaintEventArgs e)
        {
            pnlCabintbl.Visible = true;
            pnlDeptView.Visible = true;
            pnlDeptView.Visible = true;
            pnlTesttbl.Visible = true;

        }

        private void btnclosepnl_Click(object sender, EventArgs e)
        {
            pnlViewtbl.Visible = false;
        }

        private string AutoGenerateID(string table, string column, string prefix)
        {
            string sql = $"Select max({column}) from {table} where {column} LIKE '{prefix}%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            if (dt.Rows[0][0] == DBNull.Value)
                return prefix + "101";

            string lastId = dt.Rows[0][0].ToString();
            int number = Convert.ToInt32(lastId.Split('-')[1]);
            return prefix + (number + 1);
        }

        private void btnSaveDept_Click(object sender, EventArgs e)
        {
            try
            {
                string deptId = AutoGenerateID("Departments", "DeptID", "D-");
                string checkSql = "select count(*) from Departments where DeptName = '" + txtDeptName.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This department already exists.");
                    return;
                }

                string sql = "insert into Departments values('" + deptId + "', '" + txtDeptName.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Dept added in the list");
                    txtDeptName.Clear();
                }
                else
                    MessageBox.Show("Not added in the list");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string docId = AutoGenerateID("Doctors", "DoctorID", "DR-");
                string checkSql = "select count(*) from Doctors where DoctorName = '" + this.txtDocName.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This doctor already exists.");
                    return;
                }

                var sql = "insert into Doctors values('" + docId + "', '" + this.txtDocName.Text + "', '" + this.txtSpecialization.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data in the list");
                    txtDocName.Clear();
                    txtSpecialization.Clear();
                }   
                else
                    MessageBox.Show("Not added in the list");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {

            try
            {
                string testId = AutoGenerateID("Tests", "TestID", "T-");
                string checkSql = "select count(*) from Tests where TestName = '" + this.txtTestName.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This test already exists.");
                    return;
                }

                var sql = "insert into Tests VALUES('" + testId + "', '" + this.txtTestName.Text + "', " + this.txtTestPrice.Text + ");";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data in the list");
                    txtTestName.Clear();
                    txtTestPrice.Clear();
                }
                else
                    MessageBox.Show("Not added in the list");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSaveCabin_Click(object sender, EventArgs e)
        {
            try
            {
                string cabId = AutoGenerateID("Cabins", "CabinID", "C-");
                string checkSql = "select count(*) from Cabins where CabinNumber = '" + txtCabinNo.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This cabin number already exists.");
                    return;
                }

                string sql = "insert into Cabins VALUES('" + cabId + "', '" + txtCabinNo.Text + "', '" + txtCabinName.Text + "', " + txtCabinPrice.Text + ", '" + cmbAvailability.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Cabin data in the list");
                    txtCabinNo.Clear();
                    txtCabinName.Clear();
                    txtCabinPrice.Clear();
                    cmbAvailability.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Not added in the list");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchDept_Click(object sender, EventArgs e)
        {
            var sql = "Select * from Departments where DeptName LIKE '%" + txtSearchDept.Text + "%'";
            this.PopulateDeptGrid(sql);
        }


        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDept.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a department to delete.");
                    return;
                }

                string deptId = dgvDept.CurrentRow.Cells[0].Value.ToString();
                string deptName = dgvDept.CurrentRow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure to delete: " + deptName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                string sql = "Delete from Departments where DeptID = '" + deptId + "'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Department deleted successfully.");
                else
                    MessageBox.Show("Failed to delete department.");

                PopulateDeptGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSrchDept_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchDept.Text))
            {
                dgvDept.DataSource = null;
                return;
            }

            var sql = "Select * from Departments where DeptName LIKE '%" + txtSearchDept.Text + "%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            dgvDept.AutoGenerateColumns = true;
            dgvDept.DataSource = dt;
        }

        private void txtSrchDr_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSrchDr.Text))
            {
                dgvDr.DataSource = null;
                return;
            }
            var sql = "Select * from Doctors where DoctorName LIKE '%" + txtSrchDr.Text + "%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            dgvDr.AutoGenerateColumns = false;
            dgvDr.DataSource = dt;
        }

        private void btnSrchDoc_Click(object sender, EventArgs e)
        {
            var sql = "Select * FROM Doctors where DoctorName LIKE '%" + txtSrchDr.Text + "%'";
            this.PopulateDoctorGrid(sql);
        }

        private void btnDltDr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDr.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a doctor to delete.");
                    return;
                }
                string docId = dgvDr.CurrentRow.Cells[0].Value.ToString();
                string docName = dgvDr.CurrentRow.Cells[1].Value.ToString();
                string specialization = dgvDr.CurrentRow.Cells[2].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                string sql = "Delete from Doctors where DoctorID = '" + docId + "'";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show("Doctor deleted successfully.");
                else
                    MessageBox.Show("Failed to delete doctor.");
                PopulateDoctorGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSrchTest_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSrchTest.Text))
            {
                dgvTest.DataSource = null;
                return;
            }
           var sql = "select * from Tests where TestName LIKE '%" + txtSrchTest.Text + "%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            dgvTest.AutoGenerateColumns = true;
            dgvTest.DataSource = dt;
        }

        private void btnSrchTest_Click(object sender, EventArgs e)
        {
            var sql = "Select * from Tests where TestName LIKE '%" + txtSrchTest.Text + "%'";
            this.PopulateTestGrid(sql);
        }

        private void btnDltTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTest.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a test to delete.");
                    return;
                }
                string testId = dgvTest.CurrentRow.Cells[0].Value.ToString();
                string testName = dgvTest.CurrentRow.Cells[1].Value.ToString();
                double price = Convert.ToDouble(dgvTest.CurrentRow.Cells[2].Value);
                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
                string sql = "Delete from Tests where TestID = '" + testId + "'";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show("Test deleted successfully.");
                else
                    MessageBox.Show("Failed to delete test.");
                PopulateTestGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCabinSrch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCabinSrch.Text))
            {
                dgvCabin.DataSource = null;
                return;
            }
            var sql= "select * from Cabins where CabinNumber LIKE '%" + txtCabinSrch.Text + "%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            dgvCabin.AutoGenerateColumns = true;
            dgvCabin.DataSource = dt;
        }

        private void btnSearchCabin_Click(object sender, EventArgs e)
        {
            var sql = "Select * from Cabins where CabinNumber LIKE '%" + txtCabinSrch.Text + "%'";
            this.PopulateCabinGrid(sql);
        }

        private void btnDltCabin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCabin.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a cabin to delete.");
                    return;
                }
                string cabinId = dgvCabin.CurrentRow.Cells[0].Value.ToString();
                string cabinNumber = dgvCabin.CurrentRow.Cells[1].Value.ToString();
                string cabinName = dgvCabin.CurrentRow.Cells[2].Value.ToString();
                double price = Convert.ToDouble(dgvCabin.CurrentRow.Cells[3].Value);
                string availability = dgvCabin.CurrentRow.Cells[4].Value.ToString();
                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
                string sql = "Delete from Cabins where CabinID = '" + cabinId + "'";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show("Cabin deleted successfully.");
                else
                    MessageBox.Show("Failed to delete cabin.");
                PopulateCabinGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

