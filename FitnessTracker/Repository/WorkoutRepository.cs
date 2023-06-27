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
                //.Where(w => searchParams.Type != null && w.Type.Name.Equals(searchParams.Type.Name))
                //.Where(w => searchParams.Weight != 0 && w.Weight == searchParams.Weight)
                .Where(w => w.Status == Enum.CommonStatusEnum.ACTIVE).ToList();

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
                 .Where(w => w.Status == Enum.CommonStatusEnum.ACTIVE).First();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (workoutsSyncLock)
            {
                long newWorkoutId = 1;

                if (!workouts.Any())
                {
                    return newWorkoutId;
                }

                WorkoutModel workoutWithMaxId = workouts.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (workoutWithMaxId != null)
                {
                    newWorkoutId = workoutWithMaxId.Id + 1;
                }

                return newWorkoutId;
            }
        }
    }
}
