namespace FitnessTracker.View
{
    partial class ManageCheatMealForm
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
            this.panelAddCheatMealHeader = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.lblManageCheatMealTitle = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelLogCheatMeal = new System.Windows.Forms.Panel();
            this.cmbReasonTaken = new System.Windows.Forms.ComboBox();
            this.cmbMealSatisfaction = new System.Windows.Forms.ComboBox();
            this.cmbPortionSize = new System.Windows.Forms.ComboBox();
            this.dtpMealTakeDate = new System.Windows.Forms.DateTimePicker();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearCheatMealInfo = new System.Windows.Forms.Button();
            this.btnSaveCheatMeal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddVehicleMain.SuspendLayout();
            this.panelAddCheatMealHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelLogCheatMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddVehicleMain
            // 
            this.panelAddVehicleMain.BackColor = System.Drawing.Color.White;
            this.panelAddVehicleMain.Controls.Add(this.panelAddCheatMealHeader);
            this.panelAddVehicleMain.Controls.Add(this.panelLogCheatMeal);
            this.panelAddVehicleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddVehicleMain.Location = new System.Drawing.Point(0, 0);
            this.panelAddVehicleMain.Name = "panelAddVehicleMain";
            this.panelAddVehicleMain.Size = new System.Drawing.Size(1150, 729);
            this.panelAddVehicleMain.TabIndex = 0;
            // 
            // panelAddCheatMealHeader
            // 
            this.panelAddCheatMealHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelAddCheatMealHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelAddCheatMealHeader.Controls.Add(this.lblManageCheatMealTitle);
            this.panelAddCheatMealHeader.Controls.Add(this.pictureBoxClose);
            this.panelAddCheatMealHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddCheatMealHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAddCheatMealHeader.Name = "panelAddCheatMealHeader";
            this.panelAddCheatMealHeader.Size = new System.Drawing.Size(1150, 77);
            this.panelAddCheatMealHeader.TabIndex = 2;
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
            // lblManageCheatMealTitle
            // 
            this.lblManageCheatMealTitle.AutoSize = true;
            this.lblManageCheatMealTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblManageCheatMealTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblManageCheatMealTitle.Location = new System.Drawing.Point(12, 25);
            this.lblManageCheatMealTitle.Name = "lblManageCheatMealTitle";
            this.lblManageCheatMealTitle.Size = new System.Drawing.Size(169, 30);
            this.lblManageCheatMealTitle.TabIndex = 11;
            this.lblManageCheatMealTitle.Text = "Log Cheat Meal";
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
            // panelLogCheatMeal
            // 
            this.panelLogCheatMeal.BackColor = System.Drawing.Color.White;
            this.panelLogCheatMeal.Controls.Add(this.cmbReasonTaken);
            this.panelLogCheatMeal.Controls.Add(this.cmbMealSatisfaction);
            this.panelLogCheatMeal.Controls.Add(this.cmbPortionSize);
            this.panelLogCheatMeal.Controls.Add(this.dtpMealTakeDate);
            this.panelLogCheatMeal.Controls.Add(this.txtCalories);
            this.panelLogCheatMeal.Controls.Add(this.txtMealName);
            this.panelLogCheatMeal.Controls.Add(this.pictureBox1);
            this.panelLogCheatMeal.Controls.Add(this.btnClearCheatMealInfo);
            this.panelLogCheatMeal.Controls.Add(this.btnSaveCheatMeal);
            this.panelLogCheatMeal.Controls.Add(this.label12);
            this.panelLogCheatMeal.Controls.Add(this.panel13);
            this.panelLogCheatMeal.Controls.Add(this.label11);
            this.panelLogCheatMeal.Controls.Add(this.panel12);
            this.panelLogCheatMeal.Controls.Add(this.label6);
            this.panelLogCheatMeal.Controls.Add(this.panel8);
            this.panelLogCheatMeal.Controls.Add(this.label5);
            this.panelLogCheatMeal.Controls.Add(this.panel7);
            this.panelLogCheatMeal.Controls.Add(this.label4);
            this.panelLogCheatMeal.Controls.Add(this.panel5);
            this.panelLogCheatMeal.Controls.Add(this.label2);
            this.panelLogCheatMeal.Controls.Add(this.panel4);
            this.panelLogCheatMeal.Controls.Add(this.label3);
            this.panelLogCheatMeal.Controls.Add(this.txtComment);
            this.panelLogCheatMeal.Controls.Add(this.panel3);
            this.panelLogCheatMeal.Controls.Add(this.cmbMealType);
            this.panelLogCheatMeal.Controls.Add(this.label7);
            this.panelLogCheatMeal.Controls.Add(this.panel6);
            this.panelLogCheatMeal.Controls.Add(this.panel1);
            this.panelLogCheatMeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogCheatMeal.Location = new System.Drawing.Point(0, 77);
            this.panelLogCheatMeal.Name = "panelLogCheatMeal";
            this.panelLogCheatMeal.Size = new System.Drawing.Size(1150, 652);
            this.panelLogCheatMeal.TabIndex = 0;
            // 
            // cmbReasonTaken
            // 
            this.cmbReasonTaken.FormattingEnabled = true;
            this.cmbReasonTaken.Location = new System.Drawing.Point(985, 109);
            this.cmbReasonTaken.Name = "cmbReasonTaken";
            this.cmbReasonTaken.Size = new System.Drawing.Size(126, 23);
            this.cmbReasonTaken.TabIndex = 81;
            // 
            // cmbMealSatisfaction
            // 
            this.cmbMealSatisfaction.FormattingEnabled = true;
            this.cmbMealSatisfaction.Location = new System.Drawing.Point(723, 188);
            this.cmbMealSatisfaction.Name = "cmbMealSatisfaction";
            this.cmbMealSatisfaction.Size = new System.Drawing.Size(131, 23);
            this.cmbMealSatisfaction.TabIndex = 80;
            // 
            // cmbPortionSize
            // 
            this.cmbPortionSize.FormattingEnabled = true;
            this.cmbPortionSize.Location = new System.Drawing.Point(685, 108);
            this.cmbPortionSize.Name = "cmbPortionSize";
            this.cmbPortionSize.Size = new System.Drawing.Size(117, 23);
            this.cmbPortionSize.TabIndex = 79;
            // 
            // dtpMealTakeDate
            // 
            this.dtpMealTakeDate.Location = new System.Drawing.Point(360, 109);
            this.dtpMealTakeDate.Name = "dtpMealTakeDate";
            this.dtpMealTakeDate.Size = new System.Drawing.Size(152, 23);
            this.dtpMealTakeDate.TabIndex = 78;
            // 
            // txtCalories
            // 
            this.txtCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(368, 186);
            this.txtCalories.Multiline = true;
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(146, 23);
            this.txtCalories.TabIndex = 76;
            this.txtCalories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalories_KeyPress);
            // 
            // txtMealName
            // 
            this.txtMealName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMealName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMealName.Location = new System.Drawing.Point(359, 29);
            this.txtMealName.Multiline = true;
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(252, 23);
            this.txtMealName.TabIndex = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessTracker.Properties.Resources.healthy_living_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearCheatMealInfo
            // 
            this.btnClearCheatMealInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnClearCheatMealInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCheatMealInfo.FlatAppearance.BorderSize = 0;
            this.btnClearCheatMealInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCheatMealInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCheatMealInfo.ForeColor = System.Drawing.Color.White;
            this.btnClearCheatMealInfo.Location = new System.Drawing.Point(905, 598);
            this.btnClearCheatMealInfo.Name = "btnClearCheatMealInfo";
            this.btnClearCheatMealInfo.Size = new System.Drawing.Size(100, 33);
            this.btnClearCheatMealInfo.TabIndex = 73;
            this.btnClearCheatMealInfo.Text = "Clear";
            this.btnClearCheatMealInfo.UseVisualStyleBackColor = false;
            this.btnClearCheatMealInfo.Click += new System.EventHandler(this.btnClearCheatMealInfo_Click);
            // 
            // btnSaveCheatMeal
            // 
            this.btnSaveCheatMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnSaveCheatMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCheatMeal.FlatAppearance.BorderSize = 0;
            this.btnSaveCheatMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCheatMeal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCheatMeal.ForeColor = System.Drawing.Color.White;
            this.btnSaveCheatMeal.Location = new System.Drawing.Point(1029, 598);
            this.btnSaveCheatMeal.Name = "btnSaveCheatMeal";
            this.btnSaveCheatMeal.Size = new System.Drawing.Size(100, 33);
            this.btnSaveCheatMeal.TabIndex = 72;
            this.btnSaveCheatMeal.Text = "Save";
            this.btnSaveCheatMeal.UseVisualStyleBackColor = false;
            this.btnSaveCheatMeal.Click += new System.EventHandler(this.btnSaveCheatMeal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(303, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Name";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel13.Location = new System.Drawing.Point(301, 57);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(310, 1);
            this.panel13.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(592, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Meal Satisfaction";

            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel12.Location = new System.Drawing.Point(594, 217);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(260, 1);
            this.panel12.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(875, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Reason Taken";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel8.Location = new System.Drawing.Point(877, 137);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 1);
            this.panel8.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(304, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Calories";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel7.Location = new System.Drawing.Point(302, 214);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 1);
            this.panel7.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(594, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Portion Size";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel5.Location = new System.Drawing.Point(592, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 1);
            this.panel5.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(304, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(302, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 1);
            this.panel4.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(303, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComment.Location = new System.Drawing.Point(384, 273);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(731, 23);
            this.txtComment.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(301, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 1);
            this.panel3.TabIndex = 40;
            // 
            // cmbMealType
            // 
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(956, 29);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(155, 23);
            this.cmbMealType.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(871, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Meal Type";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel6.Location = new System.Drawing.Point(871, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 1);
            this.panel6.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 5);
            this.panel1.TabIndex = 3;
            // 
            // ManageCheatMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.panelAddVehicleMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCheatMealForm";
            this.Text = "ManageCheatMealForm";
            this.panelAddVehicleMain.ResumeLayout(false);
            this.panelAddCheatMealHeader.ResumeLayout(false);
            this.panelAddCheatMealHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelLogCheatMeal.ResumeLayout(false);
            this.panelLogCheatMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddVehicleMain;
        private System.Windows.Forms.Panel panelLogCheatMeal;
        private System.Windows.Forms.Panel panelAddCheatMealHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnClearCheatMealInfo;
        private System.Windows.Forms.Button btnSaveCheatMeal;
        private System.Windows.Forms.Label lblManageCheatMealTitle;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private PictureBox pictureBox1;
        private TextBox txtMealName;
        private TextBox txtCalories;
        private DateTimePicker dtpMealTakeDate;
        private ComboBox cmbMealSatisfaction;
        private ComboBox cmbPortionSize;
        private ComboBox cmbReasonTaken;
    }
}