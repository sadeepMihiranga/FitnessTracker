using FitnessTracker.Controller;
using FitnessTracker.Model;

namespace FitnessTracker
{
    internal static class Program
    {
        static UserModel loggedUser = null;

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
            //InsertInitUser();
            //InsertWorkoutInfo();
            InsertRecursionType();
            //InsertCheatMeals();
        }

        private static void InsertInitUser()
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
            loggedUser = usersController.RegisterUser(user);
        }

        private static void InsertWorkoutInfo()
        {
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
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 19, 00, 00),
                IsRecurring = true,
                RecurringType = "1",
                Weight = 85,
                Reps = 10,
                Sets = 3,
                Comment = "Comment",
                User = loggedUser
            };
            workoutController.LogWorkout(workout1);

            WorkoutModel workout2 = new()
            {
                Name = "Running 02",
                Type = cyclingWorkoutType,
                Date = new DateTime(2023, 01, 24),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 19, 00, 00),
                IsRecurring = false,
                Weight = 85,
                User = loggedUser
            };
            workoutController.LogWorkout(workout2);

            WorkoutModel workout3 = new()
            {
                Name = "Running 03",
                Type = walkingWorkoutType,
                Date = new DateTime(2023, 01, 25),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 19, 00, 00),
                IsRecurring = false,
                Weight = 84,
                User = loggedUser
            };
            workoutController.LogWorkout(workout3);

            WorkoutModel workout4 = new()
            {
                Name = "Running 04",
                Type = swimmingWorkoutType,
                Date = new DateTime(2023, 01, 27),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 19, 00, 00),
                IsRecurring = false,
                Weight = 84,
                User = loggedUser
            };
            workoutController.LogWorkout(workout4);

            WorkoutModel workout5 = new()
            {
                Name = "Running 05",
                Type = runningWorkoutType,
                Date = new DateTime(2023, 01, 28),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 20, 00, 00),
                IsRecurring = false,
                Weight = 83,
                User = loggedUser
            };
            workoutController.LogWorkout(workout5);

            WorkoutModel workout6 = new()
            {
                Name = "Running 06",
                Type = runningWorkoutType,
                Date = new DateTime(2023, 02, 01),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 20, 00, 00),
                IsRecurring = false,
                Weight = 84,
                User = loggedUser
            };
            workoutController.LogWorkout(workout6);

            WorkoutModel workout7 = new()
            {
                Name = "Running 07",
                Type = swimmingWorkoutType,
                Date = new DateTime(2023, 02, 02),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 20, 00, 00),
                IsRecurring = false,
                Weight = 83,
                User = loggedUser
            };
            workoutController.LogWorkout(workout7);

            WorkoutModel workout8 = new()
            {
                Name = "Running 08",
                Type = cyclingWorkoutType,
                Date = new DateTime(2023, 02, 03),
                StartTime = new DateTime(2023, 01, 23, 18, 00, 00),
                EndTime = new DateTime(2023, 01, 23, 21, 00, 00),
                IsRecurring = false,
                Weight = 82,
                User = loggedUser
            };
            workoutController.LogWorkout(workout8);
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

        private static void InsertCheatMeals() 
        {
            /** CheatMealReasons */
            CheatMealReasonController cheatMealReasonController = new();

            CheatMealReasonModel party = new()
            {
                Name = "Party"
            };
            cheatMealReasonController.InsertCheatMealReason(party);

            CheatMealReasonModel busyness = new()
            {
                Name = "Busyness"
            };
            cheatMealReasonController.InsertCheatMealReason(busyness);

            CheatMealReasonModel formal = new()
            {
                Name = "Formal Event"
            };
            cheatMealReasonController.InsertCheatMealReason(formal);

            CheatMealReasonModel wedding = new()
            {
                Name = "Wedding"
            };
            cheatMealReasonController.InsertCheatMealReason(wedding);

            CheatMealReasonModel dineout = new()
            {
                Name = "Dineout"
            };
            cheatMealReasonController.InsertCheatMealReason(dineout);

            /** CheatMealTypes */
            CheatMealTypeController cheatMealTypeController = new();

            CheatMealTypeModel meat = new()
            {
                Name = "Meat"
            };
            cheatMealTypeController.InsertCheatMealType(meat);

            CheatMealTypeModel bakeryFood = new()
            {
                Name = "Bakery Food"
            };
            cheatMealTypeController.InsertCheatMealType(bakeryFood);

            CheatMealTypeModel beer = new()
            {
                Name = "Beer"
            };
            cheatMealTypeController.InsertCheatMealType(beer);

            CheatMealTypeModel wine = new()
            {
                Name = "Wine"
            };
            cheatMealTypeController.InsertCheatMealType(wine);

            CheatMealTypeModel pizza = new()
            {
                Name = "Pizza"
            };
            cheatMealTypeController.InsertCheatMealType(pizza);

            CheatMealTypeModel fries = new()
            {
                Name = "Fries"
            };
            cheatMealTypeController.InsertCheatMealType(fries);

            /** CheatMeals */
            CheatMealController cheatMealController = new();

            CheatMealModel bbqBeef = new()
            {
                Name = "BBQ Beef",
                CheatMealType = meat,
                CheatMealReason = party,
                CaloriesTaken = 100,
                DateTimeTaken = new DateTime(2023, 02, 25),
                MealPortionSize = Enums.MealPortionSizeEnum.Large,
                CheatMealSatisfcation = Enums.CheatMealSatisfcationEnum.Sad,
                Comment = "This is a comment",
                User = loggedUser
            };
            cheatMealController.LogCheatMeal(bbqBeef);

            CheatMealModel pizzaHut = new()
            {
                Name = "Supreem Pizza with Friend",
                CheatMealType = pizza,
                CheatMealReason = dineout,
                CaloriesTaken = 80,
                DateTimeTaken = new DateTime(2023, 01, 25),
                MealPortionSize = Enums.MealPortionSizeEnum.Medium,
                CheatMealSatisfcation = Enums.CheatMealSatisfcationEnum.Happy,
                Comment = "This is a comment",
                User = loggedUser
            };
            cheatMealController.LogCheatMeal(pizzaHut);

            CheatMealModel officeParty = new()
            {
                Name = "Office party",
                CheatMealType = wine,
                CheatMealReason = formal,
                CaloriesTaken = 80,
                DateTimeTaken = new DateTime(2023, 04, 25),
                MealPortionSize = Enums.MealPortionSizeEnum.ExtraLarge,
                CheatMealSatisfcation = Enums.CheatMealSatisfcationEnum.Neutral,
                Comment = "This is a comment",
                User = loggedUser
            };
            cheatMealController.LogCheatMeal(officeParty);
        }
    }
}