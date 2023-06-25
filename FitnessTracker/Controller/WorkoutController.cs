using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class WorkoutController
    {
        public long LogWorkout(WorkoutModel workout)
        {
            workout.Id = WorkoutRepository.GetNextAvailableId();
            workout.Status = Enum.CommonStatusEnum.ACTIVE;

            return WorkoutRepository.Save(workout).Id;
        }
    }
}
