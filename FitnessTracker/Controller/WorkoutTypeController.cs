using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class WorkoutTypeController
    {
        public long InsertWorkoutType(WorkoutType workoutType)
        {
            workoutType.Id = WorkoutTypeRepository.GetNextAvailableId();
            workoutType.Status = Enum.CommonStatusEnum.ACTIVE;

            return WorkoutTypeRepository.Save(workoutType).Id;
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<WorkoutType> workoutTypes = WorkoutTypeRepository.GetALL();
            return workoutTypes.Select(i => new ComboboxModel(i.Id, i.Name)).ToList();
        }
    }
}
