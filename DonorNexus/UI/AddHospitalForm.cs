using System;
using System.Drawing;
using System.Windows.Forms;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class AddHospitalForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblHospitalName;
        Label lblCity;
        Label lblDistrict;
        Label lblPhone;

        // TEXTBOXES

        TextBox txtHospitalName;
        TextBox txtCity;
        TextBox txtDistrict;
        TextBox txtPhone;

        // BUTTONS

        Button btnAddHospital;
        Button btnClear;

        // PANELS

        Panel mainPanel;
        Panel topPanel;

        public AddHospitalForm()
        {
            InitializeComponent();
        }

         // ADD HOSPITAL

        private void BtnAddHospital_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // VALIDATION

                string hospitalName = txtHospitalName.Text.Trim();
                string city = txtCity.Text.Trim();
                string district = txtDistrict.Text.Trim();
                string phone = txtPhone.Text.Trim();

                if (
                    hospitalName == "" ||
                    city == "" ||
                    district == "" ||
                    phone == ""
                   )
                {
                    MessageBox.Show(
                        "Please fill all fields.");

                    return;
                }

                // PHONE VALIDATION

                if (
                    phone.Length != 11 ||
                    !phone.StartsWith("03")
                   )
                {
                    MessageBox.Show(
                        "Enter valid Pakistani phone number.");

                    return;
                }

                Hospital hospital =
                    new Hospital(
                        0,
                        hospitalName,
                        city,
                        district,
                        phone);

                HospitalDAL hospitalDAL =
                    new HospitalDAL();

                hospitalDAL.AddHospital(hospital);

                MessageBox.Show(
                    "Hospital Added Successfully");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLEAR FIELDS

        private void ClearFields()
        {
            txtHospitalName.Clear();

            txtCity.Clear();

            txtDistrict.Clear();

            txtPhone.Clear();
        }

        // CLEAR BUTTON

        private void BtnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }
    }
}
