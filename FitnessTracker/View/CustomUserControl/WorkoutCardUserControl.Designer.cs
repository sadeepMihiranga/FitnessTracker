namespace FitnessTracker.View.CustomUserControl
{
    partial class WorkoutCardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxVehicleImage = new System.Windows.Forms.PictureBox();
            this.lblWorkoutType = new System.Windows.Forms.Label();
            this.lbleWeigth = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWorkoutDateTime = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.txtHiddenWorkoutId = new System.Windows.Forms.TextBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxVehicleImage
            // 
            this.picBoxVehicleImage.Location = new System.Drawing.Point(20, 19);
            this.picBoxVehicleImage.Name = "picBoxVehicleImage";
            this.picBoxVehicleImage.Size = new System.Drawing.Size(87, 72);
            this.picBoxVehicleImage.TabIndex = 0;
            this.picBoxVehicleImage.TabStop = false;
            // 
            // lblWorkoutType
            // 
            this.lblWorkoutType.AutoSize = true;
            this.lblWorkoutType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkoutType.Location = new System.Drawing.Point(131, 11);
            this.lblWorkoutType.Name = "lblWorkoutType";
            this.lblWorkoutType.Size = new System.Drawing.Size(113, 21);
            this.lblWorkoutType.TabIndex = 1;
            this.lblWorkoutType.Text = "Workout Type";
            // 
            // lbleWeigth
            // 
            this.lbleWeigth.AutoSize = true;
            this.lbleWeigth.Location = new System.Drawing.Point(133, 48);
            this.lbleWeigth.Name = "lbleWeigth";
            this.lbleWeigth.Size = new System.Drawing.Size(36, 15);
            this.lbleWeigth.TabIndex = 2;
            this.lbleWeigth.Text = "70 KG";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(133, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 15);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Rs 250,000";
            // 
            // lblWorkoutDateTime
            // 
            this.lblWorkoutDateTime.AutoSize = true;
            this.lblWorkoutDateTime.Location = new System.Drawing.Point(250, 82);
            this.lblWorkoutDateTime.Name = "lblWorkoutDateTime";
            this.lblWorkoutDateTime.Size = new System.Drawing.Size(46, 15);
            this.lblWorkoutDateTime.TabIndex = 4;
            this.lblWorkoutDateTime.Text = "5 hours";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::FitnessTracker.Properties.Resources.pen;
            this.pictureBoxEdit.Location = new System.Drawing.Point(317, 6);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEdit.TabIndex = 10;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxView.Image = global::FitnessTracker.Properties.Resources.eye;
            this.pictureBoxView.Location = new System.Drawing.Point(288, 6);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxView.TabIndex = 11;
            this.pictureBoxView.TabStop = false;
            this.pictureBoxView.Click += new System.EventHandler(this.pictureBoxView_Click);
            // 
            // txtHiddenWorkoutId
            // 
            this.txtHiddenWorkoutId.Location = new System.Drawing.Point(315, 48);
            this.txtHiddenWorkoutId.Name = "txtHiddenWorkoutId";
            this.txtHiddenWorkoutId.Size = new System.Drawing.Size(56, 23);
            this.txtHiddenWorkoutId.TabIndex = 13;
            this.txtHiddenWorkoutId.Visible = false;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::FitnessTracker.Properties.Resources.icons8_close_128;
            this.pictureBoxRemove.Location = new System.Drawing.Point(346, 6);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRemove.TabIndex = 14;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // WorkoutCardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.txtHiddenWorkoutId);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.lblWorkoutDateTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lbleWeigth);
            this.Controls.Add(this.lblWorkoutType);
            this.Controls.Add(this.picBoxVehicleImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "WorkoutCardUserControl";
            this.Size = new System.Drawing.Size(377, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxVehicleImage;
        private System.Windows.Forms.Label lblWorkoutType;
        private System.Windows.Forms.Label lbleWeigth;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWorkoutDateTime;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.TextBox txtHiddenWorkoutId;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
    }
}
