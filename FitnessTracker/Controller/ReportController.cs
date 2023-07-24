﻿using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View;
using System.Text;

namespace FitnessTracker.Controller
{
    internal class ReportController
    {
        public static void GenerateWorkoutReport(long userId, DateTime from, DateTime to)
        {
            WorkoutController workoutController = new();
            List<WorkoutModel> workouts = null;

            try
            {
                APIResponseWrapper<List<WorkoutModel>> response = workoutController.SearchForReport(userId, from, to);

                if (response.Success == true)
                {
                    if (response.SuccessReponse != null)
                    {
                        workouts = response.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching workouts");
                        return;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(response.ErrorResponse.Title);
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while fetching workouts");
                return;
            }
            finally
            {
            }

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
                                workout.Type.Name, workout.Name, workout.Date, workout.StartTime, workout.EndTime, workout.Weight, workout.Reps,
                                workout.Sets, workout.IsRecurring, recursionType, workout.RecurrsionDate, workout.Comment));
                        }
                        streamWriter.Write(stringBuilder.ToString());
                    }
                }
            }
        }

        public static void GenerateCheatMealReport(long userId, DateTime from, DateTime to)
        {
            CheatMealController cheatMealController = new();
            List<CheatMealModel> cheatMeals = null;

            try
            {
                APIResponseWrapper<List<CheatMealModel>> response = cheatMealController.SearchForReport(userId, from, to);

                if (response.Success == true)
                {
                    if (response.SuccessReponse != null)
                    {
                        cheatMeals = response.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching cheat meals");
                        return;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(response.ErrorResponse.Title);
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while fetching cheat meals");
                return;
            }
            finally
            {
            }

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
                                cheatMeal.MealType.Name, cheatMeal.Name, cheatMeal.MealPortionSize, cheatMeal.MealReason.Name, cheatMeal.CheatMealSatisfcation,
                                cheatMeal.CaloriesTaken, cheatMeal.DateTimeTaken, cheatMeal.Comment));
                        }
                        streamWriter.Write(stringBuilder.ToString());
                    }
                }
            }
        }
    }
}
