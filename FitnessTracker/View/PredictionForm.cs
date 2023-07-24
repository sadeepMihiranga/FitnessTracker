using FitnessTracker.Controller;
using FitnessTracker.Model;

namespace FitnessTracker.View
{
    public partial class PredictionForm : Form
    {
        private UserModel LoggedUser;
        private PredictionController predictionController;

        public PredictionForm(UserModel user)
        {
            this.LoggedUser = user;
            InitializeComponent();
            WaitingForm waiting = new();

            try
            {
                waiting.Show();

                lblPredictedWeigth.Text = "-";
                lblPredictedHealthStatus.Text = "-";

                predictionController = new(this.LoggedUser);
            }
            catch (Exception ex)
            { }
            finally
            { waiting.Close(); }         
        }

        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            MainMenuForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            DateTime futureDate = dtpFutureDate.Value;

            double[] weigthResponse = predictionController.PredictWeight(futureDate);

            if (weigthResponse[0] == 0)
                return;

            lblPredictedWeigth.Text = weigthResponse[0].ToString() + " KG";

            string predictedHealthStatus = predictionController.PredictHealStatus(futureDate, weigthResponse);

            lblPredictedHealthStatus.Text = predictedHealthStatus;
        }
    }
}
