using FitnessTracker.Controller;
using FitnessTracker.Model;

namespace FitnessTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View.LoginForm());
            //Application.Run(new  View.PredictionForm(loggedUser));
            //Application.Run(new View.MainMenuForm());
        }

        private static void InitData()
        {
            InsertRecursionType();
        }

        private static void InsertRecursionType()
        {
            RecursionTypeController recursionTypeController = new();

            RecursionTypeModel daily = new()
            {
                Name = "Daily"
            };
            recursionTypeController.InsertRecursionType(daily);

            RecursionTypeModel weekly = new()
            {
                Name = "Weekly"
            };
            recursionTypeController.InsertRecursionType(weekly);
        }        
    }
}