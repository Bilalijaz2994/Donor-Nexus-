using System;
using System.Drawing;
using System.Windows.Forms;
using DonorNexus.Models;
using DonorNexus.DAL;

namespace DonorNexus
{
    public  partial class RegisterDonorForm : Form
    {
        // Labels

        Label lblTitle;

        Label lblName;
        Label lblCNIC;
        Label lblPhone;
        Label lblGender;
        Label lblAge;
        Label lblEmail;
        Label lblPassword;
        Label lblBloodGroup;
        Label lblCity;
        Label lblDistrict;
        Label lblMap;

        // TextBoxes

        TextBox txtName;
        TextBox txtCNIC;
        TextBox txtPhone;
        TextBox txtAge;
        TextBox txtEmail;
        TextBox txtPassword;
        TextBox txtCity;
        TextBox txtDistrict;
        TextBox txtMap;

        // ComboBoxes

        ComboBox cmbGender;
        ComboBox cmbBloodGroup;

        // Button

        Button btnRegister;

        public RegisterDonorForm()
        {
            InitializeComponent();
        }

        







        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // EMPTY FIELD VALIDATIONS

                if (txtName.Text == "" ||
                    txtCNIC.Text == "" ||
                    txtPhone.Text == "" ||
                    txtAge.Text == "" ||
                    txtEmail.Text == "" ||
                    txtPassword.Text == "" ||
                    txtCity.Text == "" ||
                    txtDistrict.Text == "")
                {
                    MessageBox.Show(
                        "Please fill all required fields.");

                    return;
                }

                

                Donor donor = new Donor();

                donor.FullName = txtName.Text;
                donor.CNIC = txtCNIC.Text;
                donor.PhoneNumber = txtPhone.Text;
                donor.Gender = cmbGender.Text;

                donor.Age =
                    Convert.ToInt32(txtAge.Text);

                donor.Email = txtEmail.Text;
                donor.Password = txtPassword.Text;

                donor.BloodGroup =
                    cmbBloodGroup.Text;

                donor.City = txtCity.Text;
                donor.District = txtDistrict.Text;

                donor.GoogleMapLink =
                    txtMap.Text;

                donor.IsAvailable = true;
                donor.TotalDonations = 0;

                DonorDAL donorDAL =
                    new DonorDAL();

                donorDAL.RegisterDonor(donor);

                MessageBox.Show(
                    "Donor Registered Successfully");

                // CLEAR FIELDS

                txtName.Clear();
                txtCNIC.Clear();
                txtPhone.Clear();
                txtAge.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtCity.Clear();
                txtDistrict.Clear();
                txtMap.Clear();

                cmbGender.SelectedIndex = -1;
                cmbBloodGroup.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
