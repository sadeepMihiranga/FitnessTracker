using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class WorkoutRepository : BaseRepository
    {
        private static List<WorkoutModel> workouts = new();
        private static readonly object workoutsSyncLock = new();

        #region Insert Workout
        public static WorkoutModel Save(WorkoutModel workout)
        {
            workouts.Add(workout);
            return workout;
        }
        #endregion

        #region Workouts paginated search
        public static List<WorkoutModel> Search(WorkoutModel searchParams, int page, int size)
        {
            List<WorkoutModel> filteredWorkouts = workouts
                .Where(w => searchParams.Type == null || (searchParams.Type != null && w.Type.Name.Equals(searchParams.Type.Name)))
                //.Where(w => searchParams.Weight != 0 && w.Weight == searchParams.Weight)
                .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).ToList();

            return (List<WorkoutModel>)GetPage(filteredWorkouts, page, size);
        }
        #endregion

        #region Remove Workout
        public static void Remove(WorkoutModel workout)
        {
            workouts.Remove(workout);
        }
        #endregion

        #region Get Workout by ID
        public static WorkoutModel GetById(long workoutId)
        {
            return workouts
                 .Where(w => w.Id == workoutId)
                 .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).First();
        }
        #endregion

        #region Workouts for Reports
        public static List<WorkoutModel> SearchForReport(DateTime from, DateTime to)
        {
            return workouts
                .Where(w => w.Date >= from)
                .Where(w => w.Date < to)
                .Where(w => w.Status == Enums.CommonStatusEnum.ACTIVE).ToList();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (workoutsSyncLock)
            {
                long newId = 1;

                if (!workouts.Any())
                {
                    return newId;
                }

                WorkoutModel workoutWithMaxId = workouts.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (workoutWithMaxId != null)
                {
                    newId = workoutWithMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}
