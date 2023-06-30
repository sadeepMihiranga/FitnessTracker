using FitnessTracker.Controller;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using FitnessTracker.View.Util;

namespace FitnessTracker.View
{
    public partial class ManageWorkoutForm : Form
    {
        EventType SelectedEventType = EventType.SAVE;
        long WorkoutId = 0;

        public ManageWorkoutForm(EventType eventType, long workoutId)
        {
            InitializeComponent();

            InitializeForm();      

            SelectedEventType = eventType;
            btnSaveWorkout.Visible = true;
            btnClearWorkoutInfo.Visible = true;
            WorkoutId = workoutId;

            if (SelectedEventType == EventType.EDIT && workoutId > 0)
            {
                lblManageVehicleTitle.Text = "Edit Workout Details";
                btnSaveWorkout.Text = "Update";

                LoadWorkoutInformation(workoutId, false);
            }

            if (SelectedEventType == EventType.VIEW && workoutId > 0)
            {
                lblManageVehicleTitle.Text = "View Workout Details";
                btnSaveWorkout.Visible = false;
                btnClearWorkoutInfo.Visible = false;

                LoadWorkoutInformation(workoutId, true);
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
            string recurringType = (string)cmbRecursionType.SelectedValue;
            string recursionDate = (string)cmbRecursionDate.SelectedValue;

            WorkoutController workoutController = new();
            WorkoutTypeController workoutTypeController = new();

            WorkoutTypeModel workoutType = workoutTypeController.GetById(long.Parse(type));

            if (workoutType == null)
            {
                FormsHandler.InvalidValueMessage("Workout type is invalid.");
                return;
            }

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

            if (isRecurring)
            {
                if (recurringType == null || recurringType.Equals(""))
                {
                    FormsHandler.InfoRequiredErrorMessage("Recursion Type");
                    return;
                }
            }
    
            if (SelectedEventType == EventType.SAVE)
            {
                try
                {
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
                        IsRecurring = isRecurring,
                        RecurringType = recurringType,
                        Comment = comment,
                        RecurrsionDate = recursionDate
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
                FormsHandler.OperationSuccessMessage(WorkoutId.ToString());

                try
                {
                    WorkoutModel workout = new()
                    {
                        Id = WorkoutId,
                        Name = name,
                        Type = workoutType,
                        Date = date,
                        StartTime = start,
                        EndTime = end,
                        Weight = int.Parse(weigth),
                        Reps = int.Parse(reps),
                        Sets = int.Parse(sets),
                        IsRecurring = isRecurring,
                        RecurringType = recurringType,
                        Comment = comment,
                        RecurrsionDate = recursionDate
                    };

                    workoutController.UpdateWorkout(workout);

                    FormsHandler.OperationSuccessMessage("Workout Updated.");
                }
                catch (Exception ex)
                {
                    FormsHandler.OperationFailedErrorMessage(ex.Message);
                }
                finally
                {

                }
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

        private void InitializeForm()
        {
            dtpWorkoutDate.Format = DateTimePickerFormat.Custom;
            dtpWorkoutDate.CustomFormat = "ddd dd MMM yyyy"; // display the date as "Mon 27 Feb 2023". 

            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;

            WorkoutTypeController workoutTypeController = new();
            DropDownListPopulator.PopulateCombobox(workoutTypeController.ToComboboxList(), cmbWorkoutType);

            panelLineRecursionType.Visible = false;
            cmbRecursionType.Visible = false;
            lblRecursionType.Visible = false;

            panelRecursionDate.Visible = false;
            cmbRecursionDate.Visible = false;
            lblRecursionDate.Visible = false;
        }

        private void LoadWorkoutInformation(long workoutId, bool isView)
        {
            WorkoutController workoutController = new();
            WorkoutModel workout = workoutController.GetWorkoutById(workoutId);

            cmbWorkoutType.SelectedValue = workout.Type.Id.ToString();
            txtSets.Text = workout.Sets == 0 ? "" : workout.Sets.ToString();
            txtReps.Text = workout.Reps == 0 ? "" : workout.Reps.ToString();
            txtComment.Text = workout.Comment == null ? "" : workout.Comment;
            txtWeigth.Text = workout.Weight == 0 ? "" : workout.Weight.ToString();
            txtWorkoutName.Text = workout.Name == null ? "" : workout.Name;
            dtpWorkoutDate.Value = workout.Date;
            dtpStartTime.Value = workout.StartTime;
            dtpEndTime.Value = workout.EndTime;

            if (workout.IsRecurring) 
            {
                chbIsRecurring.Checked = true;

                panelLineRecursionType.Visible = true;
                cmbRecursionType.Visible = true;
                lblRecursionType.Visible = true;

                PopulateRecursionTypes();

                cmbRecursionType.SelectedIndex = Int32.Parse(workout.RecurringType);

                if (Int32.Parse(workout.RecurringType) == 2)
                {
                    panelRecursionDate.Visible = true;
                    cmbRecursionDate.Visible = true;
                    lblRecursionDate.Visible = true;

                    cmbRecursionDate.SelectedIndex = Int32.Parse(workout.RecurrsionDate);
                }
            }

            if (isView)
            {
                txtSets.ReadOnly = true;
                txtReps.ReadOnly = true;
                txtComment.ReadOnly = true;
                txtWeigth.ReadOnly = true;
                txtWorkoutName.ReadOnly = true;
                cmbWorkoutType.Enabled = false;
                chbIsRecurring.Enabled = false;
                dtpWorkoutDate.Enabled = false;
                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;
                cmbRecursionType.Enabled = false;
                cmbRecursionDate.Enabled = false;
            }
        }

        private void PopulateRecursionTypes()
        {
            RecursionTypeController recursionTypeController = new();
            List<ComboboxModel> recursionTypes = recursionTypeController.ToComboboxList();

            DropDownListPopulator.PopulateCombobox(recursionTypes, cmbRecursionType);
        }

        private void chbIsRecurring_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsRecurring.Checked)
            {
                panelLineRecursionType.Visible = true;
                cmbRecursionType.Visible = true;
                lblRecursionType.Visible = true;

                /*panelRecursionDate.Visible = true;
                cmbRecursionDate.Visible = true;
                lblRecursionDate.Visible = true;*/

                PopulateRecursionTypes();
            }
            else
            {
                panelLineRecursionType.Visible = false;
                cmbRecursionType.Visible = false;
                lblRecursionType.Visible = false;

                panelRecursionDate.Visible = false;
                cmbRecursionDate.Visible = false;
                lblRecursionDate.Visible = false;
            }
        }

        private void cmbRecursionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recursionType = Convert.ToString(cmbRecursionType.SelectedValue);

            if (recursionType.Equals("NA")) 
                return;
               

            if (recursionType.Equals("2")) // weekly
            {
                cmbRecursionDate.Enabled = true;

                List<ComboboxModel> recursionDates = new();

                recursionDates.Add(new ComboboxModel(1, "Monday"));
                recursionDates.Add(new ComboboxModel(2, "Tuesday"));
                recursionDates.Add(new ComboboxModel(3, "Wednesday"));
                recursionDates.Add(new ComboboxModel(4, "Thursday"));
                recursionDates.Add(new ComboboxModel(5, "Friday"));
                recursionDates.Add(new ComboboxModel(6, "Saturday"));
                recursionDates.Add(new ComboboxModel(7, "Sunday"));

                DropDownListPopulator.PopulateCombobox(recursionDates, cmbRecursionDate);

                panelRecursionDate.Visible = true;
                cmbRecursionDate.Visible = true;
                lblRecursionDate.Visible = true;
            }
            else
            {
                cmbRecursionDate.DataSource = null;
                cmbRecursionDate.Items.Clear();
                cmbRecursionDate.Enabled = false;
            }
        }
    }
}
