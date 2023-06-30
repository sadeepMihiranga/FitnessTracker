namespace FitnessTracker.View
{
    public partial class MainMenuForm : Form
    {
        long LoggedUserId;

        public MainMenuForm(long loggedUserId)
        {
            this.LoggedUserId = loggedUserId;
            InitializeComponent();
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

        private void btnNavWorkout_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new WorkoutForm(this.LoggedUserId, panelMain), panelMain);
        }

        private void btnNavCheatMeals_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new CheatMealForm(this.LoggedUserId, panelMain), panelMain);
        }
    }
}
