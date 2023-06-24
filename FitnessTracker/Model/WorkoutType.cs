using FitnessTracker.Enum;

namespace FitnessTracker.Model
{
    internal class WorkoutType
    {
        #region Attributes of WorkoutType
        public long Id { get; set; }
        public string Name { get; set; }
        public CommonStatusEnum Status { get; set; }
        #endregion
    }
}
