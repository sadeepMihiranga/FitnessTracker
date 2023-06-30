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
            cheatMeal.Status = Enum.CommonStatusEnum.ACTIVE;

            return CheatMealRepository.Save(cheatMeal).Id;
        }

        public void RemoveCheatMeal(long cheatMealId)
        {
            CheatMealModel cheatMeal = CheatMealRepository.GetById(cheatMealId);

            if (cheatMeal == null)
            {
                FormsHandler.OperationFailedErrorMessage("Cheat meal id invalid.");
                return;
            }

            CheatMealRepository.Remove(cheatMeal);
        }

        public CheatMealModel GetCheatMealId(long cheatMealId)
        {
            return CheatMealRepository.GetById(cheatMealId);
        }
    }
}
