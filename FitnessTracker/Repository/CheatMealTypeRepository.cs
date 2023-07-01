using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class CheatMealTypeRepository
    {
        private static List<CheatMealTypeModel> cheatMealTypes = new();
        private static readonly object cheatMealTypeSyncLock = new();

        public static List<CheatMealTypeModel> FindAll()
        {
            return cheatMealTypes;
        }

        public static CheatMealTypeModel Save(CheatMealTypeModel cheatMealType)
        {
            cheatMealTypes.Add(cheatMealType);
            return cheatMealType;
        }

        #region Get by Id
        public static CheatMealTypeModel GetById(long id)
        {
            return cheatMealTypes
                .Where(cm => cm.Id == id)
                //.Where(wt => wt.Status == Enums.CommonStatusEnum.ACTIVE)
                .First();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (cheatMealTypeSyncLock)
            {
                long newId = 1;

                if (!cheatMealTypes.Any())
                {
                    return newId;
                }

                CheatMealTypeModel cheatMealTypeWithMaxId = cheatMealTypes.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (cheatMealTypeWithMaxId != null)
                {
                    newId = cheatMealTypeWithMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}
