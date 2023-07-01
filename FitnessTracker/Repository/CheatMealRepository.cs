using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class CheatMealRepository : BaseRepository
    {
        private static List<CheatMealModel> cheatMeals = new();
        private static readonly object cheatMealSyncLock = new();

        #region Insert Cheat Meal
        public static CheatMealModel Save(CheatMealModel cheatMeal)
        {
            cheatMeals.Add(cheatMeal);
            return cheatMeal;
        }
        #endregion

        #region Cheat Meals paginated search
        public static List<CheatMealModel> Search(CheatMealModel searchParams, int page, int size)
        {
            List<CheatMealModel> filteredCheatMeals = cheatMeals
                .Where(w => searchParams.CheatMealType == null || (searchParams.CheatMealType != null && w.CheatMealType.Id == searchParams.CheatMealType.Id))
                .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).ToList();

            return (List<CheatMealModel>)GetPage(filteredCheatMeals, page, size);
        }
        #endregion

        #region Remove Cheat Meal
        public static void Remove(CheatMealModel cheatMeal)
        {
            cheatMeals.Remove(cheatMeal);
        }
        #endregion


        #region Get Cheat Meal by ID
        public static CheatMealModel GetById(long cheatMealId)
        {
            return cheatMeals
                 .Where(w => w.Id == cheatMealId)
                 .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).First();
        }
        #endregion

        #region Cheat Meals for Reports
        public static List<CheatMealModel> SearchForReport(DateTime from, DateTime to)
        {
            return cheatMeals
                .Where(w => w.DateTimeTaken >= from)
                .Where(w => w.DateTimeTaken < to)
                .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).ToList();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (cheatMealSyncLock)
            {
                long newId = 1;

                if (!cheatMeals.Any())
                {
                    return newId;
                }

                CheatMealModel cheatMealMaxId = cheatMeals.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (cheatMealMaxId != null)
                {
                    newId = cheatMealMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}
