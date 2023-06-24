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
            //Application.Run(new View.LoginForm());
            Application.Run(new View.MainMenuForm(1));
        }

        private static void InitData()
        {
            UserModel user = new()
            {
                Username = "sadeep",
                Password = "1234",
                FullName = "Sadeep Mihitanga",
                DateOfBirth = new DateTime(1997, 1, 13),
                Gender = "M",
                Address = "Kahangama,Ratnapura",
                Email = "saddeepmihiranga@gmail.com",
                MobileNumber = "0766295259"
            };

            UsersController usersController = new();
            usersController.RegisterUser(user);
        }
    }
}