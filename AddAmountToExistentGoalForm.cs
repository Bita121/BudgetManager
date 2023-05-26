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
    public partial class AddAmountToExistentGoalForm : Form
    {
        public AddAmountToExistentGoalForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int FindGoalRow(Excel.Worksheet worksheet, string goalName)
{
    Excel.Range searchRange = worksheet.UsedRange;
    int lastRow = searchRange.Rows.Count;
    Excel.Range goalRange = searchRange.Columns[1]; // Assuming the goal names are in the first column

    for (int row = 1; row <= lastRow; row++)
    {
        Excel.Range cell = goalRange.Cells[row];
        if (cell.Value2 != null && cell.Value2.ToString() == goalName)
        {
            return row;
        }
    }

    return -1; // Goal not found
}

        private void AddAmountToGoal_Click(object sender, EventArgs e)
        {
            string goalName = textBoxGoalName.Text; // Get the goal name from a TextBox or any other input control

            // Find the goal in the list of goals based on its name
            Goals goal = GlobalVariables.listGoals.FirstOrDefault(g => g.GoalName == goalName);

            if (goal != null)
            {
                // Validate the input amount
                if (!decimal.TryParse(textBoxAmount.Text, out decimal amountToAdd) || amountToAdd <= 0)
                {
                    MessageBox.Show("Invalid amount to add. Please enter a valid positive numeric value.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method to prevent further processing
                }
                decimal newAmountNow = goal.AmountNow + amountToAdd;
                if (newAmountNow > goal.TargetAmount)
                {
                    MessageBox.Show("The resulting amount exceeds the target amount.\nYou can only add ", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the amount to the existing goal
                goal.AmountNow += amountToAdd;
                goal.GoalProgress = goal.AmountNow / goal.TargetAmount;

                // Get the active workbook
                Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

                // Get the Goals sheet
                Excel.Worksheet goalsWorksheet = workbook.Sheets["Goals"] as Excel.Worksheet;

                // Find the row that corresponds to the goal
                int goalRow = FindGoalRow(goalsWorksheet, goalName);

                if (goalRow != -1)
                {
                    // Update the goal details in the worksheet
                    goalsWorksheet.Cells[goalRow, 3].Value = goal.AmountNow;
                    goalsWorksheet.Cells[goalRow, 6].Value = goal.GoalProgress;

                    // Save the workbook
                    workbook.Save();

                    // Show a success message
                    MessageBox.Show("Amount added to the goal successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }
            else
                MessageBox.Show("The goal was not found!\nPlease look in the file and input an existing goal!", "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddAmountToExistentGoalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
