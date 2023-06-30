﻿using FitnessTracker.Enum;

namespace FitnessTracker.Model
{
    internal class CheatMealModel
    {
        public long Id { get; set; }
        public CheatMealTypeModel CheatMealType  { get; set; }
        public string Name  { get; set; }
        public MealPortionSizeEnum MealPortionSize  { get; set; }
        public CheatMealReasonModel CheatMealReason  { get; set; }
        public int CaloriesTaken { get; set; }
        public DateTime DateTimeTaken { get; set; }
        public string Comment { get; set; }
        public CommonStatusEnum Status { get; set; }
    }
}