using System;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
            SearchDonorForm donorForm = new SearchDonorForm();
            donorForm.Show();
        }

        private void btnSearchHospital_Click(object sender, EventArgs e)
        {
            HospitalSearchForm hospitalForm = new HospitalSearchForm();
            hospitalForm.Show();
        }

        private void btnRegisterDonor_Click(object sender, EventArgs e)
        {
            DonorNexus.RegisterDonorForm registerForm = new DonorNexus.RegisterDonorForm();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactUsForm contactForm = new ContactUsForm();
            contactForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
