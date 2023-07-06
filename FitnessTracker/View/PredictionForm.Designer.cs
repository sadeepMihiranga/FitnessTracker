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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPredictedHealthStatus = new System.Windows.Forms.Label();
            this.lblPredictedWeigth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFutureDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPredictionHeader = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelPredictionMain.SuspendLayout();
            this.panelPrediction.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelPrediction.Controls.Add(this.panel2);
            this.panelPrediction.Location = new System.Drawing.Point(2, 86);
            this.panelPrediction.Name = "panelPrediction";
            this.panelPrediction.Size = new System.Drawing.Size(1148, 609);
            this.panelPrediction.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPredictedHealthStatus);
            this.panel2.Controls.Add(this.lblPredictedWeigth);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPredict);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFutureDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(295, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 371);
            this.panel2.TabIndex = 0;
            // 
            // lblPredictedHealthStatus
            // 
            this.lblPredictedHealthStatus.AutoSize = true;
            this.lblPredictedHealthStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPredictedHealthStatus.ForeColor = System.Drawing.Color.Black;
            this.lblPredictedHealthStatus.Location = new System.Drawing.Point(294, 253);
            this.lblPredictedHealthStatus.Name = "lblPredictedHealthStatus";
            this.lblPredictedHealthStatus.Size = new System.Drawing.Size(67, 30);
            this.lblPredictedHealthStatus.TabIndex = 94;
            this.lblPredictedHealthStatus.Text = "Good";
            // 
            // lblPredictedWeigth
            // 
            this.lblPredictedWeigth.AutoSize = true;
            this.lblPredictedWeigth.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPredictedWeigth.ForeColor = System.Drawing.Color.Black;
            this.lblPredictedWeigth.Location = new System.Drawing.Point(236, 190);
            this.lblPredictedWeigth.Name = "lblPredictedWeigth";
            this.lblPredictedWeigth.Size = new System.Drawing.Size(70, 30);
            this.lblPredictedWeigth.TabIndex = 93;
            this.lblPredictedWeigth.Text = "70 KG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 30);
            this.label3.TabIndex = 92;
            this.label3.Text = "Predictied health status : ";
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnPredict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredict.FlatAppearance.BorderSize = 0;
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredict.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPredict.ForeColor = System.Drawing.Color.White;
            this.btnPredict.Location = new System.Drawing.Point(213, 95);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(91, 33);
            this.btnPredict.TabIndex = 91;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 90;
            this.label2.Text = "Predictied weight : ";
            // 
            // dtpFutureDate
            // 
            this.dtpFutureDate.Location = new System.Drawing.Point(282, 25);
            this.dtpFutureDate.Name = "dtpFutureDate";
            this.dtpFutureDate.Size = new System.Drawing.Size(200, 23);
            this.dtpFutureDate.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 88;
            this.label1.Text = "Select a future date :";
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
            this.panelPrediction.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtpFutureDate;
        private Label label1;
        private Button btnPredict;
        private Label label3;
        private Label lblPredictedHealthStatus;
        private Label lblPredictedWeigth;
    }
}