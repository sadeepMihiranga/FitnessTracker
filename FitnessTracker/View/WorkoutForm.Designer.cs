namespace FitnessTracker.View
{
    partial class WorkoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWorkoutMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panelWorkoutHeader = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picborkoutClearFilter = new System.Windows.Forms.PictureBox();
            this.pictureBoxVehicleFilter = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYomSearch = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbVehicleConditionSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbWorkoutTypeSearch = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelWorkoutList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWorkoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelWorkoutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picborkoutClearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWorkoutMain
            // 
            this.panelWorkoutMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelWorkoutMain.Controls.Add(this.panel1);
            this.panelWorkoutMain.Controls.Add(this.pictureBoxNext);
            this.panelWorkoutMain.Controls.Add(this.pictureBoxBack);
            this.panelWorkoutMain.Controls.Add(this.panelWorkoutHeader);
            this.panelWorkoutMain.Controls.Add(this.flowLayoutPanelWorkoutList);
            this.panelWorkoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkoutMain.Location = new System.Drawing.Point(0, 0);
            this.panelWorkoutMain.Name = "panelWorkoutMain";
            this.panelWorkoutMain.Size = new System.Drawing.Size(1150, 729);
            this.panelWorkoutMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 5);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNext.Image = global::FitnessTracker.Properties.Resources.next;
            this.pictureBoxNext.Location = new System.Drawing.Point(584, 692);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 77;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::FitnessTracker.Properties.Resources.previous;
            this.pictureBoxBack.Location = new System.Drawing.Point(541, 692);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 76;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // panelWorkoutHeader
            // 
            this.panelWorkoutHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelWorkoutHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelWorkoutHeader.Controls.Add(this.picborkoutClearFilter);
            this.panelWorkoutHeader.Controls.Add(this.pictureBoxVehicleFilter);
            this.panelWorkoutHeader.Controls.Add(this.label10);
            this.panelWorkoutHeader.Controls.Add(this.txtYomSearch);
            this.panelWorkoutHeader.Controls.Add(this.panel11);
            this.panelWorkoutHeader.Controls.Add(this.cmbVehicleConditionSearch);
            this.panelWorkoutHeader.Controls.Add(this.label1);
            this.panelWorkoutHeader.Controls.Add(this.panel2);
            this.panelWorkoutHeader.Controls.Add(this.cmbWorkoutTypeSearch);
            this.panelWorkoutHeader.Controls.Add(this.label12);
            this.panelWorkoutHeader.Controls.Add(this.panel13);
            this.panelWorkoutHeader.Controls.Add(this.btnAddWorkout);
            this.panelWorkoutHeader.Controls.Add(this.pictureBoxClose);
            this.panelWorkoutHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorkoutHeader.Location = new System.Drawing.Point(0, 0);
            this.panelWorkoutHeader.Name = "panelWorkoutHeader";
            this.panelWorkoutHeader.Size = new System.Drawing.Size(1150, 74);
            this.panelWorkoutHeader.TabIndex = 3;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::FitnessTracker.Properties.Resources.minus;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1086, 6);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 87;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // picborkoutClearFilter
            // 
            this.picborkoutClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picborkoutClearFilter.Image = global::FitnessTracker.Properties.Resources.clear_filter;
            this.picborkoutClearFilter.Location = new System.Drawing.Point(843, 25);
            this.picborkoutClearFilter.Name = "picborkoutClearFilter";
            this.picborkoutClearFilter.Size = new System.Drawing.Size(28, 28);
            this.picborkoutClearFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picborkoutClearFilter.TabIndex = 86;
            this.picborkoutClearFilter.TabStop = false;
            this.picborkoutClearFilter.Click += new System.EventHandler(this.picbWorkoutClearFilter_Click);
            // 
            // pictureBoxVehicleFilter
            // 
            this.pictureBoxVehicleFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVehicleFilter.Image = global::FitnessTracker.Properties.Resources.filter;
            this.pictureBoxVehicleFilter.Location = new System.Drawing.Point(802, 26);
            this.pictureBoxVehicleFilter.Name = "pictureBoxVehicleFilter";
            this.pictureBoxVehicleFilter.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxVehicleFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVehicleFilter.TabIndex = 85;
            this.pictureBoxVehicleFilter.TabStop = false;
            this.pictureBoxVehicleFilter.Click += new System.EventHandler(this.picbWorkoutFilter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(564, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Weight";
            // 
            // txtYomSearch
            // 
            this.txtYomSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtYomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYomSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYomSearch.Location = new System.Drawing.Point(628, 26);
            this.txtYomSearch.Multiline = true;
            this.txtYomSearch.Name = "txtYomSearch";
            this.txtYomSearch.Size = new System.Drawing.Size(143, 23);
            this.txtYomSearch.TabIndex = 83;
            this.txtYomSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYomSearch_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel11.Location = new System.Drawing.Point(565, 55);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(210, 1);
            this.panel11.TabIndex = 82;
            // 
            // cmbVehicleConditionSearch
            // 
            this.cmbVehicleConditionSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cmbVehicleConditionSearch.FormattingEnabled = true;
            this.cmbVehicleConditionSearch.Location = new System.Drawing.Point(397, 27);
            this.cmbVehicleConditionSearch.Name = "cmbVehicleConditionSearch";
            this.cmbVehicleConditionSearch.Size = new System.Drawing.Size(117, 23);
            this.cmbVehicleConditionSearch.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(304, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 79;
            // 
            // cmbWorkoutTypeSearch
            // 
            this.cmbWorkoutTypeSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cmbWorkoutTypeSearch.FormattingEnabled = true;
            this.cmbWorkoutTypeSearch.Location = new System.Drawing.Point(143, 27);
            this.cmbWorkoutTypeSearch.Name = "cmbWorkoutTypeSearch";
            this.cmbWorkoutTypeSearch.Size = new System.Drawing.Size(130, 23);
            this.cmbWorkoutTypeSearch.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(35, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 77;
            this.label12.Text = "Workout Type";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel13.Location = new System.Drawing.Point(39, 55);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(235, 1);
            this.panel13.TabIndex = 76;
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnAddWorkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWorkout.FlatAppearance.BorderSize = 0;
            this.btnAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkout.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddWorkout.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkout.Location = new System.Drawing.Point(942, 27);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(122, 33);
            this.btnAddWorkout.TabIndex = 75;
            this.btnAddWorkout.Text = "Log Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = false;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnLogWorkout_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::FitnessTracker.Properties.Resources.icons8_close_128;
            this.pictureBoxClose.Location = new System.Drawing.Point(1118, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // flowLayoutPanelWorkoutList
            // 
            this.flowLayoutPanelWorkoutList.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelWorkoutList.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanelWorkoutList.Name = "flowLayoutPanelWorkoutList";
            this.flowLayoutPanelWorkoutList.Size = new System.Drawing.Size(1150, 586);
            this.flowLayoutPanelWorkoutList.TabIndex = 0;
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.panelWorkoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkoutForm";
            this.Text = "VehicleForm";
            this.panelWorkoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panelWorkoutHeader.ResumeLayout(false);
            this.panelWorkoutHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picborkoutClearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWorkoutMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWorkoutList;
        private System.Windows.Forms.Panel panelWorkoutHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.ComboBox cmbWorkoutTypeSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cmbVehicleConditionSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYomSearch;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBoxVehicleFilter;
        private System.Windows.Forms.PictureBox picborkoutClearFilter;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}