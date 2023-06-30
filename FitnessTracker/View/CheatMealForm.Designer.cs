namespace FitnessTracker.View
{
    partial class CheatMealForm
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
            this.panelCheatMealHeader = new System.Windows.Forms.Panel();
            this.cmbPortionSize = new System.Windows.Forms.ComboBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picbCheatMealClearFilter = new System.Windows.Forms.PictureBox();
            this.picbCheatMealFilter = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbReasonTakenSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbMealTypeSearch = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnAddCheatMeal = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelMealList = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelWorkoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelCheatMealHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCheatMealClearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCheatMealFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.flowLayoutPanelMealList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkoutMain
            // 
            this.panelWorkoutMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelWorkoutMain.Controls.Add(this.panel1);
            this.panelWorkoutMain.Controls.Add(this.pictureBoxNext);
            this.panelWorkoutMain.Controls.Add(this.pictureBoxBack);
            this.panelWorkoutMain.Controls.Add(this.panelCheatMealHeader);
            this.panelWorkoutMain.Controls.Add(this.flowLayoutPanelMealList);
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
            // panelCheatMealHeader
            // 
            this.panelCheatMealHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelCheatMealHeader.Controls.Add(this.cmbPortionSize);
            this.panelCheatMealHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelCheatMealHeader.Controls.Add(this.picbCheatMealClearFilter);
            this.panelCheatMealHeader.Controls.Add(this.picbCheatMealFilter);
            this.panelCheatMealHeader.Controls.Add(this.label10);
            this.panelCheatMealHeader.Controls.Add(this.panel11);
            this.panelCheatMealHeader.Controls.Add(this.cmbReasonTakenSearch);
            this.panelCheatMealHeader.Controls.Add(this.label1);
            this.panelCheatMealHeader.Controls.Add(this.panel2);
            this.panelCheatMealHeader.Controls.Add(this.cmbMealTypeSearch);
            this.panelCheatMealHeader.Controls.Add(this.label12);
            this.panelCheatMealHeader.Controls.Add(this.panel13);
            this.panelCheatMealHeader.Controls.Add(this.btnAddCheatMeal);
            this.panelCheatMealHeader.Controls.Add(this.pictureBoxClose);
            this.panelCheatMealHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCheatMealHeader.Location = new System.Drawing.Point(0, 0);
            this.panelCheatMealHeader.Name = "panelCheatMealHeader";
            this.panelCheatMealHeader.Size = new System.Drawing.Size(1150, 74);
            this.panelCheatMealHeader.TabIndex = 3;
            // 
            // cmbPortionSize
            // 
            this.cmbPortionSize.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPortionSize.FormattingEnabled = true;
            this.cmbPortionSize.Location = new System.Drawing.Point(669, 27);
            this.cmbPortionSize.Name = "cmbPortionSize";
            this.cmbPortionSize.Size = new System.Drawing.Size(106, 23);
            this.cmbPortionSize.TabIndex = 88;
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
            // picbCheatMealClearFilter
            // 
            this.picbCheatMealClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbCheatMealClearFilter.Image = global::FitnessTracker.Properties.Resources.clear_filter;
            this.picbCheatMealClearFilter.Location = new System.Drawing.Point(843, 25);
            this.picbCheatMealClearFilter.Name = "picbCheatMealClearFilter";
            this.picbCheatMealClearFilter.Size = new System.Drawing.Size(28, 28);
            this.picbCheatMealClearFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbCheatMealClearFilter.TabIndex = 86;
            this.picbCheatMealClearFilter.TabStop = false;
            this.picbCheatMealClearFilter.Click += new System.EventHandler(this.picbWorkoutClearFilter_Click);
            // 
            // picbCheatMealFilter
            // 
            this.picbCheatMealFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbCheatMealFilter.Image = global::FitnessTracker.Properties.Resources.filter;
            this.picbCheatMealFilter.Location = new System.Drawing.Point(802, 26);
            this.picbCheatMealFilter.Name = "picbCheatMealFilter";
            this.picbCheatMealFilter.Size = new System.Drawing.Size(25, 25);
            this.picbCheatMealFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbCheatMealFilter.TabIndex = 85;
            this.picbCheatMealFilter.TabStop = false;
            this.picbCheatMealFilter.Click += new System.EventHandler(this.picbWorkoutFilter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(564, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Portion Size";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel11.Location = new System.Drawing.Point(565, 55);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(210, 1);
            this.panel11.TabIndex = 82;
            // 
            // cmbReasonTakenSearch
            // 
            this.cmbReasonTakenSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cmbReasonTakenSearch.FormattingEnabled = true;
            this.cmbReasonTakenSearch.Location = new System.Drawing.Point(399, 27);
            this.cmbReasonTakenSearch.Name = "cmbReasonTakenSearch";
            this.cmbReasonTakenSearch.Size = new System.Drawing.Size(117, 23);
            this.cmbReasonTakenSearch.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Reason Taken";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(289, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 79;
            // 
            // cmbMealTypeSearch
            // 
            this.cmbMealTypeSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMealTypeSearch.FormattingEnabled = true;
            this.cmbMealTypeSearch.Location = new System.Drawing.Point(121, 27);
            this.cmbMealTypeSearch.Name = "cmbMealTypeSearch";
            this.cmbMealTypeSearch.Size = new System.Drawing.Size(130, 23);
            this.cmbMealTypeSearch.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(36, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 77;
            this.label12.Text = "Meal Type";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel13.Location = new System.Drawing.Point(39, 55);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(215, 1);
            this.panel13.TabIndex = 76;
            // 
            // btnAddCheatMeal
            // 
            this.btnAddCheatMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnAddCheatMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCheatMeal.FlatAppearance.BorderSize = 0;
            this.btnAddCheatMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCheatMeal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCheatMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddCheatMeal.Location = new System.Drawing.Point(924, 27);
            this.btnAddCheatMeal.Name = "btnAddCheatMeal";
            this.btnAddCheatMeal.Size = new System.Drawing.Size(140, 33);
            this.btnAddCheatMeal.TabIndex = 75;
            this.btnAddCheatMeal.Text = "Log Cheat Meal";
            this.btnAddCheatMeal.UseVisualStyleBackColor = false;
            this.btnAddCheatMeal.Click += new System.EventHandler(this.btnLogWorkout_Click);
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
            // flowLayoutPanelMealList
            // 
            this.flowLayoutPanelMealList.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelMealList.Controls.Add(this.checkBox1);
            this.flowLayoutPanelMealList.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanelMealList.Name = "flowLayoutPanelMealList";
            this.flowLayoutPanelMealList.Size = new System.Drawing.Size(1150, 586);
            this.flowLayoutPanelMealList.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CheatMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.panelWorkoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheatMealForm";
            this.Text = "CheatMealForm";
            this.panelWorkoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panelCheatMealHeader.ResumeLayout(false);
            this.panelCheatMealHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCheatMealClearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCheatMealFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.flowLayoutPanelMealList.ResumeLayout(false);
            this.flowLayoutPanelMealList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWorkoutMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMealList;
        private System.Windows.Forms.Panel panelCheatMealHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCheatMeal;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.ComboBox cmbMealTypeSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cmbReasonTakenSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox picbCheatMealFilter;
        private System.Windows.Forms.PictureBox picbCheatMealClearFilter;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private ComboBox cmbPortionSize;
        private CheckBox checkBox1;
    }
}