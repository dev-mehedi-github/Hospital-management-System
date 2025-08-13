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
    public partial class UC_AdminBills : UserControl
    {
        private FrmAdminHome fAH { get; set; }
        private DataAccess Da;
        public UC_AdminBills(FrmAdminHome fAH)
        {
            InitializeComponent();
            this.fAH = fAH;
            this.Da = new DataAccess();
           // LoadPatientBillingSummary();
        }
 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string patientId = txtSearchPatientID.Text.Trim();
            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Please enter a Patient ID.");
                return;
            }

            //  Get Patient Info
           // string sqlPatient = $"SELECT * FROM Patients WHERE PatientID = '{patientId}'";
            var sqlPatient = $"Select * from Patients where PatientID = '{patientId}'";
            var dtPatient = this.Da.ExecuteQueryTable(sqlPatient);
            if (dtPatient.Rows.Count == 0)
            {
                MessageBox.Show("Patient not found.");
                return;
            }

            var patient = dtPatient.Rows[0];
            lblBillPatientID.Text +=  patient["PatientID"].ToString();
            lblBillPatientName.Text +=  patient["Name"].ToString();
            if (Convert.ToBoolean(patient["IsAdmitted"]))
            {
                lblBillAdmissionStatus.Text += "Admitted";
            }
            else
            {
                lblBillAdmissionStatus.Text += "Not Admitted";
            }

            //lblBillAdmissionStatus.Text +=  (Convert.ToBoolean(patient["IsAdmitted"]) ? "Admitted" : "Not Admitted");

            //  Doc Info
            string docId = patient["DoctorID"]?.ToString();
            if (!string.IsNullOrEmpty(docId))
            {
                string docSql = $"Select DoctorName from Doctors where DoctorID = '{docId}'";
                var dtDoc = this.Da.ExecuteQueryTable(docSql);
                if (dtDoc.Rows.Count == 1)
                    lblBillDoctor.Text += dtDoc.Rows[0]["DoctorName"].ToString();
                else
                    lblBillDoctor.Text += " N/A";
                //lblBillDoctor.Text += dtDoc.Rows.Count == 1 ?   dtDoc.Rows[0]["DoctorName"].ToString() : " N/A";
            }
            else
            {
                lblBillDoctor.Text += " N/A";
            }

            // Cabin Info
            if (patient["CabinID"] != DBNull.Value)
            {
                string cabinSql = $"Select CabinName, Price FROM Cabins where CabinID = '{patient["CabinID"]}'";
                var dtCabin = this.Da.ExecuteQueryTable(cabinSql);
                if (dtCabin.Rows.Count == 1)
                {
                    lblBillCabinName.Text += dtCabin.Rows[0]["CabinName"].ToString();
                    lblBillCabinPrice.Text +=  Convert.ToDecimal(dtCabin.Rows[0]["Price"]).ToString("0.00") + " TK";
                }
            }
            else
            {
                lblBillCabinName.Text += " N/A";
                lblBillCabinPrice.Text += ": 0.00 TK";
            }

            // Bill Info
            string sqlBill = $"Select * from PatientBills where PatientID = '{patientId}'";
            var dtBill = this.Da.ExecuteQueryTable(sqlBill);
            if (dtBill.Rows.Count == 1)
            {
                var bill = dtBill.Rows[0];
                lblBillSubtotal.Text += Convert.ToDecimal(bill["Subtotal"]).ToString("0.00") + " TK";
                lblBillVAT.Text +=  Convert.ToDecimal(bill["VAT"]).ToString("0.00") + " TK";
                lblBillDiscount.Text +=  Convert.ToDecimal(bill["Discount"]).ToString("0.00") + " TK";
                lblBillTotal.Text += Convert.ToDecimal(bill["TotalAmount"]).ToString("0.00") + " TK";
                lblRegisterDate.Text +=  Convert.ToDateTime(bill["RegisterDate"]).ToString("dd-MMM-yyyy");

                if (bill["DischargeDate"] != DBNull.Value)
                    lblDischargeDate.Text +=  Convert.ToDateTime(bill["DischargeDate"]).ToString("dd-MMM-yyyy");
                else
                    lblDischargeDate.Text += " N/A";
            }
            else
            {
                lblBillSubtotal.Text += " N/A";
                lblBillVAT.Text += " N/A";
                lblBillDiscount.Text += " N/A";
                lblBillTotal.Text += " N/A";
                lblRegisterDate.Text += " N/A";
                lblDischargeDate.Text += " N/A";
            }

            
            string sqlTests = $@"select T.TestName, T.Price from PatientTests PT JOIN Tests T ON PT.TestID = T.TestID where PT.PatientID = '{patientId}'";
            dgvBillTests.DataSource = this.Da.ExecuteQuery(sqlTests).Tables[0];

            
        }

        private void btnDeletePatientHistory_Click(object sender, EventArgs e)
        {
            string patientId = txtSearchPatientID.Text.Trim();

            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Enter a Patient ID");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to delete all records of this patient?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //  Dlt test 
                    string sql1 = $"delete from PatientTests where PatientID = '{patientId}'";
                    Da.ExecuteDMLQuery(sql1);

                    // dlt patient bills
                    string sql2 = $"delete from PatientBills where PatientID = '{patientId}'";
                    Da.ExecuteDMLQuery(sql2);

                    // Update cabin availability if admitted
                    string sqlCabinUpdate = $@"update Cabins set IsAvailable = 1 
                    where CabinID = (select CabinID from Patients where PatientID = '{patientId}' AND CabinID IS NOT NULL)";
                    Da.ExecuteDMLQuery(sqlCabinUpdate);

                    // dlt Patients
                    string sql3 = $"delete from Patients where PatientID = '{patientId}'";
                    Da.ExecuteDMLQuery(sql3);

                    MessageBox.Show("Patient history deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        //private void LoadPatientBillingSummary()
        //{
        //   string sql = 
        //    DataAccess da = new DataAccess();
        //    //DataTable dt = da.ExecuteQueryTable(sql);
        //    //dgvBillingSummary.DataSource = dt;
        //    // Adjust column widths
        //    dgvBillingSummary.Columns["PatientID"].Width = 100;
        //    dgvBillingSummary.Columns["Name"].Width = 150;
        //    dgvBillingSummary.Columns["DoctorName"].Width = 150;
        //    dgvBillingSummary.Columns["AdmissionStatus"].Width = 100;
        //    dgvBillingSummary.Columns["CabinName"].Width = 150;
        //    dgvBillingSummary.Columns["TestList"].Width = 200; //only test id
        //    dgvBillingSummary.Columns["Subtotal"].Width = 100;
        //    dgvBillingSummary.Columns["VAT"].Width = 100;
        //    dgvBillingSummary.Columns["Discount"].Width = 100;
        //    dgvBillingSummary.Columns["TotalAmount"].Width = 100;
        //}
    }
}
