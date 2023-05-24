namespace BudgetManager
{
    partial class AddExpenseForm
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
            this.dateExpensePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCateg = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.AddExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateExpensePicker
            // 
            this.dateExpensePicker.Location = new System.Drawing.Point(301, 228);
            this.dateExpensePicker.Name = "dateExpensePicker";
            this.dateExpensePicker.Size = new System.Drawing.Size(200, 20);
            this.dateExpensePicker.TabIndex = 0;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(301, 179);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 20);
            this.textBoxDesc.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(301, 137);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 20);
            this.textBoxAmount.TabIndex = 2;
            // 
            // textBoxCateg
            // 
            this.textBoxCateg.Location = new System.Drawing.Point(301, 89);
            this.textBoxCateg.Name = "textBoxCateg";
            this.textBoxCateg.Size = new System.Drawing.Size(200, 20);
            this.textBoxCateg.TabIndex = 3;
            this.textBoxCateg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(217, 89);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(81, 18);
            this.category.TabIndex = 4;
            this.category.Text = "Category:";
            this.category.Click += new System.EventHandler(this.label1_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(225, 137);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(70, 18);
            this.amount.TabIndex = 5;
            this.amount.Text = "Amount:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(196, 181);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(99, 18);
            this.Description.TabIndex = 6;
            this.Description.Text = "Description:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(247, 228);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 18);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date:";
            // 
            // AddExpense
            // 
            this.AddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.Location = new System.Drawing.Point(301, 282);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(200, 34);
            this.AddExpense.TabIndex = 8;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = true;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddExpense);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.category);
            this.Controls.Add(this.textBoxCateg);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.dateExpensePicker);
            this.Name = "AddExpenseForm";
            this.Text = "BudgetManagerApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateExpensePicker;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxCateg;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button AddExpense;
    }
}