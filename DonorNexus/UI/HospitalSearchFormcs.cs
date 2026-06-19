using DonorNexus.DAL;
using System;
using DonorNexus.Models;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    public partial class HospitalSearchForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblCity;
        Label lblDistrict;
        Label lblBloodGroup;

        // TEXTBOXES

        TextBox txtCity;
        TextBox txtDistrict;

        // COMBOBOX

        ComboBox cmbBloodGroup;

        // BUTTONS

        Button btnSearch;
        Button btnClear;

        // DATAGRIDVIEW

        DataGridView dgvHospitals;

        // PANELS

        Panel topPanel;
        Panel searchPanel;

        public HospitalSearchForm()
        {
            InitializeComponent();
        }

        







        // SEARCH HOSPITALS

        private void BtnSearch_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string city = txtCity.Text.Trim();
                string district = txtDistrict.Text.Trim();
                string bloodGroup = cmbBloodGroup.Text.Trim();

                // VALIDATION

                if (
                    city == "" ||
                    district == "" ||
                    bloodGroup == ""
                   )
                {
                    MessageBox.Show( "Please fill all fields.");

                    return;
                }

                HospitalSearchFilter filter =
                    new HospitalSearchFilter(
                        city,
                        district,
                        bloodGroup);

                HospitalDAL hospitalDAL =
                    new HospitalDAL();

                DataTable table =
                    hospitalDAL.SearchHospitals(filter);

                dgvHospitals.DataSource =
                    table;

                // NO RESULTS

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No hospitals found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLEAR FIELDS

        private void ClearFields()
        {
            txtCity.Clear();

            txtDistrict.Clear();

            cmbBloodGroup.SelectedIndex = -1;

            dgvHospitals.DataSource = null;
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
