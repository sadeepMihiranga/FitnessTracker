namespace FitnessTracker.Model
{
    internal class ComboboxModel
    {
        public long Id { get; set; }
        public string Value { get; set; }

        public ComboboxModel(long id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
