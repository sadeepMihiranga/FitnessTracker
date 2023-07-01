using FitnessTracker.Controller;
using FitnessTracker.Enums;
using FitnessTracker.Model;
using System.ComponentModel;

namespace FitnessTracker.View.CustomUserControl
{
    public partial class CheatMealUserControl : UserControl
    {
        private UserModel LoggedUser;
        private Panel PanelMain;
        private long CheatMealId;

        public CheatMealUserControl(UserModel user, long cheatMealId, Panel panelMain)
        {
            this.LoggedUser = user;
            this.PanelMain = panelMain;
            this.CheatMealId = cheatMealId;

            InitializeComponent();
        }

        private string _title;
        private string _mealName;
        private string _portionSize;
        private string _addedTime;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblCheatMealType.Text = value; }
        }

        [Category("Custom Props")]
        public string MealName
        {
            get { return _mealName; }
            set { _mealName = value; lbleMealName.Text = value; }
        }

        [Category("Custom Props")]
        public string PortionSize
        {
            get { return _portionSize; }
            set { _portionSize = value; lblMealPortionSize.Text = value; }
        }

        [Category("Custom Props")]
        public string AddedTime
        {
            get { return _addedTime; }
            set { _addedTime = value; lblMealTakenDateTime.Text = value; }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; picBoxMealSatisfactionImage.Image = value; picBoxMealSatisfactionImage.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageCheatMealForm(LoggedUser, EventType.EDIT, CheatMealId), PanelMain);
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove this Cheat Meal ?", "Message",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CheatMealController cheatMealController = new();
                cheatMealController.RemoveCheatMeal(CheatMealId, LoggedUser.Id);

                FormsHandler.LoadForm(new CheatMealForm(LoggedUser, PanelMain), PanelMain);
            }
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            FormsHandler.LoadForm(new ManageCheatMealForm(LoggedUser, EventType.VIEW, CheatMealId), PanelMain);
        }
    }
}
