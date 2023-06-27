using FitnessTracker.Controller;
using FitnessTracker.Enum;
using FitnessTracker.Model;
using FitnessTracker.View.Util;

namespace FitnessTracker.View
{
    public partial class ManageWorkoutForm : Form
    {
        EventType SelectedEventType = EventType.SAVE;

        public ManageWorkoutForm(EventType eventType, long workoutId)
        {
            InitializeComponent();

            SelectedEventType = eventType;
            btnSaveWorkout.Visible = true;
            btnClearWorkoutInfo.Visible = true;

            if (SelectedEventType == EventType.EDIT && workoutId > 0)
            {
                lblManageVehicleTitle.Text = "Edit Workout Details";
                btnSaveWorkout.Text = "Update";

                //LoadVehicleDataToForm(vehicleId);
            }

            if (SelectedEventType == EventType.VIEW && workoutId > 0)
            {
                lblManageVehicleTitle.Text = "View Workout Details";
                btnSaveWorkout.Visible = false;
                btnClearWorkoutInfo.Visible = false;

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

            if (String.IsNullOrEmpty(name))
            {
                FormsHandler.InfoRequiredErrorMessage("Workout name");
                return;
            }

            if (String.IsNullOrEmpty(type) || type.Equals("NA"))
            {
                FormsHandler.InfoRequiredErrorMessage("Workout type");
                return;
            }

            if (date == null)
            {
                FormsHandler.InfoRequiredErrorMessage("Workout date");
                return;
            }

            if (SelectedEventType == EventType.SAVE)
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
            else if (SelectedEventType == EventType.EDIT)
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
