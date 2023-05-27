using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private bool GoalExists(Goals goal)
        {
            // Check if the goal already exists in the database
            using (var connection = new SQLiteConnection("Data Source=C:\\Program Files\\SQLiteStudio\\GoalsDB.db;Version=3;"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT COUNT(*) FROM Goals WHERE goal_name = @GoalName", connection))
                {
                    command.Parameters.AddWithValue("@GoalName", goal.GoalName);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private void UpdateGoalInDatabase(string goalName, decimal amountToAdd)
        {

            // Update the goal details in the database
            using (var connection = new SQLiteConnection("Data Source=C:\\Program Files\\SQLiteStudio\\GoalsDB.db;Version=3;"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("UPDATE Goals SET amount_now = amount_now + @AmountToAdd WHERE goal_name = @GoalName", connection))
                {
                    command.Parameters.AddWithValue("@AmountToAdd", amountToAdd);
                    command.Parameters.AddWithValue("@GoalName", goalName);

                    command.ExecuteNonQuery();
                }
                using (var command = new SQLiteCommand("UPDATE Goals SET goal_progress = (amount_now/target_amount * 100) WHERE goal_name = @GoalName", connection))
                {
                    
                    command.Parameters.AddWithValue("@GoalName", goalName);

                    command.ExecuteNonQuery();
                }
            }
        }
        private Goals GetGoalFromDatabase(string goalName)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Program Files\\SQLiteStudio\\GoalsDB.db;Version=3;"))
            {
                connection.Open();

                string query = "SELECT * FROM Goals WHERE goal_name = @GoalName";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GoalName", goalName);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Goals goal = new Goals();
                            goal.GoalName = reader.GetString(1);
                            goal.TargetAmount = reader.GetDecimal(2);
                            goal.AmountNow = reader.GetDecimal(3);
                            goal.dateDeadline = reader.GetDateTime(4);
                            goal.AdditionalNotes = reader.GetString(5);
                            goal.GoalProgress = reader.GetDecimal(6);

                            return goal;
                        }
                    }
                }
            }

            return null; // Return null if the goal was not found in the database
        }
        private void AddAmountToGoal_Click(object sender, EventArgs e)
        {
            string goalName = textBoxGoalName.Text; // Get the goal name from a TextBox or any other input control

            // Find the goal in the list of goals based on its name
           // Goals goal = GlobalVariables.listGoals.FirstOrDefault(g => g.GoalName == goalName);

            if (GetGoalFromDatabase(goalName)!=null)
            {
                Goals goal = GetGoalFromDatabase(goalName);
                // Validate the input amount
                if (!decimal.TryParse(textBoxAmount.Text, out decimal amountToAdd) || amountToAdd <= 0)
                {
                    MessageBox.Show("Invalid amount to add. Please enter a valid positive numeric value.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method to prevent further processing
                }
                decimal newAmountNow = goal.AmountNow + amountToAdd;
                if (newAmountNow > goal.TargetAmount)
                {
                    MessageBox.Show("The resulting amount exceeds the target amount.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UpdateGoalInDatabase(goalName, amountToAdd);

                

                // Add the amount to the existing goal
                goal.AmountNow += amountToAdd;
                goal.GoalProgress = goal.AmountNow / goal.TargetAmount * 100;
                decimal remainingAmount = goal.TargetAmount - goal.AmountNow;

                if (goal.GoalProgress == 100)
                {
                    // Delete the goal from the database
                    DeleteGoalFromDatabase(goalName);

                    // Show a congratulations message
                    MessageBox.Show("Congratulations! You completed the goal: " + goalName, "Goal Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                // Get the active workbook
                Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

                // Get the Goals sheet

                Excel.Worksheet goalsWorksheet = GetOrCreateWorksheet(workbook, "Goals");

                // Find the row that corresponds to the goal
                int goalRow = FindGoalRow(goalsWorksheet, goalName);

                if (goalRow != -1)
                {
                    // Update the goal details in the worksheet
                    goalsWorksheet.Cells[goalRow, 3].Value = goal.AmountNow;
                    goalsWorksheet.Cells[goalRow, 6].Value = goal.GoalProgress;

                    

                    // Show a success message
                    MessageBox.Show("Amount added to the goal successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }
            else
                MessageBox.Show("The goal was not found!\nPlease look in the file and input an existing goal!", "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DeleteGoalFromDatabase(string goalName)
        {
            

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Program Files\\SQLiteStudio\\GoalsDB.db;Version=3;"))
            {
                connection.Open();

                // Create the DELETE statement
                string deleteQuery = "DELETE FROM Goals WHERE goal_name = @GoalName";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    // Add the goal name as a parameter
                    command.Parameters.AddWithValue("@GoalName", goalName);

                    // Execute the DELETE statement
                    command.ExecuteNonQuery();
                }
            }
        }
        private Excel.Worksheet GetOrCreateWorksheet(Excel.Workbook workbook, string worksheetName)
        {
            Excel.Worksheet worksheet = null;

            try
            {
                worksheet = workbook.Sheets[worksheetName] as Excel.Worksheet;
            }
            catch (Exception)
            {
                // Worksheet does not exist, create a new one
                worksheet = workbook.Sheets.Add(Type.Missing, workbook.Sheets[workbook.Sheets.Count]);
                worksheet.Name = worksheetName;
            }

            return worksheet;
        }
        private void AddAmountToExistentGoalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
