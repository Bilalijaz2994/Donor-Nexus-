using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class AddHospitalForm
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

            this.Text = "Add Hospital";

            this.Size = new Size(560, 540);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor = Color.FromArgb(250, 246, 247);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // TOP PANEL

            topPanel = new Panel();

            topPanel.Size = new Size(560, 82);

            topPanel.Location = new Point(0, 0);

            topPanel.BackColor = Color.FromArgb(160, 0, 20);

            this.Controls.Add(topPanel);

            // TITLE

            lblTitle = new Label();

            lblTitle.Text = "Add Hospital";

            lblTitle.Font =
                new Font("Segoe UI Semibold", 22,
                FontStyle.Bold);

            lblTitle.ForeColor = Color.White;

            lblTitle.AutoSize = true;

            lblTitle.Location = new Point(178, 20);

            topPanel.Controls.Add(lblTitle);

            // MAIN PANEL

            mainPanel = new Panel();

            mainPanel.Size = new Size(440, 370);

            mainPanel.Location = new Point(52, 112);

            mainPanel.BackColor = Color.White;

            mainPanel.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(mainPanel);

            // HOSPITAL NAME LABEL

            lblHospitalName = new Label();
            lblHospitalName.Text = "Hospital Name";
            lblHospitalName.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblHospitalName.ForeColor = Color.FromArgb(45, 45, 45);
            lblHospitalName.AutoSize = true;
            lblHospitalName.Location = new Point(36, 26);
            mainPanel.Controls.Add(lblHospitalName);

            // HOSPITAL NAME TEXTBOX

            txtHospitalName = new TextBox();
            txtHospitalName.Location = new Point(36, 52);
            txtHospitalName.Size = new Size(360, 28);
            txtHospitalName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtHospitalName);

            // CITY LABEL

            lblCity = new Label();
            lblCity.Text = "City";
            lblCity.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 45, 45);
            lblCity.AutoSize = true;
            lblCity.Location = new Point(36, 100);
            mainPanel.Controls.Add(lblCity);

            // CITY TEXTBOX

            txtCity = new TextBox();
            txtCity.Location = new Point(36, 126);
            txtCity.Size = new Size(360, 28);
            txtCity.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtCity);

            // DISTRICT LABEL

            lblDistrict = new Label();
            lblDistrict.Text = "District";
            lblDistrict.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDistrict.ForeColor = Color.FromArgb(45, 45, 45);
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(36, 174);
            mainPanel.Controls.Add(lblDistrict);

            // DISTRICT TEXTBOX

            txtDistrict = new TextBox();
            txtDistrict.Location = new Point(36, 200);
            txtDistrict.Size = new Size(360, 28);
            txtDistrict.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtDistrict);

            // PHONE LABEL

            lblPhone = new Label();
            lblPhone.Text = "Phone Number";
            lblPhone.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 45, 45);
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(36, 248);
            mainPanel.Controls.Add(lblPhone);

            // PHONE TEXTBOX

            txtPhone = new TextBox();
            txtPhone.Location = new Point(36, 274);
            txtPhone.Size = new Size(360, 28);
            txtPhone.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtPhone);

            // ADD HOSPITAL BUTTON

            btnAddHospital = new Button();
            btnAddHospital.Text = "Add Hospital";
            btnAddHospital.Size = new Size(166, 38);
            btnAddHospital.Location = new Point(36, 316);
            btnAddHospital.BackColor = Color.FromArgb(160, 0, 20);
            btnAddHospital.ForeColor = Color.White;
            btnAddHospital.FlatStyle = FlatStyle.Flat;
            btnAddHospital.FlatAppearance.BorderSize = 0;
            btnAddHospital.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnAddHospital.Cursor = Cursors.Hand;

            btnAddHospital.Click += BtnAddHospital_Click;

            mainPanel.Controls.Add(btnAddHospital);

            // CLEAR BUTTON

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Size = new Size(166, 38);
            btnClear.Location = new Point(230, 316);
            btnClear.BackColor = Color.FromArgb(120, 120, 120);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;

            btnClear.Click += BtnClear_Click;

            mainPanel.Controls.Add(btnClear);
        }

#endregion
    }
}
