using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View;

namespace FitnessTracker.Controller
{
    internal class CheatMealController
    {
        public long LogCheatMeal(CheatMealModel cheatMeal)
        {
            cheatMeal.Id = CheatMealRepository.GetNextAvailableId();
            cheatMeal.Status = Enums.CommonStatusEnum.ACTIVE;

            return CheatMealRepository.Save(cheatMeal).Id;
        }

        public void RemoveCheatMeal(long cheatMealId, long userId)
        {
            CheatMealModel cheatMeal = CheatMealRepository.GetById(cheatMealId, userId);

            if (cheatMeal == null)
            {
                FormsHandler.OperationFailedErrorMessage("Cheat meal id invalid.");
                return;
            }

            CheatMealRepository.Remove(cheatMeal);
        }

        public CheatMealModel GetCheatMealById(long cheatMealId, long userId)
        {
            return CheatMealRepository.GetById(cheatMealId, userId);
        }
    }
}
