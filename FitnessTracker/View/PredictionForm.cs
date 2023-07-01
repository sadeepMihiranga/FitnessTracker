using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.View
{
    public partial class PredictionForm : Form
    {
        public PredictionForm()
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            MainMenuForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
