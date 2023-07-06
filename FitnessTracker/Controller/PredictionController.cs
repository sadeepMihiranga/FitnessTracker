using FitnessTracker.Model;
using FitnessTracker.View;
using System.Diagnostics;

namespace FitnessTracker.Controller
{
    public class PredictionController
    {
        List<WorkoutModel> Workouts;
        List<CheatMealModel> CheatMeals;
        WorkoutModel LatestRecodedWorkout;
        WorkoutModel FirstRecodedWorkout;

        public PredictionController(UserModel user)
        {
            WorkoutController workoutController = new();
            CheatMealController cheatMealController = new();

            this.Workouts = workoutController.GetAllByUser(user.Id);
            this.CheatMeals = cheatMealController.GetAllByUser(user.Id);
        }

        private bool ValidateInputs(DateTime futureDate)
        {
            if (Workouts.Count == 0 || CheatMeals.Count == 0)
            {
                FormsHandler.InvalidValueMessage("Wourkout or cheat meals data not found");
                return false;
            }

            Workouts.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            LatestRecodedWorkout = Workouts.Last();
            FirstRecodedWorkout = Workouts.First();

            if (futureDate <= LatestRecodedWorkout.Date)
            {
                FormsHandler.InvalidValueMessage("Future date should be a date newer than latest recorded date");
                return false;
            }

            if (futureDate > DateTime.Today.AddMonths(2))
            {
                FormsHandler.InvalidValueMessage("Cannot predict more than 2 months ahead");
                return false;
            }


            return true;
        }

        public double[] PredictWeight(DateTime futureDate)
        {
            bool IsValidated = ValidateInputs(futureDate);

            double[] response = { 0, 0 };

            if (!IsValidated)
            {
                return response;
            }

            double startedWeigth = (double)FirstRecodedWorkout.Weight;
            double workoutCount = (double)Workouts.Count;
            double dateDiffTillFutureDate = (futureDate - LatestRecodedWorkout.Date).Days;

            double[] workoutHours = new double[Workouts.Count];
            double[] weights = new double[Workouts.Count];

            int i = 0;
            foreach (WorkoutModel workout in Workouts)
            {
                workoutHours[i] = (workout.EndTime - workout.StartTime).Hours;
                weights[i] = workout.Weight;
                i++;
            }

            double meanWeights = Mean(weights);

            double weightChangingOccur =  dateDiffTillFutureDate / workoutCount;
            double weigthDiff = (startedWeigth - meanWeights);

            double predictedWeight = Math.Ceiling(startedWeigth - (weightChangingOccur * weigthDiff));

            Debug.WriteLine("Predicted Weigth " + predictedWeight);

            response[0] = predictedWeight;
            response[1] = LatestRecodedWorkout.Weight;

            return response;
        }

        private double Mean(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public string PredictHealStatus(DateTime futureDate, double[] weigths)
        {
            bool isValidated = ValidateInputs(futureDate);

            if (!isValidated)
            {
                return null;
            }

            if (weigths[0] < weigths[1])
                return "Good";
            else
                return "Bad";
        }
    }
}
