﻿using FitnessTracker.Controller;
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
        UserModel LoggedUser = null;
        private Panel panelMain;

        public CheatMealForm(UserModel user, Panel panelMain)
        {
            this.LoggedUser = user;
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

            cheatMealSearch.User = LoggedUser;
            List<CheatMealModel> cheatMealList = CheatMealRepository.Search(cheatMealSearch, page, size);

            if (cheatMealList.Count == 0)
                pictureBoxNext.Visible = false;

            foreach (var cheatMeal in cheatMealList)
            {
                string imageUrl = ConfigurationManager.AppSettings.Get("MealSatisfactionImages") + @"\" + cheatMeal.CheatMealSatisfcation.ToString().ToLower() + ".png";
                Image mealSatisfactionImage = Image.FromFile(imageUrl);

                cheatMealCards.Add(new CheatMealUserControl(LoggedUser, cheatMeal.Id, panelMain)
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
            currentPage++;
            pictureBoxBack.Visible = true;

            if (currentPage < 0)
            {
                pictureBoxNext.Visible = false;
                return;
            }
            else
                pictureBoxNext.Visible = true;

            LoadCheatMeals(currentPage, pageSize, new CheatMealModel());
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

            LoadCheatMeals(currentPage, pageSize, new CheatMealModel());
        }

        private void txtYomSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FormsHandler.AllowOnlyNumber(e);
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageCheatMealForm(LoggedUser, EventType.SAVE, 0), panelCheatMealMain);
        }

        private void picbWorkoutFilter_Click(object sender, EventArgs e)
        {
            string mealType = (string)cmbMealTypeSearch.SelectedValue;

            CheatMealModel cheatMealSearch = new();
            cheatMealSearch.User = LoggedUser;

            CheatMealTypeModel cheatMealType = null;

            if (mealType != null && !mealType.Equals("NA"))
            {
                CheatMealTypeController cheatMealTypeController = new();

                cheatMealType = cheatMealTypeController.GetById(long.Parse(mealType));

                if (cheatMealType == null)
                {
                    FormsHandler.InvalidValueMessage("Cheat meal type is invalid.");
                    return;
                }

                cheatMealSearch.CheatMealType = cheatMealType;
            }

            LoadCheatMeals(0, pageSize, cheatMealSearch);
        }

        private void picbWorkoutClearFilter_Click(object sender, EventArgs e)
        {
            LoadCheatMeals(0, pageSize, new CheatMealModel());
        }
    }
}
