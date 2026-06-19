using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class ContactUsForm
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

            this.Text = "Contact Us";

            this.Size = new Size(680, 610);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor = Color.FromArgb(250, 246, 247);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // TITLE

            lblTitle = new Label();

            lblTitle.Text = "Contact Admin";

            lblTitle.Font =
                new Font("Segoe UI Semibold", 22,
                FontStyle.Bold);

            lblTitle.ForeColor = Color.FromArgb(160, 0, 20);

            lblTitle.AutoSize = true;

            lblTitle.Location = new Point(218, 22);

            this.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text =
                "Send your question or feedback to the Donor Nexus admin team.";

            lblSubtitle.Font =
                new Font("Segoe UI", 10,
                FontStyle.Regular);

            lblSubtitle.ForeColor = Color.DimGray;

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location = new Point(142, 62);

            this.Controls.Add(lblSubtitle);

            // MAIN PANEL

            mainPanel = new Panel();

            mainPanel.Size = new Size(540, 430);

            mainPanel.Location = new Point(62, 108);

            mainPanel.BackColor = Color.White;

            mainPanel.BorderStyle =
                BorderStyle.FixedSingle;

            this.Controls.Add(mainPanel);

            // NAME

            lblName = new Label();
            lblName.Text = "Full Name";
            lblName.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 45, 45);
            lblName.AutoSize = true;
            lblName.Location = new Point(34, 28);
            mainPanel.Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(34, 54);
            txtName.Size = new Size(468, 28);
            txtName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtName);

            // EMAIL

            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 45, 45);
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 96);
            mainPanel.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(34, 122);
            txtEmail.Size = new Size(468, 28);
            txtEmail.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtEmail);

            // SUBJECT

            lblSubject = new Label();
            lblSubject.Text = "Subject";
            lblSubject.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblSubject.ForeColor = Color.FromArgb(45, 45, 45);
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(34, 164);
            mainPanel.Controls.Add(lblSubject);

            txtSubject = new TextBox();
            txtSubject.Location = new Point(34, 190);
            txtSubject.Size = new Size(468, 28);
            txtSubject.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.Controls.Add(txtSubject);

            // MESSAGE

            lblMessage = new Label();
            lblMessage.Text = "Message";
            lblMessage.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            lblMessage.ForeColor = Color.FromArgb(45, 45, 45);
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(34, 232);
            mainPanel.Controls.Add(lblMessage);

            txtMessage = new TextBox();

            txtMessage.Location =
                new Point(34, 258);

            txtMessage.Size =
                new Size(468, 88);

            txtMessage.Multiline = true;

            txtMessage.Font =
                new Font("Segoe UI", 10,
                FontStyle.Regular);

            mainPanel.Controls.Add(txtMessage);

            // SEND BUTTON

            btnSend = new Button();

            btnSend.Text = "Send Message";

            btnSend.Size =
                new Size(468, 44);

            btnSend.Location =
                new Point(34, 366);

            btnSend.BackColor =
                Color.FromArgb(160, 0, 20);

            btnSend.ForeColor =
                Color.White;

            btnSend.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            btnSend.FlatStyle =
                FlatStyle.Flat;

            btnSend.FlatAppearance.BorderSize = 0;

            btnSend.Cursor = Cursors.Hand;

            btnSend.Click += BtnSend_Click;

            mainPanel.Controls.Add(btnSend);
        }

#endregion
    }
}
