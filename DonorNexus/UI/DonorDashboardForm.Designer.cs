using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class DonorDashboardForm
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
            // FORM

            this.Text = "Donor Dashboard";
            this.Size = new Size(900, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 246, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // SIDEBAR

            Panel sidebarPanel = new Panel();
            sidebarPanel.Size = new Size(230, 620);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.BackColor = Color.White;
            this.Controls.Add(sidebarPanel);

            Panel sidebarAccent = new Panel();
            sidebarAccent.Size = new Size(6, 620);
            sidebarAccent.Location = new Point(0, 0);
            sidebarAccent.BackColor = Color.FromArgb(160, 0, 20);
            sidebarPanel.Controls.Add(sidebarAccent);

            Label lblBrand = new Label();
            lblBrand.Text = "Donor Nexus";
            lblBrand.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(34, 39, 51);
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(30, 34);
            sidebarPanel.Controls.Add(lblBrand);

            Label lblSection = new Label();
            lblSection.Text = "Donor Panel";
            lblSection.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSection.ForeColor = Color.FromArgb(101, 108, 122);
            lblSection.AutoSize = true;
            lblSection.Location = new Point(34, 74);
            sidebarPanel.Controls.Add(lblSection);

            Panel divider = new Panel();
            divider.Size = new Size(170, 1);
            divider.Location = new Point(30, 116);
            divider.BackColor = Color.FromArgb(242, 230, 233);
            sidebarPanel.Controls.Add(divider);

            btnAvailable = new Button();
            btnAvailable.Text = "Set Available";
            btnAvailable.Size = new Size(172, 40);
            btnAvailable.Location = new Point(30, 150);
            btnAvailable.BackColor = Color.FromArgb(255, 238, 241);
            btnAvailable.ForeColor = Color.FromArgb(160, 0, 20);
            btnAvailable.FlatStyle = FlatStyle.Flat;
            btnAvailable.FlatAppearance.BorderSize = 0;
            btnAvailable.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnAvailable.TextAlign = ContentAlignment.MiddleLeft;
            btnAvailable.Padding = new Padding(18, 0, 0, 0);
            btnAvailable.Cursor = Cursors.Hand;
            btnAvailable.Click += BtnAvailable_Click;
            sidebarPanel.Controls.Add(btnAvailable);

            btnUnavailable = new Button();
            btnUnavailable.Text = "Set Unavailable";
            btnUnavailable.Size = new Size(172, 40);
            btnUnavailable.Location = new Point(30, 200);
            btnUnavailable.BackColor = Color.White;
            btnUnavailable.ForeColor = Color.FromArgb(34, 39, 51);
            btnUnavailable.FlatStyle = FlatStyle.Flat;
            btnUnavailable.FlatAppearance.BorderSize = 0;
            btnUnavailable.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnUnavailable.TextAlign = ContentAlignment.MiddleLeft;
            btnUnavailable.Padding = new Padding(18, 0, 0, 0);
            btnUnavailable.Cursor = Cursors.Hand;
            btnUnavailable.Click += BtnUnavailable_Click;
            sidebarPanel.Controls.Add(btnUnavailable);

            btnLoadHistory = new Button();
            btnLoadHistory.Text = "Load History";
            btnLoadHistory.Size = new Size(172, 40);
            btnLoadHistory.Location = new Point(30, 250);
            btnLoadHistory.BackColor = Color.White;
            btnLoadHistory.ForeColor = Color.FromArgb(34, 39, 51);
            btnLoadHistory.FlatStyle = FlatStyle.Flat;
            btnLoadHistory.FlatAppearance.BorderSize = 0;
            btnLoadHistory.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnLoadHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnLoadHistory.Padding = new Padding(18, 0, 0, 0);
            btnLoadHistory.Cursor = Cursors.Hand;
            btnLoadHistory.Click += BtnLoadHistory_Click;
            sidebarPanel.Controls.Add(btnLoadHistory);

            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(180, 40);
            btnLogout.Location = new Point(30, 528);
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.FromArgb(34, 39, 51);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += BtnLogout_Click;
            sidebarPanel.Controls.Add(btnLogout);

            // TITLE

            lblTitle = new Label();
            lblTitle.Text = "Donor Dashboard";
            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(262, 28);
            this.Controls.Add(lblTitle);

            // INFO PANEL

            Panel infoPanel = new Panel();
            infoPanel.Size = new Size(585, 150);
            infoPanel.Location = new Point(266, 84);
            infoPanel.BackColor = Color.White;
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(infoPanel);

            lblName = new Label();
            lblName.Text = "Name: ";
            lblName.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(34, 39, 51);
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 24);
            infoPanel.Controls.Add(lblName);

            lblBloodGroup = new Label();
            lblBloodGroup.Text = "Blood Group: ";
            lblBloodGroup.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            lblBloodGroup.ForeColor = Color.FromArgb(34, 39, 51);
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(28, 64);
            infoPanel.Controls.Add(lblBloodGroup);

            lblDonations = new Label();
            lblDonations.Text = "Donation Count: ";
            lblDonations.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            lblDonations.ForeColor = Color.FromArgb(34, 39, 51);
            lblDonations.AutoSize = true;
            lblDonations.Location = new Point(28, 104);
            infoPanel.Controls.Add(lblDonations);

            lblAvailability = new Label();
            lblAvailability.Text = "Availability: ";
            lblAvailability.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            lblAvailability.ForeColor = Color.FromArgb(34, 39, 51);
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(318, 24);
            infoPanel.Controls.Add(lblAvailability);

            Panel badge = new Panel();
            badge.Size = new Size(210, 54);
            badge.Location = new Point(318, 72);
            badge.BackColor = Color.FromArgb(255, 238, 241);
            infoPanel.Controls.Add(badge);

            Label lblBadge = new Label();
            lblBadge.Text = "Thank you for helping save lives";
            lblBadge.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblBadge.ForeColor = Color.FromArgb(160, 0, 20);
            lblBadge.AutoSize = false;
            lblBadge.TextAlign = ContentAlignment.MiddleCenter;
            lblBadge.Dock = DockStyle.Fill;
            badge.Controls.Add(lblBadge);

            // HISTORY GRID

            Label lblHistory = new Label();
            lblHistory.Text = "Donation History";
            lblHistory.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            lblHistory.ForeColor = Color.FromArgb(34, 39, 51);
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(266, 260);
            this.Controls.Add(lblHistory);

            dgvHistory = new DataGridView();
            dgvHistory.Location = new Point(266, 294);
            dgvHistory.Size = new Size(585, 250);
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.FixedSingle;
            dgvHistory.RowTemplate.Height = 28;
            dgvHistory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 0, 20);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.MultiSelect = false;
            this.Controls.Add(dgvHistory);
        }

        #endregion
    }
}
