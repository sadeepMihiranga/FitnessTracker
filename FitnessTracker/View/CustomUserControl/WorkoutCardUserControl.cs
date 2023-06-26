using System.ComponentModel;

namespace FitnessTracker.View.CustomUserControl
{
    public partial class WorkoutCardUserControl : UserControl
    {
        long LogedUserId;

        public WorkoutCardUserControl(long logedUserId, long workoutId)
        {
            InitializeComponent();
            this.LogedUserId = logedUserId;

            txtHiddenVehicleId.Text = Convert.ToString(workoutId);
            txtHiddenVehicleId.Visible = false;
        }

        private string _title;
        private string _weight;
        private string _loggingType;
        private string _addedTime;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblWorkoutType.Text = value; }
        }

        [Category("Custom Props")]
        public string Weigth
        {
            get { return _weight; }
            set { _weight = value; lbleWeigth.Text = value; }
        }

        [Category("Custom Props")]
        public string LoggingType
        {
            get { return _loggingType; }
            set { _loggingType = value; lblPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string AddedTime
        {
            get { return _addedTime; }
            set { _addedTime = value; lblWorkoutDateTime.Text = value; }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; picBoxVehicleImage.Image = value; picBoxVehicleImage.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            /*VehicleForm vehicleForm = new VehicleForm(this.Roles, this.LogedUserId);
            vehicleForm.OpenEditView(Convert.ToInt64(txtHiddenVehicleId.Text));*/
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove this Vehicle ?", "Message",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*Vehicle vehicle = new Vehicle();
                vehicle.RemoveVehicle(Convert.ToInt64(txtHiddenVehicleId.Text));

                VehicleForm vehicleForm = new VehicleForm(this.Roles, this.LogedUserId);*/
                // need to check refresh form after removing a vehicle
            }
        }

        private void pictureBoxOrder_Click(object sender, EventArgs e)
        {
            /*OrderVehicleDialogForm orderCarDialogForm =
                new OrderVehicleDialogForm(this.Roles, Convert.ToInt64(txtHiddenVehicleId.Text), this.LogedUserId, "Order");
            orderCarDialogForm.Show();*/
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            /*OrderVehicleDialogForm orderCarDialogForm =
                new OrderVehicleDialogForm(this.Roles, Convert.ToInt64(txtHiddenVehicleId.Text), this.LogedUserId, "View");
            orderCarDialogForm.Show();*/
        }
    }
}
