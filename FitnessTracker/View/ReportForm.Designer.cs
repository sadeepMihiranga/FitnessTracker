namespace FitnessTracker.View
{
    partial class ReportForm
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
            this.panelAddVehicleMain = new System.Windows.Forms.Panel();
            this.panelReportsHeader = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.lblManageVehicleTitle = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelReprots = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDownloadCheatMealReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheatMealTo = new System.Windows.Forms.DateTimePicker();
            this.dtpCheatMealFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panelWorkoutReport = new System.Windows.Forms.Panel();
            this.btnDownloadWorkoutReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpWorkoutTo = new System.Windows.Forms.DateTimePicker();
            this.dtpWorkoutFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddVehicleMain.SuspendLayout();
            this.panelReportsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelReprots.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelWorkoutReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddVehicleMain
            // 
            this.panelAddVehicleMain.BackColor = System.Drawing.Color.White;
            this.panelAddVehicleMain.Controls.Add(this.panelReportsHeader);
            this.panelAddVehicleMain.Controls.Add(this.panelReprots);
            this.panelAddVehicleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddVehicleMain.Location = new System.Drawing.Point(0, 0);
            this.panelAddVehicleMain.Name = "panelAddVehicleMain";
            this.panelAddVehicleMain.Size = new System.Drawing.Size(1150, 729);
            this.panelAddVehicleMain.TabIndex = 0;
            // 
            // panelReportsHeader
            // 
            this.panelReportsHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelReportsHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelReportsHeader.Controls.Add(this.lblManageVehicleTitle);
            this.panelReportsHeader.Controls.Add(this.pictureBoxClose);
            this.panelReportsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReportsHeader.Name = "panelReportsHeader";
            this.panelReportsHeader.Size = new System.Drawing.Size(1150, 77);
            this.panelReportsHeader.TabIndex = 2;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::FitnessTracker.Properties.Resources.minus;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1086, 6);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 88;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // lblManageVehicleTitle
            // 
            this.lblManageVehicleTitle.AutoSize = true;
            this.lblManageVehicleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblManageVehicleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblManageVehicleTitle.Location = new System.Drawing.Point(12, 25);
            this.lblManageVehicleTitle.Name = "lblManageVehicleTitle";
            this.lblManageVehicleTitle.Size = new System.Drawing.Size(90, 30);
            this.lblManageVehicleTitle.TabIndex = 11;
            this.lblManageVehicleTitle.Text = "Reports";
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
            // panelReprots
            // 
            this.panelReprots.BackColor = System.Drawing.Color.White;
            this.panelReprots.Controls.Add(this.panel2);
            this.panelReprots.Controls.Add(this.panelWorkoutReport);
            this.panelReprots.Controls.Add(this.panel1);
            this.panelReprots.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReprots.Location = new System.Drawing.Point(0, 77);
            this.panelReprots.Name = "panelReprots";
            this.panelReprots.Size = new System.Drawing.Size(1150, 652);
            this.panelReprots.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDownloadCheatMealReport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpCheatMealTo);
            this.panel2.Controls.Add(this.dtpCheatMealFrom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(388, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 461);
            this.panel2.TabIndex = 82;
            // 
            // btnDownloadCheatMealReport
            // 
            this.btnDownloadCheatMealReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnDownloadCheatMealReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadCheatMealReport.FlatAppearance.BorderSize = 0;
            this.btnDownloadCheatMealReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadCheatMealReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownloadCheatMealReport.ForeColor = System.Drawing.Color.White;
            this.btnDownloadCheatMealReport.Location = new System.Drawing.Point(78, 399);
            this.btnDownloadCheatMealReport.Name = "btnDownloadCheatMealReport";
            this.btnDownloadCheatMealReport.Size = new System.Drawing.Size(122, 33);
            this.btnDownloadCheatMealReport.TabIndex = 83;
            this.btnDownloadCheatMealReport.Text = "Download";
            this.btnDownloadCheatMealReport.UseVisualStyleBackColor = false;
            this.btnDownloadCheatMealReport.Click += new System.EventHandler(this.btnDownloadCheatMealReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(37, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Cheat Meal Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "From";
            // 
            // dtpCheatMealTo
            // 
            this.dtpCheatMealTo.Location = new System.Drawing.Point(121, 131);
            this.dtpCheatMealTo.Name = "dtpCheatMealTo";
            this.dtpCheatMealTo.Size = new System.Drawing.Size(124, 23);
            this.dtpCheatMealTo.TabIndex = 80;
            // 
            // dtpCheatMealFrom
            // 
            this.dtpCheatMealFrom.Location = new System.Drawing.Point(121, 82);
            this.dtpCheatMealFrom.Name = "dtpCheatMealFrom";
            this.dtpCheatMealFrom.Size = new System.Drawing.Size(124, 23);
            this.dtpCheatMealFrom.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "To";
            // 
            // panelWorkoutReport
            // 
            this.panelWorkoutReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkoutReport.Controls.Add(this.btnDownloadWorkoutReport);
            this.panelWorkoutReport.Controls.Add(this.label1);
            this.panelWorkoutReport.Controls.Add(this.label4);
            this.panelWorkoutReport.Controls.Add(this.dtpWorkoutTo);
            this.panelWorkoutReport.Controls.Add(this.dtpWorkoutFrom);
            this.panelWorkoutReport.Controls.Add(this.label6);
            this.panelWorkoutReport.Location = new System.Drawing.Point(79, 91);
            this.panelWorkoutReport.Name = "panelWorkoutReport";
            this.panelWorkoutReport.Size = new System.Drawing.Size(283, 461);
            this.panelWorkoutReport.TabIndex = 81;
            // 
            // btnDownloadWorkoutReport
            // 
            this.btnDownloadWorkoutReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnDownloadWorkoutReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadWorkoutReport.FlatAppearance.BorderSize = 0;
            this.btnDownloadWorkoutReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadWorkoutReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownloadWorkoutReport.ForeColor = System.Drawing.Color.White;
            this.btnDownloadWorkoutReport.Location = new System.Drawing.Point(80, 399);
            this.btnDownloadWorkoutReport.Name = "btnDownloadWorkoutReport";
            this.btnDownloadWorkoutReport.Size = new System.Drawing.Size(122, 33);
            this.btnDownloadWorkoutReport.TabIndex = 82;
            this.btnDownloadWorkoutReport.Text = "Download";
            this.btnDownloadWorkoutReport.UseVisualStyleBackColor = false;
            this.btnDownloadWorkoutReport.Click += new System.EventHandler(this.btnDownloadWorkoutReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 81;
            this.label1.Text = "Workout Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "From";
            // 
            // dtpWorkoutTo
            // 
            this.dtpWorkoutTo.Location = new System.Drawing.Point(121, 131);
            this.dtpWorkoutTo.Name = "dtpWorkoutTo";
            this.dtpWorkoutTo.Size = new System.Drawing.Size(124, 23);
            this.dtpWorkoutTo.TabIndex = 80;
            // 
            // dtpWorkoutFrom
            // 
            this.dtpWorkoutFrom.Location = new System.Drawing.Point(121, 82);
            this.dtpWorkoutFrom.Name = "dtpWorkoutFrom";
            this.dtpWorkoutFrom.Size = new System.Drawing.Size(124, 23);
            this.dtpWorkoutFrom.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 5);
            this.panel1.TabIndex = 3;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.panelAddVehicleMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.panelAddVehicleMain.ResumeLayout(false);
            this.panelReportsHeader.ResumeLayout(false);
            this.panelReportsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelReprots.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelWorkoutReport.ResumeLayout(false);
            this.panelWorkoutReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddVehicleMain;
        private System.Windows.Forms.Panel panelReprots;
        private System.Windows.Forms.Panel panelReportsHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblManageVehicleTitle;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private DateTimePicker dtpWorkoutTo;
        private DateTimePicker dtpWorkoutFrom;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheatMealTo;
        private DateTimePicker dtpCheatMealFrom;
        private Label label5;
        private Panel panelWorkoutReport;
        private Label label1;
        private Button btnDownloadCheatMealReport;
        private Button btnDownloadWorkoutReport;
    }
}