using FitnessTracker.Enum;

namespace FitnessTracker.Model
{
    public class WorkoutTypeModel
    {
        #region Attributes of WorkoutType
        public long Id { get; set; }
        public string Name { get; set; }
        public CommonStatusEnum Status { get; set; }
        #endregion
    }
}
