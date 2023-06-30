using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class WorkoutTypeRepository
    {
        private static List<WorkoutTypeModel> workoutTypes = new();
        private static readonly object workoutTypeSyncLock = new();

        #region Insert WorkoutType
        public static WorkoutTypeModel Save(WorkoutTypeModel workoutType)
        {
            workoutTypes.Add(workoutType);
            return workoutType;
        }
        #endregion

        #region Get All WorkoutTypes
        public static List<WorkoutTypeModel> GetALL()
        {
            return workoutTypes.Where(u => u.Status == Enums.CommonStatusEnum.ACTIVE).ToList();
        }
        #endregion

        #region Get by Id
        public static WorkoutTypeModel GetById(long id)
        {
            return workoutTypes
                .Where(wt => wt.Id == id)
                .Where(wt => wt.Status == Enums.CommonStatusEnum.ACTIVE)
                .First();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (workoutTypeSyncLock)
            {
                long newId = 1;

                if (!workoutTypes.Any())
                {
                    return newId;
                }

                WorkoutTypeModel workoutTypeWithMaxId = workoutTypes.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (workoutTypeWithMaxId != null)
                {
                    newId = workoutTypeWithMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}
