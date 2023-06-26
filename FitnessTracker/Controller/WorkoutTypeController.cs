using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class WorkoutTypeController
    {
        public long InsertWorkoutType(WorkoutTypeModel workoutType)
        {
            workoutType.Id = WorkoutTypeRepository.GetNextAvailableId();
            workoutType.Status = Enum.CommonStatusEnum.ACTIVE;

            return WorkoutTypeRepository.Save(workoutType).Id;
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<WorkoutTypeModel> workoutTypes = WorkoutTypeRepository.GetALL();
            return workoutTypes.Select(i => new ComboboxModel(i.Id, i.Name)).ToList();
        }

        public WorkoutTypeModel GetById(long id)
        {
            return WorkoutTypeRepository.GetById(id);
        }
    }
}
