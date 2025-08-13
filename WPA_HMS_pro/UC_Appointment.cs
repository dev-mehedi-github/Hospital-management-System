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
    public partial class UC_Appointment : UserControl
    {
        private DataAccess Da;
        private FrmReceptionist fr { get; set; }
        public UC_Appointment(FrmReceptionist fr)
        {
            InitializeComponent();
            this.fr = fr;
            this.Da = new DataAccess();
            LoadDoctors();
            LoadAppointments();
        }
        private void LoadDoctors()
        {
            string sql = "Select DoctorID, DoctorName From Doctors";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            cmbDoctor.DataSource = dt;
            cmbDoctor.DisplayMember = "DoctorName";
            cmbDoctor.ValueMember = "DoctorID";
            cmbDoctor.SelectedIndex = -1;
        }
        private void LoadAppointments()
        {
            if (cmbDoctor.SelectedValue == null) return;

            string doctorId = cmbDoctor.SelectedValue.ToString();
            string date = dtpAppointmentDate.Value.ToString("yyyy-MM-dd");

            string sql = $@" Select SerialNo, PatientName from Appointments where DoctorID = '{cmbDoctor.SelectedValue}' 
            AND AppointmentDate = '{dtpAppointmentDate.Value:yyyy-MM-dd}' ORDER BY SerialNo";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            dgvAppointments.DataSource = dt;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            string doctorId = cmbDoctor.SelectedValue.ToString();
            string date = dtpAppointmentDate.Value.ToString("yyyy-MM-dd");
            string patientName = txtPatientName.Text.Trim();

            if (string.IsNullOrEmpty(patientName))
            {
                MessageBox.Show("Enter patient name.");
                return;
            }
            
            int nextSerial = 1;
            DataTable dt = this.Da.ExecuteQueryTable($@"Select SerialNo from Appointments where DoctorID = '{cmbDoctor.SelectedValue}' 
            AND AppointmentDate = '{dtpAppointmentDate.Value:yyyy-MM-dd}' ORDER BY SerialNo DESC");
            if (dt.Rows.Count > 0)
            nextSerial = Convert.ToInt32(dt.Rows[0][0]) + 1;

            string insertSql = $@"insert into Appointments (DoctorID, AppointmentDate, SerialNo, PatientName)
            VALUES('{cmbDoctor.SelectedValue}', '{dtpAppointmentDate.Value:yyyy-MM-dd}', {nextSerial}, '{txtPatientName.Text.Trim()}')";

            int count = this.Da.ExecuteDMLQuery(insertSql);
            if (count == 1)
            {
                MessageBox.Show("Appointment added.");
                LoadAppointments();
                txtPatientName.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add appointment.");
            }
        }
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }

    }
}
