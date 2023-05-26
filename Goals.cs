using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class Goals
    {   
        public string GoalName {  get; set; }
        public decimal TargetAmount { get; set; }
        public decimal AmountNow { get; set; }
        public DateTime dateDeadline { get; set; }
        public string AdditionalNotes { get; set; } 
        public decimal GoalProgress { get; set; }
        public Goals() {}
        public Goals(string goalName, decimal targetAmount, decimal amountNow, DateTime dateDeadline, string additionalNotes)
        {
            GoalName = goalName;
            TargetAmount = targetAmount;
            AmountNow = amountNow;
            this.dateDeadline = dateDeadline;
            AdditionalNotes = additionalNotes;
            GoalProgress = amountNow/targetAmount * 100;
        }
    }
}
