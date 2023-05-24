using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace BudgetManager
{
    public partial class AddIncomeForm : Form
    {
        public AddIncomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ADDIncome_Click(object sender, EventArgs e)
        {
            // Get the active workbook
            Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            // Get the active worksheet
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Check if it's the first time adding values
            if (worksheet.Cells[1, 1].Value == null)
            {
                // Write the headers
                worksheet.Cells[1, 1].Value = "Category";
                worksheet.Cells[1, 2].Value = "Amount ($)";
                worksheet.Cells[1, 3].Value = "Date";
                worksheet.Cells[1, 4].Value = "Description";
                worksheet.Cells[1, 6].Value = "Cash Left";
            }

            // Get the last used row in the worksheet
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            // Get the expense details from the form fields
            string category = textBoxCateg.Text;
            decimal amount = decimal.Parse(textBoxAmount.Text);
            DateTime date = dateIncomePicker.Value;
            string description = textBoxDesc.Text;

            // Write the expense details to the worksheet
            worksheet.Cells[lastRow + 1, 1].Value = category;
            worksheet.Cells[lastRow + 1, 2].Value = amount;
            worksheet.Cells[lastRow + 1, 3].Value = date;
            worksheet.Cells[lastRow + 1, 4].Value = description;
            worksheet.Cells[lastRow + 1, 5].Value = "Income";
            worksheet.Cells[2, 6].Value = GlobalVariables.CashLeft += amount;

            // Clear the form fields
            textBoxCateg.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
            dateIncomePicker.Value = DateTime.Now;
            textBoxDesc.Text = string.Empty;

            // Show a success message
            MessageBox.Show("Income added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
