using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class RecursionTypeController
    {
        public List<ComboboxModel> ToComboboxList()
        {
            List<RecursionTypeModel> recursionTypes = RecursionTypeRepository.FindAll();
            return recursionTypes.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
        }

        public long InsertRecursionType(RecursionTypeModel recursionType)
        {
            recursionType.Id = RecursionTypeRepository.GetNextAvailableId();
            return RecursionTypeRepository.Save(recursionType).Id;
        }
    }
}
