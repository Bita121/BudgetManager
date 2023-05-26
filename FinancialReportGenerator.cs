using BudgetManager;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace YourNamespace
{
    public class FinancialReportGenerator
    {
        public void GenerateFinancialReport()
        {
            // Get the Excel application instance
            Excel.Application excelApp = Globals.ThisAddIn.Application;

            // Get the active workbook
            Excel.Workbook workbook = excelApp.ActiveWorkbook;

            // Get the active worksheet
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Perform calculations or retrieve data from the active worksheet as needed

            // Create an instance of the Word application
            Word.Application wordApp = new Word.Application();

            // Create a new Word document
            Word.Document document = wordApp.Documents.Add();

            // Perform operations to populate the Word document with the financial report based on the data retrieved from Excel
            List<Incomes> incomes = GlobalVariables.listIncomes;
            List<Expenses> expenses = GlobalVariables.listExpenses;

            if (incomes.Count < 4 || expenses.Count < 4)
            {
                MessageBox.Show("At least 4 incomes and 4 expenses are required to generate the financial report.", "Insufficient Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the requirement is not met
            }
            // Calculate the total income
            decimal totalIncome = incomes.Sum(income => income.Amount);

            // Calculate the total expense
            decimal totalExpense = expenses.Sum(expense => expense.Amount);

            decimal netIncome = totalIncome - totalExpense;
            // Find the biggest income amount
            decimal maxIncomeAmount = incomes.Max(income => income.Amount);

            // Find the biggest expense amount
            decimal maxExpenseAmount = expenses.Max(expense => expense.Amount);
            // Output the incomes to the Word document
            Word.Paragraph totalIncomeParagraph = document.Content.Paragraphs.Add();
            totalIncomeParagraph.Range.Text = $"Total Income: {totalIncome}";
            totalIncomeParagraph.Range.InsertParagraphAfter();

            Word.Paragraph incomeParagraph = document.Content.Paragraphs.Add();
            incomeParagraph.Range.Text = "Income Report:";
            incomeParagraph.Range.InsertParagraphAfter();

            foreach (Incomes income in incomes)
            {
                Word.Paragraph incomeItemParagraph = document.Content.Paragraphs.Add();
                incomeItemParagraph.Range.Text = $"Category: {income.Category}, Amount: {income.Amount}, Date: {income.Date}, Description: {income.Description}";
                incomeItemParagraph.Range.InsertParagraphAfter();
            }

            Word.Paragraph biggestIncomeParagraph = document.Content.Paragraphs.Add();
            biggestIncomeParagraph.Range.Text = $"The Biggest Income: {maxIncomeAmount}";
            biggestIncomeParagraph.Range.InsertParagraphAfter();

            Word.Paragraph totalExpenseParagraph = document.Content.Paragraphs.Add();
            totalExpenseParagraph.Range.Text = $"Total Expense: {totalExpense}";
            totalExpenseParagraph.Range.InsertParagraphAfter();
            // Output the expenses to the Word document
            Word.Paragraph expenseParagraph = document.Content.Paragraphs.Add();
            expenseParagraph.Range.Text = "Expense Report:";
            expenseParagraph.Range.InsertParagraphAfter();

            foreach (Expenses expense in expenses)
            {
                Word.Paragraph expenseItemParagraph = document.Content.Paragraphs.Add();
                expenseItemParagraph.Range.Text = $"Category: {expense.Category}, Amount: {expense.Amount}, Date: {expense.Date}, Description: {expense.Description}";
                expenseItemParagraph.Range.InsertParagraphAfter();
            }

            Word.Paragraph biggestExpenseParagraph = document.Content.Paragraphs.Add();
            biggestExpenseParagraph.Range.Text = $"The Biggest Expense: {maxExpenseAmount}";
            biggestExpenseParagraph.Range.InsertParagraphAfter();

            Word.Paragraph netIncomeParagraph = document.Content.Paragraphs.Add();
            netIncomeParagraph.Range.Text = $"Net Income: {netIncome}";
            netIncomeParagraph.Range.InsertParagraphAfter();

            // Save the Word document
            document.Save();

            

            // Display a success message
            MessageBox.Show("Financial report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
