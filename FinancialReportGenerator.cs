using BudgetManager;
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

            // Save the Word document
            document.Save();

            // Close the Word document
            document.Close();

            // Quit the Word application
            wordApp.Quit();

            // Display a success message
            MessageBox.Show("Financial report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
