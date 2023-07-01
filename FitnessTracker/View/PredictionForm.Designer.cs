namespace FitnessTracker.View
{
    partial class PredictionForm
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
            this.panelPredictionMain = new System.Windows.Forms.Panel();
            this.panelPrediction = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPredictionHeader = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelPredictionMain.SuspendLayout();
            this.panelPredictionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPredictionMain
            // 
            this.panelPredictionMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelPredictionMain.Controls.Add(this.panelPrediction);
            this.panelPredictionMain.Controls.Add(this.panel1);
            this.panelPredictionMain.Controls.Add(this.panelPredictionHeader);
            this.panelPredictionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPredictionMain.Location = new System.Drawing.Point(0, 0);
            this.panelPredictionMain.Name = "panelPredictionMain";
            this.panelPredictionMain.Size = new System.Drawing.Size(1150, 729);
            this.panelPredictionMain.TabIndex = 0;
            // 
            // panelPrediction
            // 
            this.panelPrediction.Location = new System.Drawing.Point(2, 86);
            this.panelPrediction.Name = "panelPrediction";
            this.panelPrediction.Size = new System.Drawing.Size(1148, 609);
            this.panelPrediction.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 5);
            this.panel1.TabIndex = 4;
            // 
            // panelPredictionHeader
            // 
            this.panelPredictionHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelPredictionHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelPredictionHeader.Controls.Add(this.label12);
            this.panelPredictionHeader.Controls.Add(this.pictureBoxClose);
            this.panelPredictionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPredictionHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPredictionHeader.Name = "panelPredictionHeader";
            this.panelPredictionHeader.Size = new System.Drawing.Size(1150, 74);
            this.panelPredictionHeader.TabIndex = 3;
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
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.label12.Location = new System.Drawing.Point(35, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 30);
            this.label12.TabIndex = 77;
            this.label12.Text = "Predictions";
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
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click_1);
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.panelPredictionMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PredictionForm";
            this.Text = "PredictionForm";
            this.panelPredictionMain.ResumeLayout(false);
            this.panelPredictionHeader.ResumeLayout(false);
            this.panelPredictionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPredictionMain;
        private System.Windows.Forms.Panel panelPredictionHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private Panel panelPrediction;
    }
}