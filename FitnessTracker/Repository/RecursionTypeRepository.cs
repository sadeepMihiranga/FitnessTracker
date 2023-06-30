using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class RecursionTypeRepository
    {
        private static List<RecursionTypeModel> recursionTypes = new();
        private static readonly object recursionTypeSyncLock = new();

        public static List<RecursionTypeModel> FindAll() 
        {
            return recursionTypes;
        }

        public static RecursionTypeModel Save(RecursionTypeModel recursionType)
        {
            recursionTypes.Add(recursionType);
            return recursionType;
        }

        public static long GetNextAvailableId()
        {
            lock (recursionTypeSyncLock)
            {
                long newRecursionTypeId = 1;

                if (!recursionTypes.Any())
                {
                    return newRecursionTypeId;
                }

                RecursionTypeModel recursionTypeWithMaxId = recursionTypes.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (recursionTypeWithMaxId != null)
                {
                    newRecursionTypeId = recursionTypeWithMaxId.Id + 1;
                }

                return newRecursionTypeId;
            }
        }
    }
}
