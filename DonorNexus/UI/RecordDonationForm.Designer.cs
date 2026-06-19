using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class RecordDonationForm
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

        private void InitializeComponent()
        {
            this.Text = "Record Donation";
            this.Size = new Size(620, 430);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 246, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            Panel topPanel = new Panel();
            topPanel.Size = new Size(620, 88);
            topPanel.Location = new Point(0, 0);
            topPanel.BackColor = Color.FromArgb(160, 0, 20);
            this.Controls.Add(topPanel);

            Label lblTitle = new Label();
            lblTitle.Text = "Record Donation";
            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(178, 24);
            topPanel.Controls.Add(lblTitle);

            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(510, 260);
            mainPanel.Location = new Point(48, 120);
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(mainPanel);

            Label lblDonor = new Label();
            lblDonor.Text = "Donor";
            lblDonor.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDonor.AutoSize = true;
            lblDonor.Location = new Point(34, 26);
            mainPanel.Controls.Add(lblDonor);

            cmbDonor = new ComboBox();
            cmbDonor.Location = new Point(34, 52);
            cmbDonor.Size = new Size(440, 28);
            cmbDonor.DropDownStyle = ComboBoxStyle.DropDownList;
            mainPanel.Controls.Add(cmbDonor);

            Label lblHospital = new Label();
            lblHospital.Text = "Hospital";
            lblHospital.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblHospital.AutoSize = true;
            lblHospital.Location = new Point(34, 94);
            mainPanel.Controls.Add(lblHospital);

            cmbHospital = new ComboBox();
            cmbHospital.Location = new Point(34, 120);
            cmbHospital.Size = new Size(270, 28);
            cmbHospital.DropDownStyle = ComboBoxStyle.DropDownList;
            mainPanel.Controls.Add(cmbHospital);

            Label lblDate = new Label();
            lblDate.Text = "Donation Date";
            lblDate.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(330, 94);
            mainPanel.Controls.Add(lblDate);

            dtpDonationDate = new DateTimePicker();
            dtpDonationDate.Location = new Point(330, 120);
            dtpDonationDate.Size = new Size(144, 28);
            dtpDonationDate.Format = DateTimePickerFormat.Short;
            dtpDonationDate.MaxDate = System.DateTime.Today;
            mainPanel.Controls.Add(dtpDonationDate);

            Label lblUnits = new Label();
            lblUnits.Text = "Units Donated";
            lblUnits.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblUnits.AutoSize = true;
            lblUnits.Location = new Point(34, 162);
            mainPanel.Controls.Add(lblUnits);

            nudUnits = new NumericUpDown();
            nudUnits.Location = new Point(34, 188);
            nudUnits.Size = new Size(120, 28);
            nudUnits.Minimum = 1;
            nudUnits.Maximum = 10;
            nudUnits.Value = 1;
            mainPanel.Controls.Add(nudUnits);

            btnSave = new Button();
            btnSave.Text = "Save Donation";
            btnSave.Size = new Size(150, 38);
            btnSave.Location = new Point(188, 184);
            btnSave.BackColor = Color.FromArgb(160, 0, 20);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += BtnSave_Click;
            mainPanel.Controls.Add(btnSave);

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Size = new Size(120, 38);
            btnClear.Location = new Point(354, 184);
            btnClear.BackColor = Color.FromArgb(120, 120, 120);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += BtnClear_Click;
            mainPanel.Controls.Add(btnClear);
        }
    }
}
