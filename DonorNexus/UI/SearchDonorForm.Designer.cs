using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class SearchDonorForm
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

            this.Text = "Search Donor";

            this.Size = new Size(920, 610);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor = Color.FromArgb(250, 246, 247);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // TOP PANEL

            topPanel = new Panel();

            topPanel.Size =
                new Size(920, 92);

            topPanel.Location =
                new Point(0, 0);

            topPanel.BackColor =
                Color.FromArgb(160, 0, 20);

            this.Controls.Add(topPanel);

            // TITLE

            lblTitle = new Label();

            lblTitle.Text = "Search Blood Donors";

            lblTitle.Font =
                new Font("Segoe UI Semibold", 22,
                FontStyle.Bold);

            lblTitle.ForeColor = Color.White;

            lblTitle.AutoSize = true;

            lblTitle.Location = new Point(304, 22);

            topPanel.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();

            lblSubtitle.Text =
                "Find available donors by blood group, city, and district.";

            lblSubtitle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Regular);

            lblSubtitle.ForeColor =
                Color.FromArgb(255, 225, 230);

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location =
                new Point(280, 58);

            topPanel.Controls.Add(lblSubtitle);

            // SEARCH PANEL

            searchPanel = new Panel();

            searchPanel.Size = new Size(820, 145);

            searchPanel.Location = new Point(42, 118);

            searchPanel.BackColor = Color.White;

            searchPanel.BorderStyle =
                BorderStyle.FixedSingle;

            this.Controls.Add(searchPanel);

            // BLOOD GROUP

            lblBloodGroup = new Label();
            lblBloodGroup.Text = "Blood Group";
            lblBloodGroup.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblBloodGroup.ForeColor = Color.FromArgb(45, 45, 45);
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(34, 26);
            searchPanel.Controls.Add(lblBloodGroup);

            cmbBloodGroup = new ComboBox();

            cmbBloodGroup.Location =
                new Point(34, 52);

            cmbBloodGroup.Size =
                new Size(185, 28);

            cmbBloodGroup.Font =
                new Font("Segoe UI", 10,
                FontStyle.Regular);

            cmbBloodGroup.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbBloodGroup.Items.Add("A+");
            cmbBloodGroup.Items.Add("A-");
            cmbBloodGroup.Items.Add("B+");
            cmbBloodGroup.Items.Add("B-");
            cmbBloodGroup.Items.Add("AB+");
            cmbBloodGroup.Items.Add("AB-");
            cmbBloodGroup.Items.Add("O+");
            cmbBloodGroup.Items.Add("O-");

            searchPanel.Controls.Add(cmbBloodGroup);

            // CITY

            lblCity = new Label();
            lblCity.Text = "City";
            lblCity.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 45, 45);
            lblCity.AutoSize = true;
            lblCity.Location = new Point(252, 26);
            searchPanel.Controls.Add(lblCity);

            txtCity = new TextBox();
            txtCity.Location = new Point(252, 52);
            txtCity.Size = new Size(190, 28);
            txtCity.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            searchPanel.Controls.Add(txtCity);

            // DISTRICT

            lblDistrict = new Label();
            lblDistrict.Text = "District";
            lblDistrict.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDistrict.ForeColor = Color.FromArgb(45, 45, 45);
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(474, 26);
            searchPanel.Controls.Add(lblDistrict);

            txtDistrict = new TextBox();
            txtDistrict.Location = new Point(474, 52);
            txtDistrict.Size = new Size(190, 28);
            txtDistrict.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            searchPanel.Controls.Add(txtDistrict);

            // SEARCH BUTTON

            btnSearch = new Button();
            btnSearch.Text = "Search Donors";
            btnSearch.Size = new Size(105, 40);
            btnSearch.Location = new Point(690, 48);
            btnSearch.BackColor = Color.FromArgb(160, 0, 20);
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnSearch.Cursor = Cursors.Hand;

            btnSearch.Click += BtnSearch_Click;

            searchPanel.Controls.Add(btnSearch);

            // DATAGRIDVIEW

            dgvDonors = new DataGridView();

            dgvDonors.Location =
                new Point(42, 294);

            dgvDonors.Size =
                new Size(820, 255);

            dgvDonors.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDonors.BackgroundColor =
                Color.White;

            dgvDonors.BorderStyle =
                BorderStyle.FixedSingle;

            dgvDonors.RowTemplate.Height = 30;

            dgvDonors.Font =
                new Font("Segoe UI", 9,
                FontStyle.Regular);

            dgvDonors.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Bold);

            dgvDonors.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(160, 0, 20);

            dgvDonors.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDonors.EnableHeadersVisualStyles = false;

            dgvDonors.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDonors.MultiSelect = false;

            this.Controls.Add(dgvDonors);
        }

#endregion
    }
}
