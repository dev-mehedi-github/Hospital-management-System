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
    public partial class Uc_PaitentBill : UserControl
    {
        private FrmReceptionist fr { get; set; }
        private DataAccess Da;
        public Uc_PaitentBill(FrmReceptionist fr)
        {
            InitializeComponent();
            this.fr = fr;
            this.Da = new DataAccess();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string patientId = txtSearchPatientID.Text.Trim();
            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Please enter a Patient ID");
                return;
            }

            string sqlPatient = $"SELECT * FROM Patients WHERE PatientID = '{patientId}'";
            DataTable dtPatient = this.Da.ExecuteQueryTable(sqlPatient);
            if (dtPatient.Rows.Count != 1)
            {
                MessageBox.Show("Patient not found.");
                return;
            }

            DataRow patient = dtPatient.Rows[0];

            lblBillPatientID.Text +=  patient["PatientID"].ToString();
            lblBillPatientName.Text +=  patient["Name"].ToString();
            lblBillAdmissionStatus.Text +=  (Convert.ToBoolean(patient["IsAdmitted"]) ? "Admitted" : "Not Admitted");
            lblBillDate.Text += Convert.ToDateTime(patient["RegisterDate"]).ToString("dd-MMM-yyyy");

            if (patient["DoctorID"] != DBNull.Value)
            {
                string sqlDoc = $"SELECT DoctorName FROM Doctors WHERE DoctorID = '{patient["DoctorID"]}'";
                DataTable dtDoc = this.Da.ExecuteQueryTable(sqlDoc);
                lblBillDoctor.Text +=  (dtDoc.Rows.Count == 1 ? dtDoc.Rows[0]["DoctorName"].ToString() : "N/A");
            }
            else
            {
                lblBillDoctor.Text += " N/A";
            }

            if (patient["CabinID"] != DBNull.Value)
            {
                string sqlCabin = $"SELECT CabinName, Price FROM Cabins WHERE CabinID = '{patient["CabinID"]}'";
                DataTable dtCabin = this.Da.ExecuteQueryTable(sqlCabin);
                if (dtCabin.Rows.Count == 1)
                {
                    lblBillCabinName.Text += dtCabin.Rows[0]["CabinName"].ToString();
                    lblBillCabinPrice.Text +=  dtCabin.Rows[0]["Price"].ToString() + " TK";
                }
            }
            else
            {
                lblBillCabinName.Text += " N/A";
                lblBillCabinPrice.Text += " 0.00 TK";
            }

            string sqlTests = $@"SELECT T.TestName, T.Price FROM PatientTests PT JOIN Tests T ON PT.TestID = T.TestID WHERE PT.PatientID = '{patientId}'";
            dgvBillTests.DataSource = this.Da.ExecuteQuery(sqlTests).Tables[0];

            string sqlBill = $"SELECT * FROM PatientBills WHERE PatientID = '{patientId}'";
            DataTable dtBill = this.Da.ExecuteQueryTable(sqlBill);
            if (dtBill.Rows.Count == 1)
            {
                DataRow bill = dtBill.Rows[0];
                lblBillSubtotal.Text +=  Convert.ToDecimal(bill[2]).ToString("0.00") + " TK";
                lblBillVAT.Text += Convert.ToDecimal(bill[3]).ToString("0.00") + " TK";
                lblBillDiscount.Text +=  Convert.ToDecimal(bill[4]).ToString("0.00") + " TK";
                lblBillTotal.Text +=  Convert.ToDecimal(bill[5]).ToString("0.00") + " TK";
            }
            else
            {
                lblBillSubtotal.Text += " N/A";
                lblBillVAT.Text += " N/A";
                lblBillDiscount.Text += " N/A";
                lblBillTotal.Text = " N/A";
                MessageBox.Show("Billing info not found.");
            }
        }

       

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            string patientId = txtSearchPatientID.Text.Trim();
            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Enter a valid Patient ID.");
                return;
            }

            // Get CabinID from patient
            string cabinSql = $"SELECT CabinID FROM Patients WHERE PatientID = '{patientId}' AND IsAdmitted = 1";
            DataTable dt = Da.ExecuteQueryTable(cabinSql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Patient is not admitted or invalid ID.");
                return;
            }

            string cabinId = dt.Rows[0]["CabinID"].ToString();
            string today = DateTime.Now.ToString("yyyy-MM-dd");

            string updatePatient = $@" UPDATE Patients SET IsAdmitted = 0 WHERE PatientID = '{patientId}';UPDATE Cabins SET IsAvailable = 1 WHERE CabinID = '{cabinId}';
            UPDATE PatientBills SET DischargeDate = '{today}' WHERE PatientID = '{patientId}'";

            int result = Da.ExecuteDMLQuery(updatePatient);
            MessageBox.Show("Patient discharged successfully.");

        }
    }
}
