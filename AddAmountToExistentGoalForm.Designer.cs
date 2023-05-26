namespace BudgetManager
{
    partial class AddAmountToExistentGoalForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGoalName = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.AddAmountToGoal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxGoalName
            // 
            this.textBoxGoalName.Location = new System.Drawing.Point(346, 164);
            this.textBoxGoalName.Name = "textBoxGoalName";
            this.textBoxGoalName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGoalName.TabIndex = 2;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(346, 221);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 3;
            // 
            // AddAmountToGoal
            // 
            this.AddAmountToGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAmountToGoal.Location = new System.Drawing.Point(258, 278);
            this.AddAmountToGoal.Name = "AddAmountToGoal";
            this.AddAmountToGoal.Size = new System.Drawing.Size(175, 34);
            this.AddAmountToGoal.TabIndex = 4;
            this.AddAmountToGoal.Text = "Add Amount to Goal!";
            this.AddAmountToGoal.UseVisualStyleBackColor = true;
            this.AddAmountToGoal.Click += new System.EventHandler(this.AddAmountToGoal_Click);
            // 
            // AddAmountToExistentGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAmountToGoal);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxGoalName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAmountToExistentGoalForm";
            this.Text = "AddAmountToExistentGoalForm";
            this.Load += new System.EventHandler(this.AddAmountToExistentGoalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGoalName;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button AddAmountToGoal;
    }
}