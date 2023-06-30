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

            WorkoutTypeController workoutTypeController = new();

            WorkoutTypeModel runningWorkoutType = new()
            {
                Name = "Running"            
            };
            workoutTypeController.InsertWorkoutType(runningWorkoutType);

            WorkoutTypeModel cyclingWorkoutType = new()
            {
                Name = "Cycling"
            };
            workoutTypeController.InsertWorkoutType(cyclingWorkoutType);

            WorkoutTypeModel walkingWorkoutType = new()
            {
                Name = "Walking"
            };
            workoutTypeController.InsertWorkoutType(walkingWorkoutType);

            WorkoutTypeModel swimmingWorkoutType = new()
            {
                Name = "Swimming"
            };
            workoutTypeController.InsertWorkoutType(swimmingWorkoutType);


            WorkoutController workoutController = new();

            WorkoutModel workout1 = new()
            {
                Name = "Running 01",
                Type = runningWorkoutType,
                Date = new DateTime(2023, 01, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = true,
                RecurringType = "1",
                Weight = 70,
                Reps = 10,
                Sets = 3,
                Comment = "Comment"
            };
            workoutController.LogWorkout(workout1);

            WorkoutModel workout2 = new()
            {
                Name = "Running 02",
                Type = cyclingWorkoutType,
                Date = new DateTime(2023, 01, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout2);

            WorkoutModel workout3 = new()
            {
                Name = "Running 03",
                Type = walkingWorkoutType,
                Date = new DateTime(2023, 01, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout3);

            WorkoutModel workout4 = new()
            {
                Name = "Running 04",
                Type = swimmingWorkoutType,
                Date = new DateTime(2023, 01, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout4);

            WorkoutModel workout5 = new()
            {
                Name = "Running 05",
                Type = runningWorkoutType,
                Date = new DateTime(2023, 02, 25),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout5);

            WorkoutModel workout6 = new()
            {
                Name = "Running 06",
                Type = runningWorkoutType,
                Date = new DateTime(2023, 01, 13),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout6);

            WorkoutModel workout7 = new()
            {
                Name = "Running 07",
                Type = swimmingWorkoutType,
                Date = new DateTime(2023, 03, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout7);

            WorkoutModel workout8 = new()
            {
                Name = "Running 08",
                Type = cyclingWorkoutType,
                Date = new DateTime(2023, 02, 23),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                IsRecurring = false,
                Weight = 70
            };
            workoutController.LogWorkout(workout8);
        }
    }
}