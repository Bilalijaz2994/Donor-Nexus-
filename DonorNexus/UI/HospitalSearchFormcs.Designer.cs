using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class HospitalSearchForm
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

            this.Text = "Search Hospitals";

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

            lblTitle.Text =
                "Search Hospital Blood";

            lblTitle.Font =
                new Font("Segoe UI Semibold", 22,
                FontStyle.Bold);

            lblTitle.ForeColor =
                Color.White;

            lblTitle.AutoSize = true;

            lblTitle.Location =
                new Point(296, 22);

            topPanel.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text =
                "Find hospitals with available blood units by city, district, and blood group.";

            lblSubtitle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Regular);

            lblSubtitle.ForeColor =
                Color.FromArgb(255, 225, 230);

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location =
                new Point(248, 58);

            topPanel.Controls.Add(lblSubtitle);

            // SEARCH PANEL

            searchPanel = new Panel();

            searchPanel.Size =
                new Size(820, 150);

            searchPanel.Location =
                new Point(42, 118);

            searchPanel.BackColor =
                Color.White;

            searchPanel.BorderStyle =
                BorderStyle.FixedSingle;

            this.Controls.Add(searchPanel);

            // CITY LABEL

            lblCity = new Label();
            lblCity.Text = "City";
            lblCity.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 45, 45);
            lblCity.AutoSize = true;
            lblCity.Location = new Point(34, 26);
            searchPanel.Controls.Add(lblCity);

            // CITY TEXTBOX

            txtCity = new TextBox();
            txtCity.Location = new Point(34, 52);
            txtCity.Size = new Size(215, 28);
            txtCity.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            searchPanel.Controls.Add(txtCity);

            // DISTRICT LABEL

            lblDistrict = new Label();
            lblDistrict.Text = "District";
            lblDistrict.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDistrict.ForeColor = Color.FromArgb(45, 45, 45);
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(274, 26);
            searchPanel.Controls.Add(lblDistrict);

            // DISTRICT TEXTBOX

            txtDistrict = new TextBox();
            txtDistrict.Location = new Point(274, 52);
            txtDistrict.Size = new Size(215, 28);
            txtDistrict.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            searchPanel.Controls.Add(txtDistrict);

            // BLOOD GROUP LABEL

            lblBloodGroup = new Label();
            lblBloodGroup.Text = "Blood Group";
            lblBloodGroup.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblBloodGroup.ForeColor = Color.FromArgb(45, 45, 45);
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(514, 26);
            searchPanel.Controls.Add(lblBloodGroup);

            // BLOOD GROUP COMBOBOX

            cmbBloodGroup = new ComboBox();

            cmbBloodGroup.Location =
                new Point(514, 52);

            cmbBloodGroup.Size =
                new Size(155, 28);

            cmbBloodGroup.Font =
                new Font("Segoe UI", 10);

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

            // SEARCH BUTTON

            btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.Size = new Size(100, 40);
            btnSearch.Location = new Point(690, 38);
            btnSearch.BackColor = Color.FromArgb(160, 0, 20);
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnSearch.Cursor = Cursors.Hand;

            btnSearch.Click +=
                BtnSearch_Click;

            searchPanel.Controls.Add(btnSearch);

            // CLEAR BUTTON

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Size = new Size(100, 40);
            btnClear.Location = new Point(690, 88);
            btnClear.BackColor = Color.FromArgb(120, 120, 120);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;

            btnClear.Click +=
                BtnClear_Click;

            searchPanel.Controls.Add(btnClear);

            // RESULTS GRID

            dgvHospitals = new DataGridView();

            dgvHospitals.Location =
                new Point(42, 300);

            dgvHospitals.Size =
                new Size(820, 250);

            dgvHospitals.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHospitals.BackgroundColor =
                Color.White;

            dgvHospitals.BorderStyle =
                BorderStyle.FixedSingle;

            dgvHospitals.RowTemplate.Height = 30;

            dgvHospitals.Font =
                new Font("Segoe UI", 9);

            dgvHospitals.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Bold);

            dgvHospitals.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(160, 0, 20);

            dgvHospitals.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvHospitals.EnableHeadersVisualStyles = false;

            dgvHospitals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHospitals.MultiSelect = false;

            this.Controls.Add(dgvHospitals);
        }

#endregion
    }
}
