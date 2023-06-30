using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class CheatMealTypeController
    {
        public List<ComboboxModel> ToComboboxList()
        {
            List<CheatMealTypeModel> cheatMealTypes = CheatMealTypeRepository.FindAll();
            return cheatMealTypes.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
        }

        public long InsertCheatMealType(CheatMealTypeModel cheatMealType)
        {
            cheatMealType.Id = CheatMealTypeRepository.GetNextAvailableId();
            return CheatMealTypeRepository.Save(cheatMealType).Id;
        }
    }
}
