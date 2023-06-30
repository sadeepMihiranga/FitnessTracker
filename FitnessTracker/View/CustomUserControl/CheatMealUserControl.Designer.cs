namespace FitnessTracker.View.CustomUserControl
{
    partial class CheatMealUserControl
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
            this.picBoxMealSatisfactionImage = new System.Windows.Forms.PictureBox();
            this.lblCheatMealType = new System.Windows.Forms.Label();
            this.lbleMealName = new System.Windows.Forms.Label();
            this.lblMealPortionSize = new System.Windows.Forms.Label();
            this.lblMealTakenDateTime = new System.Windows.Forms.Label();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.txtHiddenCheatMealId = new System.Windows.Forms.TextBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMealSatisfactionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxMealSatisfactionImage
            // 
            this.picBoxMealSatisfactionImage.Location = new System.Drawing.Point(20, 19);
            this.picBoxMealSatisfactionImage.Name = "picBoxMealSatisfactionImage";
            this.picBoxMealSatisfactionImage.Size = new System.Drawing.Size(87, 72);
            this.picBoxMealSatisfactionImage.TabIndex = 0;
            this.picBoxMealSatisfactionImage.TabStop = false;
            // 
            // lblCheatMealType
            // 
            this.lblCheatMealType.AutoSize = true;
            this.lblCheatMealType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheatMealType.Location = new System.Drawing.Point(131, 11);
            this.lblCheatMealType.Name = "lblCheatMealType";
            this.lblCheatMealType.Size = new System.Drawing.Size(131, 21);
            this.lblCheatMealType.TabIndex = 1;
            this.lblCheatMealType.Text = "Cheat Meal Type";
            // 
            // lbleMealName
            // 
            this.lbleMealName.AutoSize = true;
            this.lbleMealName.Location = new System.Drawing.Point(133, 48);
            this.lbleMealName.Name = "lbleMealName";
            this.lbleMealName.Size = new System.Drawing.Size(100, 15);
            this.lbleMealName.TabIndex = 2;
            this.lbleMealName.Text = "Cheat meal name";
            // 
            // lblMealPortionSize
            // 
            this.lblMealPortionSize.AutoSize = true;
            this.lblMealPortionSize.Location = new System.Drawing.Point(133, 81);
            this.lblMealPortionSize.Name = "lblMealPortionSize";
            this.lblMealPortionSize.Size = new System.Drawing.Size(94, 15);
            this.lblMealPortionSize.TabIndex = 3;
            this.lblMealPortionSize.Text = "Medium Portion";
            // 
            // lblMealTakenDateTime
            // 
            this.lblMealTakenDateTime.AutoSize = true;
            this.lblMealTakenDateTime.Location = new System.Drawing.Point(250, 82);
            this.lblMealTakenDateTime.Name = "lblMealTakenDateTime";
            this.lblMealTakenDateTime.Size = new System.Drawing.Size(125, 15);
            this.lblMealTakenDateTime.TabIndex = 4;
            this.lblMealTakenDateTime.Text = "6/23/2023 07:42:00 PM";
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
            // txtHiddenCheatMealId
            // 
            this.txtHiddenCheatMealId.Location = new System.Drawing.Point(315, 48);
            this.txtHiddenCheatMealId.Name = "txtHiddenCheatMealId";
            this.txtHiddenCheatMealId.Size = new System.Drawing.Size(56, 23);
            this.txtHiddenCheatMealId.TabIndex = 13;
            this.txtHiddenCheatMealId.Visible = false;
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
            // CheatMealUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.txtHiddenCheatMealId);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.lblMealTakenDateTime);
            this.Controls.Add(this.lblMealPortionSize);
            this.Controls.Add(this.lbleMealName);
            this.Controls.Add(this.lblCheatMealType);
            this.Controls.Add(this.picBoxMealSatisfactionImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CheatMealUserControl";
            this.Size = new System.Drawing.Size(377, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMealSatisfactionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxMealSatisfactionImage;
        private System.Windows.Forms.Label lblCheatMealType;
        private System.Windows.Forms.Label lbleMealName;
        private System.Windows.Forms.Label lblMealPortionSize;
        private System.Windows.Forms.Label lblMealTakenDateTime;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.TextBox txtHiddenCheatMealId;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
    }
}

