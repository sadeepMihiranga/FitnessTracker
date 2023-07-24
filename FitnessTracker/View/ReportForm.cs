using FitnessTracker.Controller;
using FitnessTracker.Model;

namespace FitnessTracker.View
{
    public partial class ReportForm : Form
    {
        UserModel LoggedUser = null;

        public ReportForm(UserModel user)
        {
            InitializeComponent();
            this.LoggedUser = user;
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

        private void btnDownloadWorkoutReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpWorkoutFrom.Value;
            DateTime to = dtpWorkoutTo.Value;
            WaitingForm waiting = new();

            try
            {
                waiting.Show();
                ReportController.GenerateWorkoutReport(LoggedUser.Id, from, to);
            }
            catch (Exception ex)
            { }
            finally
            { waiting.Close(); }                    
        }

        private void btnDownloadCheatMealReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpCheatMealFrom.Value;
            DateTime to = dtpCheatMealTo.Value;
            WaitingForm waiting = new();

            try
            {             
                waiting.Show();
                ReportController.GenerateCheatMealReport(LoggedUser.Id, from, to);
            }
            catch (Exception ex)
            { }
            finally
            { waiting.Close(); }  
        }
    }
}
