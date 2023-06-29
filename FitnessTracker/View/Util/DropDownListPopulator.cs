using FitnessTracker.Model;

namespace FitnessTracker.View.Util
{
    internal class DropDownListPopulator
    {
        public static void PopulateCombobox(List<ComboboxModel> listItems, ComboBox comboBox)
        {
            if (listItems.Count > 0)
            {
                comboBox.DataSource = null;
                comboBox.Items.Clear();

                Dictionary<string, string> dictionary = new()
                {
                    { "NA", "Select a option" }
                };

                foreach (var item in listItems)
                    dictionary.Add(Convert.ToString(item.Key), item.Value);

                comboBox.DisplayMember = "Value";
                comboBox.ValueMember = "Key";
                comboBox.DataSource = new BindingSource(dictionary, null);
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}
