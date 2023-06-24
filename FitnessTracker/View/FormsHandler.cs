using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FitnessTracker.View
{
    class FormsHandler : Form
    {
        /*handle all form loading events by placing received from on top of the BasePanel*/
        public static void LoadForm(object Form, Panel BasePanel)
        {
            if (BasePanel.Controls.Count > 0)
            {
                foreach (Control item in BasePanel.Controls)
                    BasePanel.Controls.Remove(item);
            }

            BasePanel.Controls.Clear();

            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            BasePanel.Controls.Add(form);
            BasePanel.Tag = form;

            form.Show();
        }

        public static void ClearDataGridView(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
        }

        public static DataGridViewButtonColumn CreateDGVButton(string name, string text, Color backColor, Color foreColor, Font font)
        {
            DataGridViewButtonColumn dgvbutton = new()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = name,
                Name = text
            };
            dgvbutton.DefaultCellStyle.Font = new Font(font, FontStyle.Bold);
            dgvbutton.FlatStyle = FlatStyle.Flat;
            dgvbutton.DefaultCellStyle.BackColor = backColor;
            dgvbutton.DefaultCellStyle.ForeColor = foreColor;

            return dgvbutton;
        }

        public static void OperationSuccessMessage(string message)
        {
            MessageBox.Show(message, "Opertation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        public static void OperationFailedErrorMessage(string message)
        {
            MessageBox.Show(message, "Opertation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public static void InfoRequiredErrorMessage(string filedName)
        {
            MessageBox.Show(filedName + " is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public static void AllowOnlyNumber(KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        public static void DrawBorder(Panel panel, PaintEventArgs e) 
        {
           ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
           Color.DimGray, 2, ButtonBorderStyle.Solid, // left
           Color.DimGray, 2, ButtonBorderStyle.Solid, // top
           Color.DimGray, 2, ButtonBorderStyle.Solid, // right
           Color.DimGray, 2, ButtonBorderStyle.Solid);// bottom
        }

        public static void ChnageTextBoxBackColor(TextBox textBox, Color color)
        {
            if (textBox.Enabled == false)
                textBox.BackColor = color;
            else
                textBox.BackColor = color;
        }

        public static void ChnageComboBoxBackColor(ComboBox comboBox, Color color)
        {
            if (comboBox.Enabled == false)
                comboBox.BackColor = color;
            else
                comboBox.BackColor = color;
        }
    }
}
