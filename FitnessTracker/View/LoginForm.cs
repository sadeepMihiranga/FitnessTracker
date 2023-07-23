using FitnessTracker.Controller;
using FitnessTracker.DTOs;
using FitnessTracker.Model;

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
            WaitingForm waiting = new();
            waiting.Show();

            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                FormsHandler.InfoRequiredErrorMessage("Username and Password");
                return;
            }

            try
            {
                UsersController usersController = new();

                APIResponseWrapper<UserModel> response = usersController.AuthenticateUser(Username, Password);

                if (response.Success == true)
                {
                    if (response.SuccessReponse != null)
                    {
                        MainMenuForm adminMenuForm = new(response.SuccessReponse);
                        adminMenuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while logging");
                        return;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(response.ErrorResponse.Title);
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while logging");
                return;
            }
            finally
            {
                waiting.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            FormsHandler.DrawBorder(mainPanel, e);
        }
    }
}
