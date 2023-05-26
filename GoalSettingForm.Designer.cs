namespace BudgetManager
{
    partial class GoalSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGoalName = new System.Windows.Forms.TextBox();
            this.textBoxTargetAmount = new System.Windows.Forms.TextBox();
            this.textBoxAdditionalNotes = new System.Windows.Forms.TextBox();
            this.AddGoal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAmountNOw = new System.Windows.Forms.TextBox();
            this.dateTimePickerTargetDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Target date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Additional notes:";
            // 
            // textBoxGoalName
            // 
            this.textBoxGoalName.Location = new System.Drawing.Point(217, 60);
            this.textBoxGoalName.Name = "textBoxGoalName";
            this.textBoxGoalName.Size = new System.Drawing.Size(119, 20);
            this.textBoxGoalName.TabIndex = 7;
            // 
            // textBoxTargetAmount
            // 
            this.textBoxTargetAmount.Location = new System.Drawing.Point(217, 102);
            this.textBoxTargetAmount.Name = "textBoxTargetAmount";
            this.textBoxTargetAmount.Size = new System.Drawing.Size(119, 20);
            this.textBoxTargetAmount.TabIndex = 8;
            // 
            // textBoxAdditionalNotes
            // 
            this.textBoxAdditionalNotes.Location = new System.Drawing.Point(217, 240);
            this.textBoxAdditionalNotes.Name = "textBoxAdditionalNotes";
            this.textBoxAdditionalNotes.Size = new System.Drawing.Size(119, 20);
            this.textBoxAdditionalNotes.TabIndex = 10;
            // 
            // AddGoal
            // 
            this.AddGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGoal.Location = new System.Drawing.Point(113, 295);
            this.AddGoal.Name = "AddGoal";
            this.AddGoal.Size = new System.Drawing.Size(174, 30);
            this.AddGoal.TabIndex = 11;
            this.AddGoal.Text = "Add Goal!";
            this.AddGoal.UseVisualStyleBackColor = true;
            this.AddGoal.Click += new System.EventHandler(this.CreateGoal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount now:";
            // 
            // textBoxAmountNOw
            // 
            this.textBoxAmountNOw.Location = new System.Drawing.Point(217, 145);
            this.textBoxAmountNOw.Name = "textBoxAmountNOw";
            this.textBoxAmountNOw.Size = new System.Drawing.Size(119, 20);
            this.textBoxAmountNOw.TabIndex = 13;
            // 
            // dateTimePickerTargetDate
            // 
            this.dateTimePickerTargetDate.Location = new System.Drawing.Point(182, 189);
            this.dateTimePickerTargetDate.Name = "dateTimePickerTargetDate";
            this.dateTimePickerTargetDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerTargetDate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "OR";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 105);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Money to an existing GOAL!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerTargetDate);
            this.Controls.Add(this.textBoxAmountNOw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddGoal);
            this.Controls.Add(this.textBoxAdditionalNotes);
            this.Controls.Add(this.textBoxTargetAmount);
            this.Controls.Add(this.textBoxGoalName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GoalSettingForm";
            this.Text = "GoalSettingForm";
            this.Load += new System.EventHandler(this.GoalSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGoalName;
        private System.Windows.Forms.TextBox textBoxTargetAmount;
        private System.Windows.Forms.TextBox textBoxAdditionalNotes;
        private System.Windows.Forms.Button AddGoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAmountNOw;
        private System.Windows.Forms.DateTimePicker dateTimePickerTargetDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}