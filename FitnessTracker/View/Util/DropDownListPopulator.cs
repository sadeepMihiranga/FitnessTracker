using FitnessTracker.Model;

namespace FitnessTracker.View.Util
{
    internal class DropDownListPopulator
    {
        public static void PopulateCombobox(List<ComboboxModel> listItems, ComboBox comboBox)
        {
            if (listItems.Count > 0)
            {
                Dictionary<string, string> dictionary = new()
                {
                    { "Select a option", "NA" }
                };

                foreach (var item in listItems)
                    dictionary.Add(item.Value, Convert.ToString(item.Id));

                comboBox.DataSource = new BindingSource(dictionary, null);
                comboBox.DisplayMember = "Key";
                comboBox.ValueMember = "Value";
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}
