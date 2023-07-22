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