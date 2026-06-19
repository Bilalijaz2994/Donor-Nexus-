using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // FORM SETTINGS

            this.Text = "Admin Dashboard";
            this.Size = new Size(1120, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 246, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // SIDEBAR

            Panel sidebar = new Panel();
            sidebar.Size = new Size(220, 720);
            sidebar.Location = new Point(0, 0);
            sidebar.BackColor = Color.White;
            this.Controls.Add(sidebar);

            Panel sidebarAccent = new Panel();
            sidebarAccent.Size = new Size(6, 720);
            sidebarAccent.Location = new Point(0, 0);
            sidebarAccent.BackColor = Color.FromArgb(160, 0, 20);
            sidebar.Controls.Add(sidebarAccent);

            Label lblBrand = new Label();
            lblBrand.Text = "Donor Nexus";
            lblBrand.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(34, 39, 51);
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(26, 30);
            sidebar.Controls.Add(lblBrand);

            Label lblAdmin = new Label();
            lblAdmin.Text = "Admin Panel";
            lblAdmin.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblAdmin.ForeColor = Color.FromArgb(101, 108, 122);
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(30, 68);
            sidebar.Controls.Add(lblAdmin);

            Panel sidebarLine = new Panel();
            sidebarLine.Size = new Size(168, 1);
            sidebarLine.Location = new Point(26, 108);
            sidebarLine.BackColor = Color.FromArgb(242, 230, 233);
            sidebar.Controls.Add(sidebarLine);

            btnLoadDonors = new Button();
            btnLoadDonors.Text = "Load Donors";
            btnLoadDonors.Size = new Size(172, 40);
            btnLoadDonors.Location = new Point(24, 140);
            btnLoadDonors.BackColor = Color.FromArgb(255, 238, 241);
            btnLoadDonors.ForeColor = Color.FromArgb(160, 0, 20);
            btnLoadDonors.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnLoadDonors.FlatStyle = FlatStyle.Flat;
            btnLoadDonors.FlatAppearance.BorderSize = 0;
            btnLoadDonors.Cursor = Cursors.Hand;
            btnLoadDonors.TextAlign = ContentAlignment.MiddleLeft;
            btnLoadDonors.Padding = new Padding(18, 0, 0, 0);
            btnLoadDonors.Click += BtnLoadDonors_Click;
            sidebar.Controls.Add(btnLoadDonors);

            btnDeleteDonor = new Button();
            btnDeleteDonor.Text = "Delete Donor";
            btnDeleteDonor.Size = new Size(172, 40);
            btnDeleteDonor.Location = new Point(24, 190);
            btnDeleteDonor.BackColor = Color.White;
            btnDeleteDonor.ForeColor = Color.FromArgb(34, 39, 51);
            btnDeleteDonor.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnDeleteDonor.FlatStyle = FlatStyle.Flat;
            btnDeleteDonor.FlatAppearance.BorderSize = 0;
            btnDeleteDonor.Cursor = Cursors.Hand;
            btnDeleteDonor.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteDonor.Padding = new Padding(18, 0, 0, 0);
            btnDeleteDonor.Click += BtnDeleteDonor_Click;
            sidebar.Controls.Add(btnDeleteDonor);

            btnViewMessages = new Button();
            btnViewMessages.Text = "View Messages";
            btnViewMessages.Size = new Size(172, 40);
            btnViewMessages.Location = new Point(24, 240);
            btnViewMessages.BackColor = Color.White;
            btnViewMessages.ForeColor = Color.FromArgb(34, 39, 51);
            btnViewMessages.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnViewMessages.FlatStyle = FlatStyle.Flat;
            btnViewMessages.FlatAppearance.BorderSize = 0;
            btnViewMessages.Cursor = Cursors.Hand;
            btnViewMessages.TextAlign = ContentAlignment.MiddleLeft;
            btnViewMessages.Padding = new Padding(18, 0, 0, 0);
            btnViewMessages.Click += BtnViewMessages_Click;
            sidebar.Controls.Add(btnViewMessages);

            btnAddHospital = new Button();
            btnAddHospital.Text = "Add Hospital";
            btnAddHospital.Size = new Size(172, 40);
            btnAddHospital.Location = new Point(24, 290);
            btnAddHospital.BackColor = Color.White;
            btnAddHospital.ForeColor = Color.FromArgb(34, 39, 51);
            btnAddHospital.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnAddHospital.FlatStyle = FlatStyle.Flat;
            btnAddHospital.FlatAppearance.BorderSize = 0;
            btnAddHospital.Cursor = Cursors.Hand;
            btnAddHospital.TextAlign = ContentAlignment.MiddleLeft;
            btnAddHospital.Padding = new Padding(18, 0, 0, 0);
            btnAddHospital.Click += BtnAddHospital_Click;
            sidebar.Controls.Add(btnAddHospital);

            btnManageInventory = new Button();
            btnManageInventory.Text = "Manage Stock";
            btnManageInventory.Size = new Size(172, 40);
            btnManageInventory.Location = new Point(24, 340);
            btnManageInventory.BackColor = Color.White;
            btnManageInventory.ForeColor = Color.FromArgb(34, 39, 51);
            btnManageInventory.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnManageInventory.FlatStyle = FlatStyle.Flat;
            btnManageInventory.FlatAppearance.BorderSize = 0;
            btnManageInventory.Cursor = Cursors.Hand;
            btnManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.Padding = new Padding(18, 0, 0, 0);
            btnManageInventory.Click += BtnManageInventory_Click;
            sidebar.Controls.Add(btnManageInventory);

            btnRecordDonation = new Button();
            btnRecordDonation.Text = "Record Donation";
            btnRecordDonation.Size = new Size(172, 40);
            btnRecordDonation.Location = new Point(24, 390);
            btnRecordDonation.BackColor = Color.White;
            btnRecordDonation.ForeColor = Color.FromArgb(34, 39, 51);
            btnRecordDonation.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnRecordDonation.FlatStyle = FlatStyle.Flat;
            btnRecordDonation.FlatAppearance.BorderSize = 0;
            btnRecordDonation.Cursor = Cursors.Hand;
            btnRecordDonation.TextAlign = ContentAlignment.MiddleLeft;
            btnRecordDonation.Padding = new Padding(18, 0, 0, 0);
            btnRecordDonation.Click += BtnRecordDonation_Click;
            sidebar.Controls.Add(btnRecordDonation);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Size = new Size(172, 40);
            btnRefresh.Location = new Point(24, 440);
            btnRefresh.BackColor = Color.White;
            btnRefresh.ForeColor = Color.FromArgb(34, 39, 51);
            btnRefresh.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Padding = new Padding(18, 0, 0, 0);
            btnRefresh.Click += BtnRefresh_Click;
            sidebar.Controls.Add(btnRefresh);

            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(172, 40);
            btnLogout.Location = new Point(24, 625);
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.FromArgb(34, 39, 51);
            btnLogout.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Click += BtnLogout_Click;
            sidebar.Controls.Add(btnLogout);

            // HEADER

            lblTitle = new Label();
            lblTitle.Text = "Admin Dashboard";
            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(250, 24);
            this.Controls.Add(lblTitle);

            Panel statsPanel = new Panel();
            statsPanel.Size = new Size(820, 64);
            statsPanel.Location = new Point(250, 78);
            statsPanel.BackColor = Color.White;
            statsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(statsPanel);

            lblTotalDonors = new Label();
            lblTotalDonors.Text = "Total Registered Donors: ";
            lblTotalDonors.Font = new Font("Segoe UI Semibold", 15, FontStyle.Bold);
            lblTotalDonors.ForeColor = Color.FromArgb(160, 0, 20);
            lblTotalDonors.AutoSize = true;
            lblTotalDonors.Location = new Point(24, 18);
            statsPanel.Controls.Add(lblTotalDonors);

            // DONORS GRID

            Label lblDonorsGrid = new Label();
            lblDonorsGrid.Text = "Registered Donors";
            lblDonorsGrid.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            lblDonorsGrid.ForeColor = Color.FromArgb(45, 45, 45);
            lblDonorsGrid.AutoSize = true;
            lblDonorsGrid.Location = new Point(250, 166);
            this.Controls.Add(lblDonorsGrid);

            dgvDonors = new DataGridView();
            dgvDonors.Location = new Point(250, 194);
            dgvDonors.Size = new Size(820, 220);
            dgvDonors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonors.BackgroundColor = Color.White;
            dgvDonors.BorderStyle = BorderStyle.FixedSingle;
            dgvDonors.RowTemplate.Height = 28;
            dgvDonors.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgvDonors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDonors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 0, 20);
            dgvDonors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDonors.EnableHeadersVisualStyles = false;
            dgvDonors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonors.MultiSelect = false;
            this.Controls.Add(dgvDonors);

            // CONTACT MESSAGES

            Label lblMessagesGrid = new Label();
            lblMessagesGrid.Text = "Contact Messages";
            lblMessagesGrid.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            lblMessagesGrid.ForeColor = Color.FromArgb(45, 45, 45);
            lblMessagesGrid.AutoSize = true;
            lblMessagesGrid.Location = new Point(250, 434);
            this.Controls.Add(lblMessagesGrid);

            dgvMessages = new DataGridView();
            dgvMessages.Location = new Point(250, 462);
            dgvMessages.Size = new Size(365, 190);
            dgvMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMessages.BackgroundColor = Color.White;
            dgvMessages.BorderStyle = BorderStyle.FixedSingle;
            dgvMessages.RowTemplate.Height = 28;
            dgvMessages.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgvMessages.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMessages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 0, 20);
            dgvMessages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMessages.EnableHeadersVisualStyles = false;
            dgvMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.MultiSelect = false;
            dgvMessages.SelectionChanged += DgvMessages_SelectionChanged;
            this.Controls.Add(dgvMessages);

            Panel messagePanel = new Panel();
            messagePanel.Size = new Size(435, 190);
            messagePanel.Location = new Point(635, 462);
            messagePanel.BackColor = Color.White;
            messagePanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(messagePanel);

            Label lblMessageTitle = new Label();
            lblMessageTitle.Text = "Message Details";
            lblMessageTitle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            lblMessageTitle.ForeColor = Color.FromArgb(160, 0, 20);
            lblMessageTitle.AutoSize = true;
            lblMessageTitle.Location = new Point(16, 12);
            messagePanel.Controls.Add(lblMessageTitle);

            lblPreviewFrom = new Label();
            lblPreviewFrom.Text = "From: -";
            lblPreviewFrom.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblPreviewFrom.ForeColor = Color.FromArgb(45, 45, 45);
            lblPreviewFrom.AutoSize = false;
            lblPreviewFrom.Size = new Size(190, 20);
            lblPreviewFrom.Location = new Point(16, 42);
            messagePanel.Controls.Add(lblPreviewFrom);

            lblPreviewEmail = new Label();
            lblPreviewEmail.Text = "Email: -";
            lblPreviewEmail.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblPreviewEmail.ForeColor = Color.FromArgb(45, 45, 45);
            lblPreviewEmail.AutoSize = false;
            lblPreviewEmail.Size = new Size(190, 20);
            lblPreviewEmail.Location = new Point(16, 66);
            messagePanel.Controls.Add(lblPreviewEmail);

            lblPreviewSubject = new Label();
            lblPreviewSubject.Text = "Subject: -";
            lblPreviewSubject.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblPreviewSubject.ForeColor = Color.FromArgb(45, 45, 45);
            lblPreviewSubject.AutoSize = false;
            lblPreviewSubject.Size = new Size(190, 20);
            lblPreviewSubject.Location = new Point(16, 90);
            messagePanel.Controls.Add(lblPreviewSubject);

            lblPreviewDate = new Label();
            lblPreviewDate.Text = "Date: -";
            lblPreviewDate.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblPreviewDate.ForeColor = Color.FromArgb(45, 45, 45);
            lblPreviewDate.AutoSize = false;
            lblPreviewDate.Size = new Size(190, 20);
            lblPreviewDate.Location = new Point(16, 114);
            messagePanel.Controls.Add(lblPreviewDate);

            txtMessagePreview = new TextBox();
            txtMessagePreview.Location = new Point(220, 42);
            txtMessagePreview.Size = new Size(198, 128);
            txtMessagePreview.Multiline = true;
            txtMessagePreview.ReadOnly = true;
            txtMessagePreview.ScrollBars = ScrollBars.Vertical;
            txtMessagePreview.BackColor = Color.White;
            txtMessagePreview.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            messagePanel.Controls.Add(txtMessagePreview);
        }

        #endregion
    }
}
