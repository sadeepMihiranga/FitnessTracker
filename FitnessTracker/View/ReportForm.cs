using FitnessTracker.Controller;
using FitnessTracker.Model;
using FitnessTracker.Repository;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
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

            List<WorkoutModel> workouts =  WorkoutRepository.SearchForReport(from, to);

            if (workouts.Count == 0) 
            {
                MessageBox.Show("No data found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    using (StreamWriter streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine("Workout Type,Name,Date,Start Time,End Time,Weigth,Reps,Sets,Is Recurring,Recurring Type,Recurrsion Date,Comment");

                        foreach (WorkoutModel workout in workouts)
                        {
                            string recursionType = "";

                            if (workout.IsRecurring && (workout.RecurringType != null && !workout.RecurringType.Equals("")))
                            {
                                RecursionTypeModel recursionTypeModel = RecursionTypeRepository.GetById(Int64.Parse(workout.RecurringType));

                                if (recursionTypeModel != null)
                                    recursionType = recursionTypeModel.Name;
                            }

                            stringBuilder.AppendLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                                workout.Type.Name, workout.Name, workout.Date, workout.StartTime,workout.EndTime, workout.Weight, workout.Reps, 
                                workout.Sets, workout.IsRecurring, recursionType, workout.RecurrsionDate, workout.Comment));
                        }
                        streamWriter.Write(stringBuilder.ToString());
                    }
                }
            }
        }

        private void btnDownloadCheatMealReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpCheatMealFrom.Value;
            DateTime to = dtpCheatMealTo.Value;

            List<CheatMealModel> cheatMeals = CheatMealRepository.SearchForReport(from, to);

            if (cheatMeals.Count == 0)
            {
                MessageBox.Show("No data found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    using (StreamWriter streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine("Cheat Meal Type,Name,Portion Size,Reason To Take,Meal Satisfaction,Calories Taken,Date Time Taken,Comment");

                        foreach (CheatMealModel cheatMeal in cheatMeals)
                        {
                            stringBuilder.AppendLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                                cheatMeal.CheatMealType.Name, cheatMeal.Name, cheatMeal.MealPortionSize, cheatMeal.CheatMealReason.Name, cheatMeal.CheatMealSatisfcation,
                                cheatMeal.CaloriesTaken, cheatMeal.DateTimeTaken, cheatMeal.Comment));
                        }
                        streamWriter.Write(stringBuilder.ToString());
                    }
                }
            }
        }
    }
}
