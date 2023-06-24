using FitnessTracker.Enum;

namespace FitnessTracker.Model
{
    internal class Workout
    {
        #region Attributes of Workout
        public long Id { get; set; }
        public string Name { get; set; }
        public WorkoutType Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public CommonStatusEnum Status { get; set; }
        #endregion
    }
}
