using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.View
{
    public partial class LoginForm : Form
    {
        private Label selectedLabel;

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

            /* alert if capslock is on */
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("The Caps Lock key is ON.");
        }

        /** this will close login scrreen windows */
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.FromArgb(32, 32, 32); //darkercolor
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            if (label == this.selectedLabel || this.selectedLabel == null) return;
            label.ForeColor = Color.FromArgb(160, 160, 160); //lightercolor
        }

        /* open the user registration form */
        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new();
            registerForm.Show();
            this.Hide();
        }

        /** login button click event */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                FormsHandler.InfoRequiredErrorMessage("Username and Password");
                return;
            }

            try
            {
                UserModel user = new();
                user = UserRepository.FetchUserByUsernameAndPassword(Username, Password);

                if (user != null && user.Id > 0)
                {
                    MainMenuForm adminMenuForm = new(user);
                    adminMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage("Username or Password invalid");
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage(ex.Message);
            }
            finally
            {

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            FormsHandler.DrawBorder(mainPanel, e);
        }
    }
}
