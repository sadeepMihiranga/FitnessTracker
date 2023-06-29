namespace FitnessTracker.Model
{
    public class ComboboxModel
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public ComboboxModel(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
