using FitnessTracker.Controller;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View.CustomUserControl;
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
    public partial class WorkoutForm : Form
    {
        int currentPage = 0;
        public int pageSize = 7;
        long LoggedUserId;

        public WorkoutForm(long loggedUserId)
        {
            this.LoggedUserId = loggedUserId;

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

        public void OpenEditView(long vehicleId)
        {
            //FormsHandler.LoadForm(new ManageVehicleForm("Edit", vehicleId), panelVehiclesMain);
        }

        public void LoadWorkouts(int page, int size, WorkoutModel workoutSearch)
        {
            if (flowLayoutPanelWorkoutList.Controls.Count > 0)
                flowLayoutPanelWorkoutList.Controls.Clear();

            List<WorkoutCardUserControl> workoutCards = new List<WorkoutCardUserControl>();

            List<WorkoutModel> workoutList = WorkoutRepository.Search(workoutSearch, page, size);

            if (workoutList.Count == 0)
                pictureBoxNext.Visible = false;

            foreach (var workout in workoutList)
            {
                /*string imageUrl = ConfigurationManager.AppSettings.Get("ImageSavedLocation") + @"\no-image-96.png";
                Image vehicleImage = null;

                vehicleImage = Image.FromFile(imageUrl);

                try
                {
                    if (!String.IsNullOrEmpty(vehicle.ImageUrl))
                        vehicleImage = Image.FromFile(vehicle.ImageUrl);
                }
                catch (Exception ex) { }*/

                workoutCards.Add(new WorkoutCardUserControl(this.LoggedUserId, workout.Id)
                {
                    Title = workout.Type.Name,
                    Weigth = workout.Weight + " KG",
                    LoggingType = workout.IsRecurring == true ? "Recurring" : "One-Off",
                    AddedTime = workout.Date.ToString()
                    //Image = vehicleImage
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

        private void pictureBoxVehicleFilter_Click(object sender, EventArgs e)
        {
            /*string vehicleCondition = (string)cmbVehicleConditionSearch.SelectedValue;
            string vehicleModel = (string)cmbVehicleModelSearch.SelectedValue;
            string yom = txtYomSearch.Text;

            if (String.IsNullOrEmpty(vehicleModel) || vehicleModel.Equals("NA"))
                vehicleModel = null;

            if (String.IsNullOrEmpty(vehicleCondition) || vehicleCondition.Equals("NA"))
                vehicleCondition = null;

            if (String.IsNullOrEmpty(yom))
                yom = null;

            LoadVehicles(0, pageSize, new Vehicle(vehicleModel, yom, vehicleCondition));*/
        }
        private void pictureBoxVehicleClearFilter_Click(object sender, EventArgs e)
        {
            /*cmbVehicleConditionSearch.SelectedValue = "NA";
            cmbVehicleModelSearch.SelectedValue = "NA";
            txtYomSearch.Text = "";

            LoadVehicles(0, pageSize, new Vehicle());*/
        }

        private void txtYomSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new LogWorkoutForm("Add", 0), panelWorkoutMain);
        }
    }
}
