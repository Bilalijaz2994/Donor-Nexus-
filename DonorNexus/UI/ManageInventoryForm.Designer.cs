using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class ManageInventoryForm
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

            this.Text = "Manage Blood Inventory";
            this.Size = new Size(1050, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 246, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // SIDEBAR PANEL

            sidebarPanel = new Panel();
            sidebarPanel.Size = new Size(240, 680);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.BackColor = Color.White;
            this.Controls.Add(sidebarPanel);

            Panel sidebarAccent = new Panel();
            sidebarAccent.Size = new Size(6, 680);
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
            lblSection.Text = "Inventory";
            lblSection.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSection.ForeColor = Color.FromArgb(101, 108, 122);
            lblSection.AutoSize = true;
            lblSection.Location = new Point(34, 74);
            sidebarPanel.Controls.Add(lblSection);

            Panel divider = new Panel();
            divider.Size = new Size(180, 1);
            divider.Location = new Point(30, 116);
            divider.BackColor = Color.FromArgb(242, 230, 233);
            sidebarPanel.Controls.Add(divider);

            btnDeleteHospital = new Button();
            btnDeleteHospital.Text = "Delete Hospital";
            btnDeleteHospital.Size = new Size(180, 40);
            btnDeleteHospital.Location = new Point(30, 438);
            btnDeleteHospital.BackColor = Color.FromArgb(45, 45, 45);
            btnDeleteHospital.ForeColor = Color.White;
            btnDeleteHospital.FlatStyle = FlatStyle.Flat;
            btnDeleteHospital.FlatAppearance.BorderSize = 0;
            btnDeleteHospital.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnDeleteHospital.Cursor = Cursors.Hand;
            btnDeleteHospital.Click += BtnDeleteHospital_Click;
            sidebarPanel.Controls.Add(btnDeleteHospital);

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Size = new Size(180, 40);
            btnClear.Location = new Point(30, 488);
            btnClear.BackColor = Color.FromArgb(120, 120, 120);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += BtnClear_Click;
            sidebarPanel.Controls.Add(btnClear);

            // PAGE TITLE

            lblTitle = new Label();
            lblTitle.Text = "Manage Blood Inventory";
            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(272, 28);
            this.Controls.Add(lblTitle);

            // MAIN PANEL

            mainPanel = new Panel();
            mainPanel.Size = new Size(725, 170);
            mainPanel.Location = new Point(274, 88);
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(mainPanel);

            lblHospital = new Label();
            lblHospital.Text = "Hospital";
            lblHospital.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblHospital.ForeColor = Color.FromArgb(34, 39, 51);
            lblHospital.AutoSize = true;
            lblHospital.Location = new Point(30, 26);
            mainPanel.Controls.Add(lblHospital);

            cmbHospital = new ComboBox();
            cmbHospital.Location = new Point(30, 52);
            cmbHospital.Size = new Size(285, 28);
            cmbHospital.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            cmbHospital.DropDownStyle = ComboBoxStyle.DropDownList;
            mainPanel.Controls.Add(cmbHospital);

            lblBloodGroup = new Label();
            lblBloodGroup.Text = "Blood Group";
            lblBloodGroup.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblBloodGroup.ForeColor = Color.FromArgb(34, 39, 51);
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(350, 26);
            mainPanel.Controls.Add(lblBloodGroup);

            cmbBloodGroup = new ComboBox();
            cmbBloodGroup.Location = new Point(350, 52);
            cmbBloodGroup.Size = new Size(150, 28);
            cmbBloodGroup.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodGroup.Items.Add("A+");
            cmbBloodGroup.Items.Add("A-");
            cmbBloodGroup.Items.Add("B+");
            cmbBloodGroup.Items.Add("B-");
            cmbBloodGroup.Items.Add("AB+");
            cmbBloodGroup.Items.Add("AB-");
            cmbBloodGroup.Items.Add("O+");
            cmbBloodGroup.Items.Add("O-");
            mainPanel.Controls.Add(cmbBloodGroup);

            lblUnits = new Label();
            lblUnits.Text = "Units Available";
            lblUnits.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblUnits.ForeColor = Color.FromArgb(34, 39, 51);
            lblUnits.AutoSize = true;
            lblUnits.Location = new Point(535, 26);
            mainPanel.Controls.Add(lblUnits);

            nudUnits = new NumericUpDown();
            nudUnits.Location = new Point(535, 52);
            nudUnits.Size = new Size(140, 28);
            nudUnits.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            nudUnits.Minimum = 0;
            nudUnits.Maximum = 10000;
            mainPanel.Controls.Add(nudUnits);

            btnSaveUnits = new Button();
            btnSaveUnits.Text = "Save Units";
            btnSaveUnits.Size = new Size(645, 42);
            btnSaveUnits.Location = new Point(30, 108);
            btnSaveUnits.BackColor = Color.FromArgb(160, 0, 20);
            btnSaveUnits.ForeColor = Color.White;
            btnSaveUnits.FlatStyle = FlatStyle.Flat;
            btnSaveUnits.FlatAppearance.BorderSize = 0;
            btnSaveUnits.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnSaveUnits.Cursor = Cursors.Hand;
            btnSaveUnits.Click += BtnSaveUnits_Click;
            mainPanel.Controls.Add(btnSaveUnits);

            // GRID

            Label lblGridTitle = new Label();
            lblGridTitle.Text = "Saved Inventory";
            lblGridTitle.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(34, 39, 51);
            lblGridTitle.AutoSize = true;
            lblGridTitle.Location = new Point(274, 284);
            this.Controls.Add(lblGridTitle);

            dgvInventory = new DataGridView();
            dgvInventory.Location = new Point(274, 318);
            dgvInventory.Size = new Size(725, 300);
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.FixedSingle;
            dgvInventory.RowTemplate.Height = 28;
            dgvInventory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 0, 20);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.SelectionChanged += DgvInventory_SelectionChanged;
            this.Controls.Add(dgvInventory);
        }

        #endregion
    }
}
