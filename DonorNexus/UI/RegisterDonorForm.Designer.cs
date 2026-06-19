using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus
{
    partial class RegisterDonorForm
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

            this.Text = "Register Donor";
            this.Size = new Size(900, 640);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 246, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // TITLE

            lblTitle = new Label();
            lblTitle.Text = "Register Blood Donor";
            lblTitle.Font = new Font("Segoe UI Semibold", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(292, 24);

            this.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text = "Enter donor details carefully. All fields are required except Google Map Link.";
            lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(228, 66);

            this.Controls.Add(lblSubtitle);

            // MAIN PANEL

            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(790, 420);
            mainPanel.Location = new Point(50, 110);
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(mainPanel);

            // LEFT SIDE CONTROLS

            lblName = new Label();
            lblName.Text = "Full Name";
            lblName.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 45, 45);
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 28);
            mainPanel.Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(38, 54);
            txtName.Size = new Size(320, 28);
            txtName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtName);

            lblCNIC = new Label();
            lblCNIC.Text = "CNIC";
            lblCNIC.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblCNIC.ForeColor = Color.FromArgb(45, 45, 45);
            lblCNIC.AutoSize = true;
            lblCNIC.Location = new Point(38, 100);
            mainPanel.Controls.Add(lblCNIC);

            txtCNIC = new TextBox();
            txtCNIC.Location = new Point(38, 126);
            txtCNIC.Size = new Size(320, 28);
            txtCNIC.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtCNIC);

            lblPhone = new Label();
            lblPhone.Text = "Phone Number";
            lblPhone.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 45, 45);
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(38, 172);
            mainPanel.Controls.Add(lblPhone);

            txtPhone = new TextBox();
            txtPhone.Location = new Point(38, 198);
            txtPhone.Size = new Size(320, 28);
            txtPhone.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtPhone);

            lblGender = new Label();
            lblGender.Text = "Gender";
            lblGender.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(45, 45, 45);
            lblGender.AutoSize = true;
            lblGender.Location = new Point(38, 244);
            mainPanel.Controls.Add(lblGender);

            cmbGender = new ComboBox();
            cmbGender.Location = new Point(38, 270);
            cmbGender.Size = new Size(320, 28);
            cmbGender.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            mainPanel.Controls.Add(cmbGender);

            lblAge = new Label();
            lblAge.Text = "Age";
            lblAge.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(45, 45, 45);
            lblAge.AutoSize = true;
            lblAge.Location = new Point(38, 316);
            mainPanel.Controls.Add(lblAge);

            txtAge = new TextBox();
            txtAge.Location = new Point(38, 342);
            txtAge.Size = new Size(320, 28);
            txtAge.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtAge);

            // RIGHT SIDE CONTROLS

            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 45, 45);
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(420, 28);
            mainPanel.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(420, 54);
            txtEmail.Size = new Size(320, 28);
            txtEmail.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtEmail);

            lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 45, 45);
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(420, 100);
            mainPanel.Controls.Add(lblPassword);

            txtPassword = new TextBox();
            txtPassword.Location = new Point(420, 126);
            txtPassword.Size = new Size(320, 28);
            txtPassword.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtPassword.PasswordChar = '*';
            mainPanel.Controls.Add(txtPassword);

            lblBloodGroup = new Label();
            lblBloodGroup.Text = "Blood Group";
            lblBloodGroup.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblBloodGroup.ForeColor = Color.FromArgb(45, 45, 45);
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(420, 172);
            mainPanel.Controls.Add(lblBloodGroup);

            cmbBloodGroup = new ComboBox();
            cmbBloodGroup.Location = new Point(420, 198);
            cmbBloodGroup.Size = new Size(320, 28);
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

            lblCity = new Label();
            lblCity.Text = "City";
            lblCity.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 45, 45);
            lblCity.AutoSize = true;
            lblCity.Location = new Point(420, 244);
            mainPanel.Controls.Add(lblCity);

            txtCity = new TextBox();
            txtCity.Location = new Point(420, 270);
            txtCity.Size = new Size(320, 28);
            txtCity.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtCity);

            lblDistrict = new Label();
            lblDistrict.Text = "District";
            lblDistrict.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblDistrict.ForeColor = Color.FromArgb(45, 45, 45);
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(420, 316);
            mainPanel.Controls.Add(lblDistrict);

            txtDistrict = new TextBox();
            txtDistrict.Location = new Point(420, 342);
            txtDistrict.Size = new Size(320, 28);
            txtDistrict.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtDistrict);

            lblMap = new Label();
            lblMap.Text = "Google Map Link (Optional)";
            lblMap.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblMap.ForeColor = Color.FromArgb(45, 45, 45);
            lblMap.AutoSize = true;
            lblMap.Location = new Point(38, 382);
            mainPanel.Controls.Add(lblMap);

            txtMap = new TextBox();
            txtMap.Location = new Point(222, 378);
            txtMap.Size = new Size(320, 28);
            txtMap.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtMap.Size = new Size(520, 28);
            mainPanel.Controls.Add(txtMap);

            // REGISTER BUTTON

            btnRegister = new Button();
            btnRegister.Text = "Register Donor";
            btnRegister.Size = new Size(230, 46);
            btnRegister.Location = new Point(330, 548);

            btnRegister.BackColor = Color.FromArgb(160, 0, 20);
            btnRegister.ForeColor = Color.White;

            btnRegister.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            btnRegister.FlatStyle = FlatStyle.Flat;

            btnRegister.Click += BtnRegister_Click;

            this.Controls.Add(btnRegister);
        }

#endregion
    }
}
