using System;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DonorNexus.DAL;
using DonorNexus.Models;

namespace DonorNexus.UI
{
    public partial class ManageInventoryForm : Form
    {
        // LABELS

        Label lblTitle;
        Label lblHospital;
        Label lblBloodGroup;
        Label lblUnits;

        // COMBOBOXES

        ComboBox cmbHospital;
        ComboBox cmbBloodGroup;

        // UNIT CONTROL

        NumericUpDown nudUnits;

        // BUTTONS

        Button btnSaveUnits;
        Button btnDeleteHospital;
        Button btnClear;

        // GRID

        DataGridView dgvInventory;

        // PANELS

        Panel sidebarPanel;
        Panel mainPanel;

        private readonly Color primaryRed = Color.FromArgb(160, 0, 20);
        private readonly Color softRed = Color.FromArgb(255, 238, 241);
        private readonly Color pageBack = Color.FromArgb(250, 246, 247);
        private readonly Color textDark = Color.FromArgb(34, 39, 51);
        private readonly Color textMuted = Color.FromArgb(101, 108, 122);

        public ManageInventoryForm()
        {
            InitializeComponent();

            if (IsDesignerOpen())
            {
                return;
            }

            LoadHospitals();

            LoadInventory();
        }

        private bool IsDesignerOpen()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
                Process.GetCurrentProcess().ProcessName.Equals("devenv", StringComparison.OrdinalIgnoreCase);
        }

        







        // LOAD HOSPITALS

        private void LoadHospitals()
        {
            try
            {
                HospitalDAL hospitalDAL =
                    new HospitalDAL();

                DataTable table =
                    hospitalDAL.GetHospitals();

                cmbHospital.DataSource =
                    table;

                cmbHospital.DisplayMember =
                    "HospitalName";

                cmbHospital.ValueMember =
                    "HospitalID";

                cmbHospital.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // SAVE INVENTORY

        private void BtnSaveUnits_Click(
            object sender,
            EventArgs e)
        {
            SaveInventoryUnits();
        }

        private void SaveInventoryUnits()
        {
            try
            {
                if (cmbHospital.Text == "" ||
                    cmbBloodGroup.Text == "")
                {
                    MessageBox.Show(
                        "Please select hospital and blood group.");

                    return;
                }

                int units =
                    Convert.ToInt32(nudUnits.Value);

                BloodInventory inventory =
                    new BloodInventory(
                        0,
                        Convert.ToInt32(cmbHospital.SelectedValue),
                        cmbBloodGroup.Text.Trim(),
                        units);

                InventoryDAL inventoryDAL =
                    new InventoryDAL();

                inventoryDAL.SaveInventory(inventory);

                MessageBox.Show(
                    "Inventory Saved Successfully");

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE HOSPITAL

        private void BtnDeleteHospital_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbHospital.Text == "")
                {
                    MessageBox.Show(
                        "Select hospital.");

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Delete selected hospital and its inventory?",
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    HospitalDAL hospitalDAL =
                        new HospitalDAL();

                    hospitalDAL.DeleteHospital(
                        Convert.ToInt32(cmbHospital.SelectedValue));

                    MessageBox.Show(
                        "Hospital Deleted");

                    ClearFields();

                    LoadHospitals();

                    LoadInventory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LOAD INVENTORY

        private void LoadInventory()
        {
            try
            {
                InventoryDAL inventoryDAL =
                    new InventoryDAL();

                DataTable table =
                    inventoryDAL.GetInventory();

                dgvInventory.DataSource =
                    table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvInventory_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvInventory.SelectedRows[0];

            if (row.Cells["HospitalName"].Value != null)
            {
                cmbHospital.Text =
                    row.Cells["HospitalName"].Value.ToString();
            }

            if (row.Cells["BloodGroup"].Value != null)
            {
                cmbBloodGroup.Text =
                    row.Cells["BloodGroup"].Value.ToString();
            }

            if (row.Cells["UnitsAvailable"].Value != null)
            {
                int units;

                if (int.TryParse(
                    row.Cells["UnitsAvailable"].Value.ToString(),
                    out units))
                {
                    nudUnits.Value = units;
                }
            }
        }

        // CLEAR

        private void ClearFields()
        {
            cmbHospital.SelectedIndex = -1;

            cmbBloodGroup.SelectedIndex = -1;

            nudUnits.Value = 0;
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
