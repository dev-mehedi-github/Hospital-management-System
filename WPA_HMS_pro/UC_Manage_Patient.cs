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
    public partial class UC_Manage_Patient : UserControl
    {
        private FrmReceptionist fr { get; set; }

        private DataAccess Da;

        public UC_Manage_Patient(FrmReceptionist fr)
        {
            InitializeComponent();
            this.fr = fr;
            this.Da = new DataAccess();
            LoadTestInfo();
            LoadCabinnfo();
            LoadDoctors();
            LoadAvailableCabins();
           
        }
        private string AutoGenerateID(string table, string col, string prefix)
        {
           
            string sql = $"Select max({col}) from {table} where {col} like '{prefix}%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            if (dt.Rows[0][0] == DBNull.Value)
                return prefix + "001";

            string lastId = dt.Rows[0][0].ToString();
            int num = Convert.ToInt32(lastId.Split('-')[1]);
            return prefix + (++num).ToString("D3");
        }



        private void LoadTestInfo(string sql = "select * from Tests;")
        {
            var dt = Da.ExecuteQuery(sql).Tables[0];
            if (dgvTestinfo.Columns.Contains("Select"))
                dgvTestinfo.Columns.Remove("Select");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Select";
            chk.HeaderText = "Select";
            chk.Width = 50;
            chk.DataPropertyName = "";
            dgvTestinfo.Columns.Insert(0, chk);
            dgvTestinfo.DataSource = dt;

        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            dgvSelectedTest.DataSource = null;
            dgvSelectedTest.Rows.Clear();
            foreach (DataGridViewRow item in dgvTestinfo.Rows)
            {
                var cellValue = item.Cells[0].Value;
                if (cellValue != null && Convert.ToBoolean(cellValue) == true)
                {
                    int n = dgvSelectedTest.Rows.Add();
                    dgvSelectedTest.Rows[n].Cells[0].Value = item.Cells[1].Value?.ToString();
                    dgvSelectedTest.Rows[n].Cells[1].Value = item.Cells[2].Value?.ToString();
                    dgvSelectedTest.Rows[n].Cells[2].Value = item.Cells[3].Value?.ToString();
                }
            }
            CalculateInvoiceTotal();

        }
        private void btnRemoveTest_Click(object sender, EventArgs e)
        {
            if (dgvSelectedTest.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSelectedTest.SelectedRows)
                {
                    dgvSelectedTest.Rows.Remove(row);
                }

                CalculateInvoiceTotal();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }

        }

        private void dgvTestinfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvTestinfo.SelectedRows.Count > 0)
            {
                var row = dgvTestinfo.SelectedRows[0];
                bool current = Convert.ToBoolean(row.Cells[0].Value);
                row.Cells[0].Value = !current; 
            }
        }

        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Tests where TestName like '%" + txtSearchTest.Text + "%' ;";
            LoadTestInfo(sql);

        }

        private void CalculateInvoiceTotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvSelectedTest.Rows)
            {
                if (row.Cells[2].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells[2].Value);
            }

            decimal vatAmount = 0;
            decimal discountAmount = 0;

            if (!string.IsNullOrWhiteSpace(txtVAT.Text))
            {
                string vatText = txtVAT.Text.Trim().Replace("%", "");
                if (decimal.TryParse(vatText, out decimal vatPercent))
                    vatAmount = subtotal * (vatPercent / 100);
            }

            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                string discountText = txtDiscount.Text.Trim().Replace("%", "");
                if (decimal.TryParse(discountText, out decimal discountPercent))
                    discountAmount = subtotal * (discountPercent / 100);
            }

            decimal total = subtotal + vatAmount - discountAmount;


            lblSubtotal.Text = "Subtotal = " + subtotal.ToString("0.00") + " TK";
            lblTotal.Text = "Total = " + total.ToString("0.00") + " TK";
        }


        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void LoadDoctors()
        {
            string sql = "select DoctorID, DoctorName from Doctors;";
            
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            cmbDoctor.DataSource = dt;
            cmbDoctor.DisplayMember = "DoctorName";
            cmbDoctor.ValueMember = "DoctorID";
            cmbDoctor.SelectedIndex = -1;

            
        }
        private void LoadAvailableCabins()
        {
            string sql = "select CabinID, CabinName,Price from Cabins where IsAvailable = 1;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            cmbCabin.DataSource = dt;
            cmbCabin.DisplayMember = "CabinName";
            cmbCabin.ValueMember = "CabinID";
            cmbCabin.SelectedIndex = -1;
        }
        private void LoadCabinnfo(string sql = "select * from Cabins;")
        {
            var dt = Da.ExecuteQuery(sql).Tables[0];
            dgvAdmissionInvoice.DataSource = dt;
            dgvAdmissionInvoice.AutoGenerateColumns = false;
        }

        private void btnP_Register_Click(object sender, EventArgs e)
        {
            try
            {
                string patientId = AutoGenerateID("Patients", "PatientID", "P-");
                string cabinId = cmbCabin.SelectedValue?.ToString();
                string doctorId = cmbDoctor.SelectedValue?.ToString();
                bool isAdmitted = !string.IsNullOrEmpty(cabinId);
                string today = DateTime.Now.ToString("yyyy-MM-dd");

                // Insert into Patients
                string sql1 = $@"insert into Patients (PatientID, Name, Age, Gender, Phone, Address, BloodGroup, DoctorID, CabinID, IsAdmitted, RegisterDate)
                 VALUES (
                '{patientId}',
                '{txtPName.Text.Trim()}',
                '{txtAge.Text.Trim()}',
                '{cmbGender.Text}',
                '{txtPhone.Text.Trim()}',
                '{txtAddress.Text.Trim()}',
                '{cmbBloodGroup.Text}',
                {(string.IsNullOrEmpty(doctorId) ? "NULL" : $"'{doctorId}'")},
                {(isAdmitted ? $"'{cabinId}'" : "NULL")},
                {(isAdmitted ? 1 : 0)},
                '{today}')";

                int result1 = this.Da.ExecuteDMLQuery(sql1);

                // Update Cabin if admitted
                decimal cabinPrice = 0;
                if (isAdmitted)
                {
                    string updateCabin = $"Update Cabins set IsAvailable = 0 where CabinID = '{cabinId}'";
                    this.Da.ExecuteDMLQuery(updateCabin);

                    // Get cabin price
                    string sqlCabinPrice = $"Select Price from Cabins where CabinID = '{cabinId}'";
                    DataTable dt = this.Da.ExecuteQueryTable(sqlCabinPrice);
                    if (dt.Rows.Count == 1)
                        cabinPrice = Convert.ToDecimal(dt.Rows[0]["Price"]);
                }

                // Insert selected tests
                decimal subtotal = 0;
                foreach (DataGridViewRow row in dgvSelectedTest.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string testId = row.Cells[0].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells[2].Value);
                        subtotal += price;

                        string sqlTest = $"insert into PatientTests(PatientID, TestID) VALUES('{patientId}', '{testId}')";
                        this.Da.ExecuteDMLQuery(sqlTest);
                    }
                }

                //  VAT, Discount
                decimal vat = 0, discount = 0;
                if (!string.IsNullOrWhiteSpace(txtVAT.Text))
                {
                    string vatText = txtVAT.Text.Replace("%", "").Trim();
                    if (decimal.TryParse(vatText, out decimal vatPercent))
                        vat = subtotal * (vatPercent / 100);
                }

                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    string disText = txtDiscount.Text.Replace("%", "").Trim();
                    if (decimal.TryParse(disText, out decimal disPercent))
                        discount = subtotal * (disPercent / 100);
                }

                decimal total = subtotal + vat - discount + cabinPrice;

                //  Save all to PatientBills
                string billSql = $@"insert into PatientBills (PatientID, Subtotal, VAT, Discount, TotalAmount, CabinPrice, RegisterDate)
                where ('{patientId}', {subtotal}, {vat}, {discount}, {total}, {cabinPrice}, '{today}')";

                this.Da.ExecuteDMLQuery(billSql);

                MessageBox.Show("Patient Registered and Bill Saved.");
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearAllFields()
        {
            txtPName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            cmbCabin.SelectedIndex = -1;
            dgvSelectedTest.Rows.Clear();
            txtVAT.Clear();
            txtDiscount.Clear();
            lblSubtotal.Text = "Subtotal = 0.00 TK";
            lblTotal.Text = "Total = 0.00 TK";
        }

        private void cmbCabin_MouseClick(object sender, MouseEventArgs e)
        {
            LoadAvailableCabins();

        }

        private void btnRecipt_Click(object sender, EventArgs e)
        {
            string patientId = AutoGenerateID("Patients", "PatientID", "P-");
            string name = txtPName.Text.Trim();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string doctor = cmbDoctor.Text;
            string admissionStatus;
            if (cmbCabin.SelectedValue != null)
            {
                admissionStatus = "Admitted";
            }
            else
            {
                admissionStatus = "Not Admitted";
            }
            string cabinName = cmbCabin.Text;

            // Test details
            StringBuilder testDetails = new StringBuilder();
            testDetails.AppendLine("Test Name\tPrice");
            foreach (DataGridViewRow row in dgvSelectedTest.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    testDetails.AppendLine($"{row.Cells[1].Value}\t{row.Cells[2].Value} TK");
                }
            }

            // Totals
            string subtotal = lblSubtotal.Text;
            string vat;
            if (string.IsNullOrWhiteSpace(txtVAT.Text))
            {
                vat = "VAT = 0 %";
            }
            else
            {
                vat = "VAT = " + txtVAT.Text + " %";
            }

            string discount;
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                discount = "Discount = 0 %";
            }
            else
            {
                discount = "Discount = " + txtDiscount.Text + " %";
            }
            string total = lblTotal.Text;

            // Design receipt
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("----- Patient Receipt -----");
            receipt.AppendLine($"Patient ID: {patientId}");
            receipt.AppendLine($"Name: {name}");
            receipt.AppendLine($"Date: {date}");
            receipt.AppendLine($"Doctor: {doctor}");
            receipt.AppendLine($"Admission Status: {admissionStatus}");
            receipt.AppendLine($"Cabin Name: {cabinName}");
            receipt.AppendLine();
            receipt.AppendLine(testDetails.ToString());
            receipt.AppendLine(subtotal);
            receipt.AppendLine(vat);
            receipt.AppendLine(discount);
            receipt.AppendLine(total);
            receipt.AppendLine("--------------------------");

            MessageBox.Show(receipt.ToString(), "Receipt");

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}


