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
    public partial class GoalSettingForm : Form
    {
        public GoalSettingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GoalSettingForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateGoal_Click(object sender, EventArgs e)
        {
                // Validate input values
                if (string.IsNullOrEmpty(textBoxGoalName.Text) ||
                    string.IsNullOrEmpty(textBoxAdditionalNotes.Text))
                {
                    MessageBox.Show("Please enter all the required values.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method to prevent further processing
                }

                if (!decimal.TryParse(textBoxTargetAmount.Text, out decimal targetAmount) ||
                    !decimal.TryParse(textBoxAmountNOw.Text, out decimal amountNow))
                {
                    MessageBox.Show("Invalid target amount or amount now. Please enter valid numeric values.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method to prevent further processing
                }
                if (dateTimePickerTargetDate.Value <= DateTime.Today)
             {
                MessageBox.Show("Invalid target date. Please select a date in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method to prevent further processing
             }
                 if (amountNow > targetAmount)
            {
                MessageBox.Show("Amount Now cannot be higher than the Target Amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method to prevent further processing
            }

            // Create a new instance of the Goals class and populate its properties
            Goals goal = new Goals(textBoxGoalName.Text,targetAmount,amountNow,dateTimePickerTargetDate.Value,textBoxAdditionalNotes.Text);

                // Add the goal to the list of goals in GlobalVariables
                GlobalVariables.listGoals.Add(goal);

                // Get the active workbook
                Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

                // Get the Goals sheet or create a new one if it doesn't exist
                Excel.Worksheet goalsWorksheet = null;
            try
            {
                goalsWorksheet = workbook.Sheets["Goals"] as Excel.Worksheet;
            }
            catch (Exception)
            {
                // Sheet doesn't exist, create a new one
            }

            if (goalsWorksheet == null)
            {
                // Create a new worksheet for the goals
                goalsWorksheet = workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
                goalsWorksheet.Name = "Goals";

                // Write the header row
                goalsWorksheet.Cells[1, 1].Value = "Goal Name";
                goalsWorksheet.Cells[1, 2].Value = "Target Amount";
                goalsWorksheet.Cells[1, 3].Value = "Amount Now";
                goalsWorksheet.Cells[1, 4].Value = "Deadline";
                goalsWorksheet.Cells[1, 5].Value = "Additional Notes";
                goalsWorksheet.Cells[1, 6].Value = "Progress";
            }
            else
            {
                // Activate the existing "Goals" sheet
                goalsWorksheet.Activate();
            }

            // Determine the row to start writing the goal details
            int startRow = goalsWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;

                // Write the goal details to the worksheet
                goalsWorksheet.Cells[startRow, 1].Value = goal.GoalName;
                goalsWorksheet.Cells[startRow, 2].Value = goal.TargetAmount;
                goalsWorksheet.Cells[startRow, 3].Value = goal.AmountNow;
                goalsWorksheet.Cells[startRow, 4].Value = goal.dateDeadline;
                goalsWorksheet.Cells[startRow, 5].Value = goal.AdditionalNotes;
                goalsWorksheet.Cells[startRow, 6].Value = goal.GoalProgress + "%";

            // Save the workbook
            workbook.Save();

            // Clear the form fields
            textBoxGoalName.Text = string.Empty;
            textBoxTargetAmount.Text = string.Empty;
            textBoxAmountNOw.Text = string.Empty;
            dateTimePickerTargetDate.Value = DateTime.Now;
            textBoxAdditionalNotes.Text = string.Empty;

            // Show a success message
            MessageBox.Show("Goal added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAmountToExistentGoalForm addAmountToExistentGoalForm = new AddAmountToExistentGoalForm();
            addAmountToExistentGoalForm.ShowDialog();
        }
    }
}
