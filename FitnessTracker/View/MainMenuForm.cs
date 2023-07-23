using FitnessTracker.Model;

namespace FitnessTracker.View
{
    public partial class MainMenuForm : Form
    {
        UserModel LoggedUser;

        public MainMenuForm(UserModel user)
        {
            this.LoggedUser = user;
            InitializeComponent();
            FormsHandler.LoadForm(new WorkoutForm(LoggedUser, panelMain), panelMain);
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
            WaitingForm waiting = new();
            waiting.Show();

            FormsHandler.LoadForm(new WorkoutForm(LoggedUser, panelMain), panelMain);

            waiting.Close();
        }

        private void btnNavCheatMeals_Click(object sender, EventArgs e)
        {
            WaitingForm waiting = new();
            waiting.Show();

            FormsHandler.LoadForm(new CheatMealForm(LoggedUser, panelMain), panelMain);

            waiting.Close();
        }

        private void btnNavReport_Click(object sender, EventArgs e)
        {
            WaitingForm waiting = new();
            waiting.Show();

            FormsHandler.LoadForm(new ReportForm(LoggedUser), panelMain);

            waiting.Close();
        }

        private void btnNavPredictions_Click(object sender, EventArgs e)
        {
            WaitingForm waiting = new();
            waiting.Show();

            FormsHandler.LoadForm(new PredictionForm(LoggedUser), panelMain);

            waiting.Close();
        }
    }
}
