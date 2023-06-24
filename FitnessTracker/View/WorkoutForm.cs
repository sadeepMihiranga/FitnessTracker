using FitnessTracker.Controller;
using FitnessTracker.Repository;
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
        int currentPage = 1;
        public int pageSize = 7;
        long LoggedUserId;

        public WorkoutForm(long loggedUserId)
        {
            this.LoggedUserId = loggedUserId;

            InitializeComponent();

            //txtYomSearch.MaxLength = 4;

            WorkoutTypeController workoutTypeController = new();
            DropDownListPopulator.PopulateCombobox(workoutTypeController.ToComboboxList(), cmbWorkoutTypeSearch);

            //LoadVehicles(0, pageSize, new Vehicle());
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

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //FormsHandler.LoadForm(new ManageVehicleForm("Add", 0), panelVehiclesMain);
        }

        /*public void LoadVehicles(int page, int size, Vehicle vehicleSearch)
        {
            if (flowLayoutPanelVehicelList.Controls.Count > 0)
                flowLayoutPanelVehicelList.Controls.Clear();

            List<VehicleCardUserControl> vehicleCards = new List<VehicleCardUserControl>();
            Vehicle vehicleObj = new Vehicle();

            List<Vehicle> vehicleList = vehicleObj.GetAllVehicleForCards(page, size, vehicleSearch);

            if (vehicleList.Count == 0)
                pictureBoxNext.Visible = false;

            foreach (var vehicle in vehicleList)
            {
                string timeLabel = " hours";
                double time = 0;

                double hoursBack = Math.Round((DateTime.Now - vehicle.CreatedDateTime).TotalHours);

                if (hoursBack > 23)
                {
                    timeLabel = " days";
                    time = Math.Round(hoursBack / 24);
                }
                else
                    time = hoursBack;

                string imageUrl = ConfigurationManager.AppSettings.Get("ImageSavedLocation") + @"\no-image-96.png";
                Image vehicleImage = null;

                vehicleImage = Image.FromFile(imageUrl);

                try
                {
                    if (!String.IsNullOrEmpty(vehicle.ImageUrl))
                        vehicleImage = Image.FromFile(vehicle.ImageUrl);
                }
                catch (Exception ex) { }

                vehicleCards.Add(new VehicleCardUserControl(this.Roles, vehicle.VehicleId, this.LoggedUserId)
                {
                    Title = vehicle.Make + " " + vehicle.Model + " " + vehicle.YearOfManufacture,
                    Mileage = vehicle.Mileage + " KM",
                    Price = "Rs " + vehicle.Price,
                    AddedTime = time + timeLabel,
                    Image = vehicleImage
                });
            }

            foreach (VehicleCardUserControl vehicleCard in vehicleCards)
            {
                flowLayoutPanelVehicelList.Controls.Add(vehicleCard);
            }
        }*/

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

            LoadVehicles(currentPage * pageSize, pageSize, new Vehicle());*/
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

            LoadVehicles(currentPage * pageSize, pageSize, new Vehicle());*/
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
    }
}
