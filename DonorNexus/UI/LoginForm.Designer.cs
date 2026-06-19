using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class LoginForm
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

            this.Text = "Donor Nexus Login";

            this.Size = new Size(560, 500);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor = Color.FromArgb(250, 246, 247);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // MAIN PANEL

            mainPanel = new Panel();

            mainPanel.Size = new Size(400, 350);

            mainPanel.Location = new Point(72, 58);

            mainPanel.BackColor = Color.White;

            mainPanel.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(mainPanel);

            // TITLE

            lblTitle = new Label();

            lblTitle.Text = "Donor Nexus Login";

            lblTitle.Font =
                new Font("Segoe UI Semibold", 20,
                FontStyle.Bold);

            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);

            lblTitle.AutoSize = true;

            lblTitle.Location = new Point(60, 24);

            mainPanel.Controls.Add(lblTitle);

            // ROLE LABEL

            lblRole = new Label();

            lblRole.Text = "Login As";

            lblRole.Font =
                new Font("Segoe UI Semibold", 10,
                FontStyle.Bold);

            lblRole.Location = new Point(42, 86);

            lblRole.AutoSize = true;

            mainPanel.Controls.Add(lblRole);

            // ROLE COMBOBOX

            cmbRole = new ComboBox();

            cmbRole.Location = new Point(42, 112);

            cmbRole.Size = new Size(315, 30);

            cmbRole.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRole.Font =
                new Font("Segoe UI", 10);

            cmbRole.Items.Add("Donor");

            cmbRole.Items.Add("Admin");

            mainPanel.Controls.Add(cmbRole);

            // EMAIL LABEL

            lblEmail = new Label();

            lblEmail.Text = "Email / Admin Name";

            lblEmail.Font =
                new Font("Segoe UI Semibold", 10,
                FontStyle.Bold);

            lblEmail.Location = new Point(42, 154);

            lblEmail.AutoSize = true;

            mainPanel.Controls.Add(lblEmail);

            // EMAIL TEXTBOX

            txtEmail = new TextBox();

            txtEmail.Location = new Point(42, 180);

            txtEmail.Size = new Size(315, 30);

            txtEmail.Font =
                new Font("Segoe UI", 10);

            mainPanel.Controls.Add(txtEmail);

            // PASSWORD LABEL

            lblPassword = new Label();

            lblPassword.Text = "Password";

            lblPassword.Font =
                new Font("Segoe UI Semibold", 10,
                FontStyle.Bold);

            lblPassword.Location = new Point(42, 222);

            lblPassword.AutoSize = true;

            mainPanel.Controls.Add(lblPassword);

            // PASSWORD TEXTBOX

            txtPassword = new TextBox();

            txtPassword.Location = new Point(42, 248);

            txtPassword.Size = new Size(315, 30);

            txtPassword.PasswordChar = '*';

            txtPassword.Font =
                new Font("Segoe UI", 10);

            mainPanel.Controls.Add(txtPassword);

            // LOGIN BUTTON

            btnLogin = new Button();

            btnLogin.Text = "Login";

            btnLogin.Size = new Size(315, 44);

            btnLogin.Location = new Point(42, 298);

            btnLogin.BackColor = Color.FromArgb(160, 0, 20);

            btnLogin.ForeColor = Color.White;

            btnLogin.FlatStyle = FlatStyle.Flat;

            btnLogin.FlatAppearance.BorderSize = 0;

            btnLogin.Font =
                new Font("Segoe UI", 11,
                FontStyle.Bold);

            btnLogin.Cursor = Cursors.Hand;

            btnLogin.Click += BtnLogin_Click;

            mainPanel.Controls.Add(btnLogin);
        }

        #endregion
    }
}
