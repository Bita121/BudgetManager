using System;
using System.Collections.Generic;
using System.Linq;
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
        public Goals() {}
        
    }
}
