namespace BudgetManager
{
    partial class AddIncomeForm
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
            this.textBoxCateg = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.dateIncomePicker = new System.Windows.Forms.DateTimePicker();
            this.category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADDIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCateg
            // 
            this.textBoxCateg.Location = new System.Drawing.Point(313, 94);
            this.textBoxCateg.Name = "textBoxCateg";
            this.textBoxCateg.Size = new System.Drawing.Size(200, 20);
            this.textBoxCateg.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(313, 143);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 20);
            this.textBoxAmount.TabIndex = 1;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(313, 190);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 20);
            this.textBoxDesc.TabIndex = 2;
            // 
            // dateIncomePicker
            // 
            this.dateIncomePicker.Location = new System.Drawing.Point(313, 235);
            this.dateIncomePicker.Name = "dateIncomePicker";
            this.dateIncomePicker.Size = new System.Drawing.Size(200, 20);
            this.dateIncomePicker.TabIndex = 3;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(226, 94);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(81, 18);
            this.category.TabIndex = 4;
            this.category.Text = "Category:";
            this.category.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(208, 190);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(99, 18);
            this.Description.TabIndex = 9;
            this.Description.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount:";
            // 
            // ADDIncome
            // 
            this.ADDIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDIncome.Location = new System.Drawing.Point(313, 273);
            this.ADDIncome.Name = "ADDIncome";
            this.ADDIncome.Size = new System.Drawing.Size(200, 59);
            this.ADDIncome.TabIndex = 11;
            this.ADDIncome.Text = "Add Income";
            this.ADDIncome.UseVisualStyleBackColor = true;
            this.ADDIncome.Click += new System.EventHandler(this.ADDIncome_Click);
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ADDIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.category);
            this.Controls.Add(this.dateIncomePicker);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCateg);
            this.Name = "AddIncomeForm";
            this.Load += new System.EventHandler(this.AddIncomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCateg;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.DateTimePicker dateIncomePicker;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ADDIncome;
    }
}