using FitnessTracker.Controller;
using FitnessTracker.Model;
using FitnessTracker.View.Util;
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
        string EventToHandle = "Add";

        public LogWorkoutForm(string evenToHandle, long workoutId)
        {
            InitializeComponent();

            this.EventToHandle = evenToHandle;

            if (evenToHandle.Equals("Edit") && workoutId > 0)
            {
                lblManageVehicleTitle.Text = "Edit Vehicle Details";
                btnSaveWorkout.Text = "Update";

                //LoadVehicleDataToForm(vehicleId);
            }
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

        private void btnSaveWorkout_Click(object sender, EventArgs e)
        {
            string name = txtWorkoutName.Text;
            string type = (string)cmbWorkoutType.SelectedValue;
            DateTime date = dtpWorkoutDate.Value;
            DateTime start = dtpStartTime.Value;
            DateTime end = dtpEndTime.Value;
            string weigth = txtWeigth.Text;
            string reps = txtReps.Text;
            string sets = txtSets.Text;
            string comment = txtComment.Text;
            bool isRecurring = chbIsRecurring.Checked;

            /*int mileage = 0;
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
                mileage = Convert.ToInt32(txtVehicleMileage.Text);*/

            if (EventToHandle.Equals("Add"))
            {
                try
                {
                    WorkoutController workoutController = new();
                    WorkoutTypeController workoutTypeController = new();

                    WorkoutTypeModel workoutType = workoutTypeController.GetById(long.Parse(type));

                    if (workoutType == null)
                    {
                        FormsHandler.InvalidValueMessage("Workout type is invalid.");
                        return;
                    }

                    WorkoutModel workout = new()
                    {
                        Name = name,
                        Type = workoutType,
                        Date = date,
                        StartTime = start,
                        EndTime = end,
                        Weight = int.Parse(weigth),
                        Reps = int.Parse(reps),
                        Sets = int.Parse(sets),
                        IsRecurring = isRecurring
                    };

                    workoutController.LogWorkout(workout);

                    FormsHandler.OperationSuccessMessage("Workout logged.");
                }
                catch (Exception ex)
                {
                    FormsHandler.OperationFailedErrorMessage(ex.Message);
                }
                finally
                {
                    
                }
            }
            else if (EventToHandle.Equals("Edit"))
            {
                // handle workout details edit
            }
        }

        private void txtSets_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void txtReps_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void txtWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void btnClearWorkoutInfo_Click(object sender, EventArgs e)
        {
            cmbWorkoutType.SelectedValue = "NA";
            txtSets.Text = "";
            txtReps.Text = "";
            txtComment.Text = "";
            txtWeigth.Text = "";
            txtWorkoutName.Text = "";
        }

        private void AddWorkout_Load(object sender, EventArgs e)
        {
            dtpWorkoutDate.Format = DateTimePickerFormat.Custom;
            dtpWorkoutDate.CustomFormat = "ddd dd MMM yyyy"; // display the date as "Mon 27 Feb 2023". 

            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;

            WorkoutTypeController workoutTypeController = new();
            DropDownListPopulator.PopulateCombobox(workoutTypeController.ToComboboxList(), cmbWorkoutType);
        }
    }
}
