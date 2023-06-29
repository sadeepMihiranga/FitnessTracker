using FitnessTracker.Controller;
using FitnessTracker.Enum;
using System.ComponentModel;

namespace FitnessTracker.View.CustomUserControl
{
    public partial class WorkoutCardUserControl : UserControl
    {
        private long LoggedUserId;
        private Panel PanelMain;
        private long WorkoutId;

        public WorkoutCardUserControl(long logedUserId, long workoutId, Panel panelMain)
        {
            this.LoggedUserId = logedUserId;
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
            FormsHandler.LoadForm(new ManageWorkoutForm(EventType.EDIT, WorkoutId), PanelMain);
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove this Workout ?", "Message",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WorkoutController workoutController = new();
                workoutController.RemoveWorkout(WorkoutId);

                FormsHandler.LoadForm(new WorkoutForm(this.LoggedUserId, PanelMain), PanelMain);
            }
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageWorkoutForm(EventType.VIEW, WorkoutId), PanelMain);
        }
    }
}
