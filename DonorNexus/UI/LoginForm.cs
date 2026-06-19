using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class LoginForm : Form
    {
        // CONTROLS

        Label lblTitle;
        Label lblRole;
        Label lblEmail;
        Label lblPassword;

        ComboBox cmbRole;

        TextBox txtEmail;
        TextBox txtPassword;

        Button btnLogin;

        Panel mainPanel;

        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void BtnLogin_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // VALIDATION

                if (
                    cmbRole.Text == "" ||
                    txtEmail.Text == "" ||
                    txtPassword.Text == ""
                   )
                {
                    MessageBox.Show(
                        "Please fill all fields.");

                    return;
                }

                LoginRequest request =
                    new LoginRequest(
                        cmbRole.Text,
                        txtEmail.Text.Trim(),
                        txtPassword.Text);

                AuthDAL authDAL =
                    new AuthDAL();

                LoginResult result =
                    authDAL.Login(request);

                if (result.IsSuccess)
                {
                    MessageBox.Show( "Login Successful");

                    // DONOR DASHBOARD
                    if (result.Role == "Donor")
                    {
                        this.Hide();

                        DonorDashboardForm donorDashboard =
                            new DonorDashboardForm(result.DonorID);

                        donorDashboard.Show();
                    }

                    // ADMIN DASHBOARD

                    else if (result.Role == "Admin")
                    {
                        this.Hide();

                        AdminDashboardForm adminDashboard =
                            new AdminDashboardForm();

                        adminDashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Login Credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

