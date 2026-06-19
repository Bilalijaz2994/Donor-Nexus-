using System;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DonorNexus.DAL;

namespace DonorNexus.UI
{
    public partial class AdminDashboardForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblTotalDonors;

        // BUTTONS

        Button btnLoadDonors;
        Button btnDeleteDonor;
        Button btnViewMessages;
        Button btnAddHospital;
        Button btnManageInventory;
        Button btnRecordDonation;
        Button btnRefresh;
        Button btnLogout;

        // DATAGRIDVIEWS

        DataGridView dgvDonors;
        DataGridView dgvMessages;

        Label lblPreviewFrom;
        Label lblPreviewEmail;
        Label lblPreviewSubject;
        Label lblPreviewDate;
        TextBox txtMessagePreview;

        private readonly Color primaryRed = Color.FromArgb(160, 0, 20);
        private readonly Color sidebarRed = Color.FromArgb(120, 0, 18);
        private readonly Color pageBack = Color.FromArgb(250, 246, 247);
        private readonly Color borderColor = Color.FromArgb(226, 214, 217);

        public AdminDashboardForm()
        {
            InitializeComponent();

            if (IsDesignerOpen())
            {
                return;
            }

            LoadTotalDonors();
        }

        private bool IsDesignerOpen()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
                Process.GetCurrentProcess().ProcessName.Equals("devenv", StringComparison.OrdinalIgnoreCase);
        }

        

        private void DgvMessages_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvMessages.SelectedRows.Count == 0 ||
                !dgvMessages.Columns.Contains("MessageText"))
            {
                lblPreviewFrom.Text = "From: -";
                lblPreviewEmail.Text = "Email: -";
                lblPreviewSubject.Text = "Subject: -";
                lblPreviewDate.Text = "Date: -";
                txtMessagePreview.Text = "";
                return;
            }

            DataGridViewRow row = dgvMessages.SelectedRows[0];

            lblPreviewFrom.Text = "From: " + GetCellText(row, "SenderName");
            lblPreviewEmail.Text = "Email: " + GetCellText(row, "SenderEmail");
            lblPreviewSubject.Text = "Subject: " + GetCellText(row, "Subject");
            lblPreviewDate.Text = "Date: " + GetCellText(row, "SentDate");
            txtMessagePreview.Text = GetCellText(row, "MessageText");
        }

        private string GetCellText(
            DataGridViewRow row,
            string columnName)
        {
            if (!dgvMessages.Columns.Contains(columnName) ||
                row.Cells[columnName].Value == null)
            {
                return "";
            }

            return row.Cells[columnName].Value.ToString();
        }

        private void FormatMessagesGrid()
        {
            if (dgvMessages.Columns.Contains("MessageText"))
            {
                dgvMessages.Columns["MessageText"].Visible = false;
            }

            if (dgvMessages.Columns.Contains("SenderName"))
            {
                dgvMessages.Columns["SenderName"].HeaderText = "Name";
            }

            if (dgvMessages.Columns.Contains("SenderEmail"))
            {
                dgvMessages.Columns["SenderEmail"].HeaderText = "Email";
            }

            if (dgvMessages.Columns.Contains("SentDate"))
            {
                dgvMessages.Columns["SentDate"].HeaderText = "Date";
            }
        }

        // LOAD TOTAL DONORS

        private void LoadTotalDonors()
        {
            try
            {
                DonorDAL donorDAL =
                    new DonorDAL();

                int total =
                    donorDAL.GetTotalDonors();

                lblTotalDonors.Text =
                    "Total Registered Donors: "
                    + total;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LOAD DONORS

        private void BtnLoadDonors_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DonorDAL donorDAL =
                    new DonorDAL();

                DataTable table =
                    donorDAL.GetAllDonors();

                dgvDonors.DataSource =
                    table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE DONOR

        private void BtnDeleteDonor_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvDonors.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a donor.");

                    return;
                }

                int donorID =
                    Convert.ToInt32(
                        dgvDonors.SelectedRows[0]
                        .Cells["DonorID"].Value);

                DonorDAL donorDAL =
                    new DonorDAL();

                donorDAL.DeleteDonor(donorID);

                MessageBox.Show(
                    "Donor Deleted Successfully");

                BtnLoadDonors_Click(null, null);

                LoadTotalDonors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // VIEW CONTACT MESSAGES

        private void BtnViewMessages_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                ContactDAL contactDAL =
                    new ContactDAL();

                DataTable table =
                    contactDAL.GetMessages();

                dgvMessages.DataSource =
                    table;

                FormatMessagesGrid();

                if (dgvMessages.Rows.Count > 0)
                {
                    dgvMessages.Rows[0].Selected = true;
                    DgvMessages_SelectionChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ADD HOSPITAL

        private void BtnAddHospital_Click(
            object sender,
            EventArgs e)
        {
            AddHospitalForm hospitalForm =
                new AddHospitalForm();

            hospitalForm.Show();
        }

        // MANAGE INVENTORY

        private void BtnManageInventory_Click(
            object sender,
            EventArgs e)
        {
            ManageInventoryForm inventoryForm =
                new ManageInventoryForm();

            inventoryForm.Show();
        }

        // RECORD DONATION

        private void BtnRecordDonation_Click(
            object sender,
            EventArgs e)
        {
            RecordDonationForm donationForm =
                new RecordDonationForm();

            donationForm.Show();
        }

        // REFRESH

        private void BtnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadTotalDonors();

            BtnLoadDonors_Click(null, null);

            BtnViewMessages_Click(null, null);
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
