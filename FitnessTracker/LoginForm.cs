using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
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

        /* open the customer registration form */
        private void lblRegister_Click(object sender, EventArgs e)
        {
            /*CustomerRegister customerRegister = new CustomerRegister();
            customerRegister.Show();
            this.Hide();*/
        }

        /** login button click event */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*User user = null;
            List<Role> roles = null;
            List<string> roleNameList = null;

            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Username and Password required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                user = new User();
                user = user.FetchUserByUsernameAndPassword(Username, Password);

                roles = user.GetRolesByUserId(user.Id);
                roleNameList = new List<string>();

                foreach (Role role in roles)
                    roleNameList.Add(role.RoleName);

                if (user != null && user.Id > 0)
                {
                    MainMenuForm adminMenuForm = new MainMenuForm(roleNameList, user.PartyId);
                    adminMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password invalid", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.ShowOperationFailedErrorMessage(ex.Message);
            }
            finally
            {
                if (roles != null)
                    roles = null;

                if (user != null)
                    user = null;
            }*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(panel3, e);
        }

        public static void DrawBorder(Panel panel, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.DimGray, 2, ButtonBorderStyle.Solid, // left
            Color.DimGray, 2, ButtonBorderStyle.Solid, // top
            Color.DimGray, 2, ButtonBorderStyle.Solid, // right
            Color.DimGray, 2, ButtonBorderStyle.Solid);// bottom
        }
    }
}
