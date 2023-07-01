using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View;

namespace FitnessTracker.Controller
{
    internal class WorkoutController
    {
        public long LogWorkout(WorkoutModel workout)
        {
            workout.Id = WorkoutRepository.GetNextAvailableId();
            workout.Status = Enums.CommonStatusEnum.ACTIVE;

            return WorkoutRepository.Save(workout).Id;
        }

        public void RemoveWorkout(long workoutId, long userId)
        {
            WorkoutModel workout = WorkoutRepository.GetById(workoutId, userId);

            if (workout == null)
            {
                FormsHandler.OperationFailedErrorMessage("Workout id invalid.");
                return;
            }

            WorkoutRepository.Remove(workout);
        }

        public WorkoutModel GetWorkoutById(long workoutId, long userId)
        {
            return WorkoutRepository.GetById(workoutId, userId);
        }

        public WorkoutModel UpdateWorkout(WorkoutModel workout)
        {
            WorkoutModel workoutModel = WorkoutRepository.GetById(workout.Id, workout.Id);

            if (workoutModel == null)
            {
                FormsHandler.OperationFailedErrorMessage("Workout id invalid.");
            }

            workoutModel.Date = workout.Date;
            workoutModel.Name = workout.Name;
            workoutModel.Type = workout.Type;
            workoutModel.Reps = workout.Reps;
            workoutModel.Sets = workout.Sets;
            workoutModel.Comment = workout.Comment;
            workoutModel.StartTime = workout.StartTime;
            workoutModel.EndTime = workout.EndTime; 
            workoutModel.IsRecurring = workout.IsRecurring; 
            workoutModel.RecurringType = workout.RecurringType;
            workoutModel.RecurrsionDate = workout.RecurrsionDate;
            workoutModel.Weight = workout.Weight;

            return workoutModel;
        }
    }
}
