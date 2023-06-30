using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class CheatMealReasonController
    {
        public List<ComboboxModel> ToComboboxList()
        {
            List<CheatMealReasonModel> cheatMealReasons = CheatMealReasonRepository.FindAll();
            return cheatMealReasons.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
        }

        public long InsertCheatMealReason(CheatMealReasonModel cheatMealReason)
        {
            cheatMealReason.Id = CheatMealReasonRepository.GetNextAvailableId();
            return CheatMealReasonRepository.Save(cheatMealReason).Id;
        }
    }
}
