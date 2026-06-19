using System;
using System.Drawing;
using System.Windows.Forms;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class ContactUsForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblName;
        Label lblEmail;
        Label lblSubject;
        Label lblMessage;

        // TEXTBOXES

        TextBox txtName;
        TextBox txtEmail;
        TextBox txtSubject;
        TextBox txtMessage;

        // BUTTON

        Button btnSend;

        Panel mainPanel;

        public ContactUsForm()
        {
            InitializeComponent();
        }

        





        // SEND MESSAGE

        private void BtnSend_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // VALIDATIONS

                if (
                    txtName.Text == "" ||
                    txtEmail.Text == "" ||
                    txtSubject.Text == "" ||
                    txtMessage.Text == ""
                   )
                {
                    MessageBox.Show(
                        "Please fill all fields.");

                    return;
                }

                ContactMessage message =
                    new ContactMessage(
                        0,
                        txtName.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtSubject.Text.Trim(),
                        txtMessage.Text.Trim(),
                        DateTime.Now);

                ContactDAL contactDAL =
                    new ContactDAL();

                contactDAL.AddMessage(message);

                MessageBox.Show(
                    "Message Sent Successfully");

                // CLEAR FIELDS

                txtName.Clear();
                txtEmail.Clear();
                txtSubject.Clear();
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
