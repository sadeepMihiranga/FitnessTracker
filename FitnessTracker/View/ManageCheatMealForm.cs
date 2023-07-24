using FitnessTracker.Controller;
using FitnessTracker.DTOs;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using FitnessTracker.View.Util;

namespace FitnessTracker.View
{
    public partial class ManageCheatMealForm : Form
    {
        EventType SelectedEventType = EventType.SAVE;
        long CheatMealId = 0;
        UserModel LoggedUser = null;

        public ManageCheatMealForm(UserModel user, EventType eventType, long cheatMealId)
        {
            InitializeComponent();
            WaitingForm waiting = new();

            try
            {
                waiting.Show();

                InitializeForm();

                SelectedEventType = eventType;
                btnSaveCheatMeal.Visible = true;
                btnClearCheatMealInfo.Visible = true;
                CheatMealId = cheatMealId;
                this.LoggedUser = user;

                if (SelectedEventType == EventType.EDIT && cheatMealId > 0)
                {
                    lblManageCheatMealTitle.Text = "Edit Cheat Meal Details";
                    btnSaveCheatMeal.Text = "Update";

                    LoadCheatMealInformation(cheatMealId, false);
                }

                if (SelectedEventType == EventType.VIEW && cheatMealId > 0)
                {
                    lblManageCheatMealTitle.Text = "View Cheat Meal Details";
                    btnSaveCheatMeal.Visible = false;
                    btnClearCheatMealInfo.Visible = false;

                    LoadCheatMealInformation(cheatMealId, true);
                }
            }
            catch (Exception ex)
            { }
            finally
            { waiting.Close(); }       
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

        private void btnSaveCheatMeal_Click(object sender, EventArgs e)
        {
            string name = txtMealName.Text;
            string mealType = (string)cmbMealType.SelectedValue;
            DateTime date = dtpMealTakeDate.Value;
            string portionSize = (string)cmbPortionSize.SelectedValue;
            string reasonTaken = (string)cmbReasonTaken.SelectedValue;
            string calories = txtCalories.Text;
            string mealSatisfaction = (string)cmbMealSatisfaction.SelectedValue;
            string comment = txtComment.Text;           

            if (String.IsNullOrEmpty(mealType) || mealType.Equals("NA"))
            {
                FormsHandler.InfoRequiredErrorMessage("Cheat Meal type");
                return;
            }

            if (String.IsNullOrEmpty(name))
            {
                FormsHandler.InfoRequiredErrorMessage("Cheat Meal name");
                return;
            }

            if (date == null)
            {
                FormsHandler.InfoRequiredErrorMessage("Meal Taken date");
                return;
            }

            CheatMealTypeController cheatMealTypeController = new();
            CheatMealTypeModel mealTypeModel = cheatMealTypeController.GetById(long.Parse(mealType));

            if (mealTypeModel == null)
            {
                FormsHandler.InvalidValueMessage("Cheat Meal type is invalid.");
                return;
            }

            CheatMealReasonModel cheatMealReason = null;

            if (!String.IsNullOrEmpty(reasonTaken) || !reasonTaken.Equals("NA"))
            {
                CheatMealReasonController cheatMealReasonController = new();
                cheatMealReason = cheatMealReasonController.GetById(long.Parse(reasonTaken));
            }

            MealPortionSizeEnum mealPortionSize = MealPortionSizeEnum.NA;

            if (!String.IsNullOrEmpty(portionSize) || !portionSize.Equals("NA"))
                mealPortionSize = (MealPortionSizeEnum)Int32.Parse(portionSize);

            CheatMealSatisfcationEnum cheatMealSatisfcation = CheatMealSatisfcationEnum.NA;

            if (!String.IsNullOrEmpty(mealSatisfaction) || !mealSatisfaction.Equals("NA"))
                cheatMealSatisfcation = (CheatMealSatisfcationEnum)Int32.Parse(mealSatisfaction);

            CheatMealController cheatMealController = new();
            WaitingForm waiting = new();

            if (SelectedEventType == EventType.SAVE)
            {
                waiting.Show();
                try
                {
                    CheatMealModel cheatMeal = new()
                    {
                        Name = name,
                        MealType = mealTypeModel,
                        DateTimeTaken = date,
                        CaloriesTaken = int.Parse(calories),
                        MealReason = cheatMealReason,
                        CheatMealSatisfcation = cheatMealSatisfcation,
                        MealPortionSize = mealPortionSize,
                        Comment = comment,
                        User = LoggedUser
                    };

                    APIResponseWrapper<CheatMealModel> responseWrapper = cheatMealController.LogCheatMeal(cheatMeal);

                    if (responseWrapper.Success)
                    {
                        FormsHandler.OperationSuccessMessage("Cheat Meal logged.");
                        return;
                    }
                    else
                    {
                        FormsHandler.OperationSuccessMessage(responseWrapper.ErrorResponse.Title);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    FormsHandler.OperationFailedErrorMessage(ex.Message);
                }
                finally
                { waiting.Close(); }
            }
            else if (SelectedEventType == EventType.EDIT)
            {
                waiting.Show();
                try
                {
                    CheatMealModel cheatMeal = new()
                    {
                        Id = CheatMealId,
                        Name = name,
                        MealType = mealTypeModel,
                        DateTimeTaken = date,
                        CaloriesTaken = int.Parse(calories),
                        MealReason = cheatMealReason,
                        CheatMealSatisfcation = cheatMealSatisfcation,
                        MealPortionSize = mealPortionSize,
                        Comment = comment,
                    };

                    //cheatMealController.UpdateWorkout(cheatMeal);
                    FormsHandler.OperationSuccessMessage("Cheat Meal Updated.");
                }
                catch (Exception ex)
                {
                    FormsHandler.OperationFailedErrorMessage(ex.Message);
                }
                finally
                { waiting.Close(); }
            }
        }

        private void btnClearCheatMealInfo_Click(object sender, EventArgs e)
        {
            cmbMealType.SelectedValue = "NA";
            cmbMealSatisfaction.SelectedValue = "NA";
            cmbPortionSize.SelectedValue = "NA";
            cmbReasonTaken.SelectedValue = "NA";
            txtComment.Text = "";
            txtCalories.Text = "";
            txtMealName.Text = "";
        }

        private void InitializeForm()
        {
            dtpMealTakeDate.Format = DateTimePickerFormat.Custom;
            dtpMealTakeDate.CustomFormat = "ddd dd MMM yyyy"; // display the date as "Mon 27 Feb 2023". 

            CheatMealTypeController cheatMealTypeController = new();
            DropDownListPopulator.PopulateCombobox(cheatMealTypeController.ToComboboxList(), cmbMealType);

            CheatMealReasonController cheatMealReasonController = new();
            DropDownListPopulator.PopulateCombobox(cheatMealReasonController.ToComboboxList(), cmbReasonTaken);

            List<ComboboxModel> mealPortionChoices = new List<ComboboxModel>();

            foreach (int mealPortionSizeId in Enum.GetValues(typeof(MealPortionSizeEnum)))
            {
                if (mealPortionSizeId != 0)
                {
                    var mealPortionSizeName = (MealPortionSizeEnum)mealPortionSizeId;
                    mealPortionChoices.Add(new ComboboxModel(mealPortionSizeId, mealPortionSizeName.ToString()));
                }
            }
            DropDownListPopulator.PopulateCombobox(mealPortionChoices, cmbPortionSize);

            List<ComboboxModel> mealSatisfactionChoices = new List<ComboboxModel>();

            foreach (int meaSatisfcationId in Enum.GetValues(typeof(CheatMealSatisfcationEnum)))
            {
                if (meaSatisfcationId != 0)
                {
                    var meaSatisfcationName = (CheatMealSatisfcationEnum)meaSatisfcationId;
                    mealSatisfactionChoices.Add(new ComboboxModel(meaSatisfcationId, meaSatisfcationName.ToString()));
                }
            }
            DropDownListPopulator.PopulateCombobox(mealSatisfactionChoices, cmbMealSatisfaction);
        }

        private void LoadCheatMealInformation(long cheatMealId, bool isView)
        {
            CheatMealController cheatMealController = new();
            CheatMealModel cheatMeal = null;

            try
            {
                APIResponseWrapper<CheatMealModel> response = cheatMealController.GetCheatMealById(cheatMealId, LoggedUser.Id);

                if (response.Success == true)
                {
                    if (response.SuccessReponse != null)
                    {
                        cheatMeal = response.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching cheat meal");
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
                FormsHandler.OperationFailedErrorMessage("Error while fetching cheat meal");
                return;
            }
            finally
            {

            }

            int mealPortinSizeId = (int)cheatMeal.MealPortionSize;
            int mealSatisfcationId = (int)cheatMeal.CheatMealSatisfcation;

            txtMealName.Text = cheatMeal.Name;
            cmbMealType.SelectedValue = cheatMeal.MealType.Id.ToString();
            dtpMealTakeDate.Value = cheatMeal.DateTimeTaken;
            cmbReasonTaken.SelectedValue = cheatMeal.MealReason.Id.ToString();
            txtCalories.Text = cheatMeal.CaloriesTaken == 0 ? "" : cheatMeal.CaloriesTaken.ToString();
            txtComment.Text = cheatMeal.Comment;

            if(mealPortinSizeId != 0)
                cmbPortionSize.SelectedValue = mealPortinSizeId.ToString();

            if (mealSatisfcationId != 0)
                cmbMealSatisfaction.SelectedValue = mealSatisfcationId.ToString();

            if (isView)
            {
                txtMealName.ReadOnly = true;
                txtCalories.ReadOnly = true;
                txtComment.ReadOnly = true;
                cmbMealType.Enabled = false;
                cmbPortionSize.Enabled = false;
                cmbReasonTaken.Enabled = false;
                dtpMealTakeDate.Enabled = false;
                cmbMealSatisfaction.Enabled = false;
            }
        }

        private void txtCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }
    }
}
