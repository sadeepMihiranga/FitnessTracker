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
    public partial class WaitingForm : Form
    {
        public WaitingForm()
        {
            InitializeComponent();

            this.TransparencyKey = Color.DarkGray;
            this.BackColor = Color.DarkGray;
        }
    }
}
