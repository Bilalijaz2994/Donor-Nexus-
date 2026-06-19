using DonorNexus.DAL;
using DonorNexus.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    public partial class RecordDonationForm : Form
    {
        ComboBox cmbDonor;
        ComboBox cmbHospital;
        DateTimePicker dtpDonationDate;
        NumericUpDown nudUnits;
        Button btnSave;
        Button btnClear;

        public RecordDonationForm()
        {
            InitializeComponent();

            LoadDonors();
            LoadHospitals();
        }

        private void LoadDonors()
        {
            try
            {
                DonorDAL donorDAL =
                    new DonorDAL();

                DataTable table =
                    donorDAL.GetDonorsForSelection();

                cmbDonor.DataSource =
                    table;

                cmbDonor.DisplayMember =
                    "DisplayText";

                cmbDonor.ValueMember =
                    "DonorID";

                cmbDonor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadHospitals()
        {
            try
            {
                HospitalDAL hospitalDAL =
                    new HospitalDAL();

                DataTable table =
                    hospitalDAL.GetHospitals();

                cmbHospital.DataSource =
                    table;

                cmbHospital.DisplayMember =
                    "HospitalName";

                cmbHospital.ValueMember =
                    "HospitalID";

                cmbHospital.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbDonor.Text == "" ||
                    cmbHospital.Text == "")
                {
                    MessageBox.Show(
                        "Please select donor and hospital.");

                    return;
                }

                DonationRecord record =
                    new DonationRecord(
                        0,
                        Convert.ToInt32(cmbDonor.SelectedValue),
                        Convert.ToInt32(cmbHospital.SelectedValue),
                        dtpDonationDate.Value.Date,
                        Convert.ToInt32(nudUnits.Value));

                DonationDAL donationDAL =
                    new DonationDAL();

                string eligibility =
                    donationDAL.GetDonationEligibility(
                        record.DonorID,
                        record.DonationDate);

                if (eligibility == "Not Eligible")
                {
                    MessageBox.Show(
                        "Donor is not eligible. At least 90 days are required between donations.");

                    return;
                }

                donationDAL.AddDonation(record);

                MessageBox.Show(
                    "Donation Recorded Successfully");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbDonor.SelectedIndex = -1;
            cmbHospital.SelectedIndex = -1;
            dtpDonationDate.Value = DateTime.Today;
            nudUnits.Value = 1;
        }
    }
}
