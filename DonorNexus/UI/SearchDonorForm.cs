using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class SearchDonorForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblBloodGroup;
        Label lblCity;
        Label lblDistrict;

        // CONTROLS

        ComboBox cmbBloodGroup;

        TextBox txtCity;
        TextBox txtDistrict;

        Button btnSearch;

        DataGridView dgvDonors;

        Panel topPanel;
        Panel searchPanel;

        public SearchDonorForm()
        {
            InitializeComponent();
        }

        







        // SEARCH BUTTON EVENT

        private void BtnSearch_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // VALIDATIONS

                string bloodGroup = cmbBloodGroup.Text.Trim();
                string city = txtCity.Text.Trim();
                string district = txtDistrict.Text.Trim();

                if (
                    bloodGroup == "" ||
                    city == "" ||
                    district == ""
                   )
                {
                    MessageBox.Show(
                        "Please fill all search fields.");

                    return;
                }

                SearchFilter filter =
                    new SearchFilter(
                        bloodGroup,
                        city,
                        district);

                DonorDAL donorDAL =
                    new DonorDAL();

                DataTable table =
                    donorDAL.SearchDonors(filter);

                // SHOW DATA

                dgvDonors.DataSource = table;

                // NO RECORD FOUND

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No Available Donors Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
