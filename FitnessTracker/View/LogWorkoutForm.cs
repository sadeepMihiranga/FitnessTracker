using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.View
{
    public partial class LogWorkoutForm : Form
    {
        public LogWorkoutForm(string evenToHandle, long workoutId)
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            MainMenuForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        /* handle image selection */
        private void btnAddVehicleImage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.gif;*.png;*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtVehicleImageUrl.Text = openFileDialog.FileName;
                pictureBoxVehicleImage.Image = new Bitmap(openFileDialog.FileName);
            }*/
        }

        /* populate vehicle body type according to the vehicle type */
        private void VehicleType_Changed(object sender, EventArgs e)
        {
            /*var selectedValue = Convert.ToString(cmbVehicleType.SelectedValue);

            if (selectedValue.Split(',').Length > 1)
                return;

            if (selectedValue.Equals("VTCAR"))
            {
                cmbVehicleBodyType.Enabled = true;
                FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleBodyType, CommonRefference.VHBDTP);
            }
            else
            {
                cmbVehicleBodyType.DataSource = null;
                cmbVehicleBodyType.Items.Clear();
                cmbVehicleBodyType.Enabled = false;
            }*/
        }

        /* populate vehicle model type according to the vehicle make */
        private void VehicleMake_Changed(object sender, EventArgs e)
        {
            /*var selectedValue = Convert.ToString(cmbVehicleMake.SelectedValue);

            if (selectedValue.Split(',').Length > 1)
                return;

            CommonRefference commonRefference = new CommonRefference();
            DropDownListPopulator.polulateComboboxFromCommonRefrence(commonRefference.GetCommonRefferencesByCodeAndParentCode(CommonRefference.VHMDL, selectedValue), cmbVehicleModel);*/
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            /*string vehicleType = (string)cmbVehicleType.SelectedValue;
            string vehicleMake = (string)cmbVehicleMake.SelectedValue;
            string vehicleModel = (string)cmbVehicleModel.SelectedValue;
            string vehicleColor = (string)cmbVehicleColor.SelectedValue;
            string vehicleBodyType = (string)cmbVehicleBodyType.SelectedValue;
            string vehicleFuelType = (string)cmbVehicleFuelType.SelectedValue;
            string vehicleTransmission = (string)cmbVehicleTransmission.SelectedValue;
            string vehicleCondition = (string)cmbVehicleCondition.SelectedValue;
            string vin = txtVehicleVin.Text;
            string yom = txtVehicleYom.Text;

            int mileage = 0;
            double price = 0;
            Vehicle vehicle = null;
            String imageSavedLocation = null;

            if (String.IsNullOrEmpty(vehicleModel) || vehicleModel.Equals("NA"))
            {
                MessageBox.Show("Vehicle Model is Required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(vehicleMake) || vehicleMake.Equals("NA"))
            {
                MessageBox.Show("Vehicle Make is Required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(vehicleCondition) || vehicleCondition.Equals("NA"))
            {
                MessageBox.Show("Vehicle Condition is Required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(vin))
            {
                MessageBox.Show("VIN is Required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!String.IsNullOrEmpty(txtVehicleImageUrl.Text))
                imageSavedLocation = handleVehicleImageUpload(vehicleType, vin);

            if (String.IsNullOrEmpty(yom))
                yom = null;

            if (!String.IsNullOrEmpty(txtVehiclePrice.Text))
                price = Convert.ToDouble(txtVehiclePrice.Text);

            if (!String.IsNullOrEmpty(txtVehicleMileage.Text))
                mileage = Convert.ToInt32(txtVehicleMileage.Text);

            if (SubmitButtonStatus.Equals("Save"))
            {
                try
                {
                    vehicle = new Vehicle(vin, vehicleMake, vehicleModel, yom, vehicleColor, vehicleBodyType, vehicleTransmission,
                    vehicleFuelType, vehicleCondition, mileage, price, 1, 1, vehicleType);
                    long CreatedVehicleId = vehicle.InsertAVehicle(vehicle);

                    if (!String.IsNullOrEmpty(txtVehicleImageUrl.Text))
                        vehicle.InsertVehicleImage(CreatedVehicleId, imageSavedLocation);

                    MessageBox.Show("Vehicle Inserted. Id : " + CreatedVehicleId, "Opertation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    FormsHandler.ShowOperationFailedErrorMessage(ex.Message);
                }
                finally
                {
                    if (vehicle != null)
                        vehicle = null;
                }
            }
            else if (SubmitButtonStatus.Equals("Edit"))
            {
                // handle vehicle details edit
            }*/
        }

        private void txtVehicleMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void txtVehicleYom_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void txtVehiclePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void btnClearVehicleInfo_Click(object sender, EventArgs e)
        {
            cmbVehicleBodyType.SelectedValue = "NA";
            cmbVehicleColor.SelectedValue = "NA";
            cmbVehicleCondition.SelectedValue = "NA";
            cmbVehicleFuelType.SelectedValue = "NA";
            cmbVehicleMake.SelectedValue = "NA";
            cmbVehicleTransmission.SelectedValue = "NA";
            cmbVehicleType.SelectedValue = "NA";
            txtVehicleMileage.Text = "";
            txtVehicleVin.Text = "";
            txtVehicleYom.Text = "";
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            /*FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleType, CommonRefference.VHTPE);
            FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleMake, CommonRefference.VHMKE);
            FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleColor, CommonRefference.VHCLR);
            FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleFuelType, CommonRefference.VHFLTP);
            FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleTransmission, CommonRefference.VHTRNS);
            FormsHandler.PopulateDropDownListByCmrfCode(cmbVehicleCondition, CommonRefference.VHCDN);*/
        }
    }
}
