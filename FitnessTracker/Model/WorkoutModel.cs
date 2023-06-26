using FitnessTracker.Enum;

namespace FitnessTracker.Model
{
    public class WorkoutModel
    {
        #region Attributes of Workout
        public long Id { get; set; }
        public string Name { get; set; }
        public WorkoutTypeModel Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public bool IsRecurring { get; set; }
        public string Comment { get; set; }
        public CommonStatusEnum Status { get; set; }
        #endregion
    }
}
