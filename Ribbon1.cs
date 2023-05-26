using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YourNamespace;

namespace BudgetManager
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
           
        }

        private void AddExpense_Click(object sender, RibbonControlEventArgs e)
        {
            AddExpenseForm expenseForm = new AddExpenseForm();
            expenseForm.Show();
        }

        private void AddIncome_Click(object sender, RibbonControlEventArgs e)
        {
            AddIncomeForm incomeForm = new AddIncomeForm();
            incomeForm.Show();
        }

        private void GenerateReport_Click(object sender, RibbonControlEventArgs e)
        {
            FinancialReportGenerator reportGenerator = new FinancialReportGenerator();
            reportGenerator.GenerateFinancialReport();
        }
    }
}
