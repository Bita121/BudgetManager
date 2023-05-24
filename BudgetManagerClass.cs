using System;
using System.Windows.Forms;

namespace BudgetManagerApp
{
    public partial class ExpenseTrackingForm : Form
    {
        // Data structure to store expense details
        private struct Expense
        {
            public string Category;
            public decimal Amount;
            public DateTime Date;
            public string Description;
        }

        // Collection to store all expenses
        private List<Expense> expenses;

        public ExpenseTrackingForm()
        {
            InitializeComponent();
            expenses = new List<Expense>();
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            // Validate user inputs
            if (string.IsNullOrEmpty(txtCategory.Text) ||
                !decimal.TryParse(txtAmount.Text, out decimal amount) ||
                !DateTime.TryParse(dtpDate.Text, out DateTime date) ||
                string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Invalid input. Please enter valid values for all fields.");
                return;
            }

            // Create a new expense object
            Expense newExpense = new Expense
            {
                Category = txtCategory.Text,
                Amount = amount,
                Date = date,
                Description = txtDescription.Text
            };

            // Add the expense to the collection
            expenses.Add(newExpense);

            // Clear input fields
            txtCategory.Text = string.Empty;
            txtAmount.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            txtDescription.Text = string.Empty;

            MessageBox.Show("Expense saved successfully.");
        }
    }
}
