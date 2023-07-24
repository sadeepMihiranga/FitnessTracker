using FitnessTracker.Controller;
using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.View;
using System.Xml;

namespace FitnessTracker
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void lblTryLogin_hover(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.FromArgb(32, 32, 32); //darkercolor
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblGoToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = txtFullName.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string DobString = dtpDob.Value.ToString("yyyy-MM-dd");
            string Gender = "";
            string Address = txtAddress.Text;
            string Email = txtEmail.Text;
            string ContactNo = txtContactNo1.Text;
            //short TermsAndConditionStatus = 0;

            if (rdbMale.Checked)
                Gender = rdbMale.Text;

            else if (rdbFeMale.Checked)
                Gender = rdbFeMale.Text;

            /*if (cbTermsAndConditions.Checked)
                TermsAndConditionStatus = 1;*/

            if (String.IsNullOrEmpty(Name))
            {
                FormsHandler.InfoRequiredErrorMessage("Name");
                return;
            }

            if (String.IsNullOrEmpty(Username))
            {
                FormsHandler.InfoRequiredErrorMessage("Username");
                return;
            }

            if (String.IsNullOrEmpty(Password))
            {
                FormsHandler.InfoRequiredErrorMessage("Password");
                return;
            }

            if (String.IsNullOrEmpty(Gender))
            {
                FormsHandler.InfoRequiredErrorMessage("Gender");
                return;
            }

            if (String.IsNullOrEmpty(DobString))
            {
                FormsHandler.InfoRequiredErrorMessage("Date of birth");
                return;
            }

            DateTime DobDateTime = DateTime.ParseExact(DobString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                UserModel user = new()
                {
                    Username = Username,
                    Password = Password,
                    FullName = Name,
                    DateOfBirth = DobDateTime,
                    Gender = Gender,
                    Address = Address,
                    Email = Email,
                    MobileNumber = ContactNo,
                    FirstName = Name
                };

                UsersController usersController = new();
                HttpResponseMessage response = usersController.RegisterUser(user);

                if (response.IsSuccessStatusCode)
                {
                    FormsHandler.OperationSuccessMessage("Registration Success");
                }
                else
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    if (!string.IsNullOrEmpty(content))
                    {
                        var xmlDocument = new XmlDocument();
                        xmlDocument.LoadXml(content);

                        // Set up a namespace manager to handle the XML namespace (if any)
                        XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDocument.NameTable);
                        nsManager.AddNamespace("ns", "urn:ietf:rfc:7807");
                        XmlNode xNode = xmlDocument.SelectSingleNode("//ns:title", nsManager);

                        FormsHandler.OperationFailedErrorMessage(xNode.InnerText);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while registering user");
            }
            finally
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtContactNo1.Clear();
            cbTermsAndConditions.Checked = false;
            rdbFeMale.Checked = false;
            rdbMale.Checked = false;
        }

        private void txtContactNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsHandler.AllowOnlyNumber(e);
        }

        /* draw border */
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            FormsHandler.DrawBorder(panel10, e);
        }
    }
}
