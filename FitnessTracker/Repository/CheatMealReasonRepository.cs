using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class CheatMealReasonRepository
    {
        private static List<CheatMealReasonModel> cheatMealReasons = new();
        private static readonly object cheatMealReasonTypeSyncLock = new();

        public static List<CheatMealReasonModel> FindAll()
        {
            return cheatMealReasons;
        }

        public static CheatMealReasonModel Save(CheatMealReasonModel cheatMealReason)
        {
            cheatMealReasons.Add(cheatMealReason);
            return cheatMealReason;
        }

        public static long GetNextAvailableId()
        {
            lock (cheatMealReasonTypeSyncLock)
            {
                long newId = 1;

                if (!cheatMealReasons.Any())
                {
                    return newId;
                }

                CheatMealReasonModel cheatMealReasonWithMaxId = cheatMealReasons.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (cheatMealReasonWithMaxId != null)
                {
                    newId = cheatMealReasonWithMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}
