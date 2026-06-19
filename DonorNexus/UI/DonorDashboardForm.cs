using System;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class DonorDashboardForm : Form
    {
        // DONOR ID

        private int donorID;
        private string donorName = "";
        private string donorBloodGroup = "";
        private int donationCount = 0;

        // LABELS

        Label lblTitle;
        Label lblName;
        Label lblBloodGroup;
        Label lblDonations;
        Label lblAvailability;

        // BUTTONS

        Button btnAvailable;
        Button btnUnavailable;
        Button btnLoadHistory;
        Button btnLogout;

        // GRID

        DataGridView dgvHistory;

        private readonly Color primaryRed = Color.FromArgb(160, 0, 20);
        private readonly Color softRed = Color.FromArgb(255, 238, 241);
        private readonly Color pageBack = Color.FromArgb(250, 246, 247);
        private readonly Color textDark = Color.FromArgb(34, 39, 51);
        private readonly Color textMuted = Color.FromArgb(101, 108, 122);

        public DonorDashboardForm()
        {
            InitializeComponent();
        }

        public DonorDashboardForm(int id)
        {
            donorID = id;

            InitializeComponent();

            if (IsDesignerOpen())
            {
                return;
            }

            LoadDonorData();

            LoadDonationHistory();
        }

        private bool IsDesignerOpen()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
                Process.GetCurrentProcess().ProcessName.Equals("devenv", StringComparison.OrdinalIgnoreCase);
        }

        


      // LOAD DONOR INFO

        private void LoadDonorData()
        {
            try
            {
                DonorDAL donorDAL =
                    new DonorDAL();

                Donor donor =
                    donorDAL.GetDonorById(donorID);

                if (donor != null)
                {
                    donorName =
                        donor.FullName;

                    donorBloodGroup =
                        donor.BloodGroup;

                    donationCount =
                        donor.TotalDonations;

                    lblName.Text =
                        "Name: " + donorName;

                    lblBloodGroup.Text =
                        "Blood Group: " + donorBloodGroup;

                    lblDonations.Text =
                        "Donation Count: " + donationCount;

                    if (donor.IsAvailable)
                    {
                        lblAvailability.Text =
                            "Availability: Available";
                    }
                    else
                    {
                        lblAvailability.Text =
                            "Availability: Not Available";
                    }

                    RefreshAvailabilityButtons(
                        donor.IsAvailable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // SET AVAILABLE

        private void BtnAvailable_Click(
            object sender,
            EventArgs e)
        {
            UpdateAvailability(true);
        }

        // SET UNAVAILABLE

        private void BtnUnavailable_Click(
            object sender,
            EventArgs e)
        {
            UpdateAvailability(false);
        }

        // UPDATE AVAILABILITY

        private void UpdateAvailability(bool status)
        {
            try
            {
                DonorDAL donorDAL =
                    new DonorDAL();

                donorDAL.UpdateAvailability(
                    donorID,
                    status);

                MessageBox.Show(
                    "Availability Updated");

                lblAvailability.Text =
                    status ?
                    "Availability: Available" :
                    "Availability: Not Available";

                RefreshAvailabilityButtons(status);

                LoadDonorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LOAD DONATION HISTORY

        private void BtnLoadHistory_Click(
            object sender,
            EventArgs e)
        {
            LoadDonationHistory(true);
        }

        private void LoadDonationHistory()
        {
            LoadDonationHistory(false);
        }

        private void LoadDonationHistory(bool showNoHistoryMessage)
        {
            try
            {
                DonationDAL donationDAL =
                    new DonationDAL();

                DataTable table =
                    donationDAL.GetDonationHistory(donorID);

                if (table.Rows.Count > 0)
                {
                    dgvHistory.DataSource = table;
                }
                else
                {
                    dgvHistory.DataSource = table;

                    if (showNoHistoryMessage)
                    {
                        MessageBox.Show(
                            "No donation history found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshAvailabilityButtons(bool isAvailable)
        {
            if (isAvailable)
            {
                btnAvailable.BackColor = softRed;
                btnAvailable.ForeColor = primaryRed;
                btnUnavailable.BackColor = Color.White;
                btnUnavailable.ForeColor = textDark;
            }
            else
            {
                btnAvailable.BackColor = Color.White;
                btnAvailable.ForeColor = textDark;
                btnUnavailable.BackColor = softRed;
                btnUnavailable.ForeColor = primaryRed;
            }
        }

        // LOGOUT

        private void BtnLogout_Click(
            object sender,
            EventArgs e)
        {
            this.Hide();

            LoginForm login =
                new LoginForm();

            login.Show();
        }
    }
}
