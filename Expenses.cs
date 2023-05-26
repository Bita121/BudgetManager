using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class Expenses
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Expenses()
        {
            Category = string.Empty;
            Amount = 0;
            Description = string.Empty;
            Date = DateTime.MinValue;
        }

    }
}
