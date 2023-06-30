using FitnessTracker.Controller;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View.CustomUserControl;
using FitnessTracker.View.Util;
using System.Configuration;

namespace FitnessTracker.View
{
    public partial class CheatMealForm : Form
    {
        int currentPage = 0;
        public int pageSize = 7;
        long LoggedUserId;
        private Panel panelMain;

        public CheatMealForm(long loggedUserId, Panel panelMain)
        {
            this.LoggedUserId = loggedUserId;
            this.panelMain = panelMain;

            InitializeComponent();

            CheatMealTypeController cheatMealTypeController = new();
            DropDownListPopulator.PopulateCombobox(cheatMealTypeController.ToComboboxList(), cmbMealTypeSearch);

            CheatMealReasonController cheatMealReasonController = new();
            DropDownListPopulator.PopulateCombobox(cheatMealReasonController.ToComboboxList(), cmbReasonTakenSearch);

            List<ComboboxModel> comboboxModels = new List<ComboboxModel>();

            foreach (int mealPortionSizeId in Enum.GetValues(typeof(MealPortionSizeEnum)))
            {
                var mealPortionSizeName = (MealPortionSizeEnum)mealPortionSizeId;
                comboboxModels.Add(new ComboboxModel(mealPortionSizeId, mealPortionSizeName.ToString()));
            }       
            DropDownListPopulator.PopulateCombobox(comboboxModels, cmbPortionSize);

            LoadCheatMeals(0, pageSize, new CheatMealModel());
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

        public void LoadCheatMeals(int page, int size, CheatMealModel cheatMealSearch)
        {
            if (flowLayoutPanelMealList.Controls.Count > 0)
                flowLayoutPanelMealList.Controls.Clear();

            List<CheatMealUserControl> cheatMealCards = new List<CheatMealUserControl>();

            List<CheatMealModel> cheatMealList = CheatMealRepository.Search(cheatMealSearch, page, size);

            if (cheatMealList.Count == 0)
                pictureBoxNext.Visible = false;

            foreach (var cheatMeal in cheatMealList)
            {
                string imageUrl = ConfigurationManager.AppSettings.Get("MealSatisfactionImages") + @"\" + cheatMeal.CheatMealSatisfcation.ToString().ToLower() + ".png";
                Image mealSatisfactionImage = Image.FromFile(imageUrl);

                cheatMealCards.Add(new CheatMealUserControl(this.LoggedUserId, cheatMeal.Id, panelMain)
                {
                    Title = cheatMeal.CheatMealType.Name,
                    MealName = cheatMeal.Name,
                    PortionSize = cheatMeal.MealPortionSize + " Portion",
                    AddedTime = cheatMeal.DateTimeTaken.ToString(),
                    Image = mealSatisfactionImage
                });
            }

            foreach (CheatMealUserControl cheatMeal in cheatMealCards)
            {
                flowLayoutPanelMealList.Controls.Add(cheatMeal);
            }
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            /*currentPage++;
            pictureBoxBack.Visible = true;

            if (currentPage < 0)
            {
                pictureBoxNext.Visible = false;
                return;
            }
            else
                pictureBoxNext.Visible = true;

            LoadWorkouts(currentPage, pageSize, new WorkoutModel());*/
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            /*currentPage--;
            pictureBoxNext.Visible = true;

            if (currentPage < 0)
            {
                pictureBoxBack.Visible = false;
                return;
            }
            else
                pictureBoxBack.Visible = true;

            LoadWorkouts(currentPage, pageSize, new WorkoutModel());*/
        }

        private void txtYomSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FormsHandler.AllowOnlyNumber(e);
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            //FormsHandler.LoadForm(new ManageWorkoutForm(EventType.SAVE, 0), panelWorkoutMain);
        }

        private void picbWorkoutFilter_Click(object sender, EventArgs e)
        {
           /* string workoutType = (string)cmbWorkoutTypeSearch.SelectedValue;

            WorkoutTypeModel workoutTypeModel = null;
            WorkoutModel workoutSearch = new();

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

            LoadWorkouts(0, pageSize, workoutSearch);*/
        }

        private void picbWorkoutClearFilter_Click(object sender, EventArgs e)
        {
            //LoadWorkouts(0, pageSize, new WorkoutModel());
        }
    }
}
