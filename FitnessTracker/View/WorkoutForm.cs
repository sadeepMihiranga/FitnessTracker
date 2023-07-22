using FitnessTracker.Controller;
using FitnessTracker.DTOs;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View.CustomUserControl;
using FitnessTracker.View.Util;
using System.Configuration;

namespace FitnessTracker.View
{
    public partial class WorkoutForm : Form
    {
        int currentPage = 0;
        public int pageSize = 7;
        UserModel LoggedUser = null;
        private Panel panelMain;

        internal EventType WorkoutType { get; private set; }

        public WorkoutForm(UserModel user, Panel panelMain)
        {
            this.LoggedUser = user;
            this.panelMain = panelMain;

            InitializeComponent();

            //txtYomSearch.MaxLength = 4;

            WorkoutTypeController workoutTypeController = new();
            DropDownListPopulator.PopulateCombobox(workoutTypeController.ToComboboxList(), cmbWorkoutTypeSearch);

            LoadWorkouts(0, pageSize, new WorkoutModel());
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            MainMenuForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        public void LoadWorkouts(int page, int size, WorkoutModel workoutSearch)
        {
            if (flowLayoutPanelWorkoutList.Controls.Count > 0)
                flowLayoutPanelWorkoutList.Controls.Clear();

            List<WorkoutCardUserControl> workoutCards = new List<WorkoutCardUserControl>();
            List<WorkoutModel> workoutList = new List<WorkoutModel>();
            WorkoutController workoutController = new();

            workoutSearch.User = LoggedUser;

            try
            {
                APIResponseWrapper<List<WorkoutModel>> response = workoutController.Search(workoutSearch, page, size);

                if (response.Success == true)
                {
                    if (response.SuccessReponse != null)
                    {
                        workoutList = response.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching workouts");
                        return;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(response.ErrorResponse.Title);
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while fetching workouts");
                return;
            }
            finally
            {

            }

            if (workoutList.Count == 0)
                pictureBoxNext.Visible = false;

            foreach (var workout in workoutList)
            {
                string imageUrl = ConfigurationManager.AppSettings.Get("WorkoutTypeImages") + @"\"+ workout.Type.Name.ToLower() + ".png";
                Image workoutTypeImage = Image.FromFile(imageUrl);

                workoutCards.Add(new WorkoutCardUserControl(LoggedUser, workout.Id, panelMain)
                {
                    Title = workout.Type.Name,
                    Weigth = workout.Weight + " KG",
                    LoggingType = workout.IsRecurring == true ? "Recurring" : "One-Off",
                    AddedTime = workout.Date.ToString(),
                    Image = workoutTypeImage
                });
            }

            foreach (WorkoutCardUserControl workoutCard in workoutCards)
            {
                flowLayoutPanelWorkoutList.Controls.Add(workoutCard);
            }
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            pictureBoxBack.Visible = true;

            if (currentPage < 0)
            {
                pictureBoxNext.Visible = false;
                return;
            }
            else
                pictureBoxNext.Visible = true;

            LoadWorkouts(currentPage, pageSize, new WorkoutModel());
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            currentPage--;
            pictureBoxNext.Visible = true;

            if (currentPage < 0)
            {
                pictureBoxBack.Visible = false;
                return;
            }
            else
                pictureBoxBack.Visible = true;

            LoadWorkouts(currentPage, pageSize, new WorkoutModel());
        }

        private void txtYomSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageWorkoutForm(EventType.SAVE, 0, LoggedUser), panelWorkoutMain);
        }

        private void picbWorkoutFilter_Click(object sender, EventArgs e)
        {
            string workoutType = (string)cmbWorkoutTypeSearch.SelectedValue;

            WorkoutTypeModel workoutTypeModel = null;
            WorkoutModel workoutSearch = new();
            workoutSearch.User = LoggedUser;

            if (workoutType != null && !workoutType.Equals("NA"))
            {
                WorkoutTypeController workoutTypeController = new();

                workoutTypeModel = workoutTypeController.GetById(long.Parse(workoutType));

                if (workoutTypeModel == null)
                {
                    FormsHandler.InvalidValueMessage("Workout type is invalid.");
                    return;
                }

                workoutSearch.Type = workoutTypeModel;
            }

            LoadWorkouts(0, pageSize, workoutSearch);
        }

        private void picbWorkoutClearFilter_Click(object sender, EventArgs e)
        {
            LoadWorkouts(0, pageSize, new WorkoutModel());
        }
    }
}
