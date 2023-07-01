using FitnessTracker.Controller;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using System.ComponentModel;

namespace FitnessTracker.View.CustomUserControl
{
    public partial class WorkoutCardUserControl : UserControl
    {
        private UserModel LoggedUser;
        private Panel PanelMain;
        private long WorkoutId;

        public WorkoutCardUserControl(UserModel user, long workoutId, Panel panelMain)
        {
            this.LoggedUser = user;
            this.PanelMain = panelMain;
            this.WorkoutId = workoutId;

            InitializeComponent();
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
            FormsHandler.LoadForm(new ManageWorkoutForm(EventType.EDIT, WorkoutId, LoggedUser), PanelMain);
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove this Workout ?", "Message",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WorkoutController workoutController = new();
                workoutController.RemoveWorkout(WorkoutId, LoggedUser.Id);

                FormsHandler.LoadForm(new WorkoutForm(LoggedUser, PanelMain), PanelMain);
            }
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageWorkoutForm(EventType.VIEW, WorkoutId, LoggedUser), PanelMain);
        }
    }
}
