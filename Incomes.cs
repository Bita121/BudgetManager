using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class Incomes
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Incomes() { 
            Category = string.Empty;
            Amount = 0;
            Description = string.Empty;
            Date = DateTime.MinValue;
        }
        public Incomes(string category, decimal amount, string description, DateTime date)
        {
            Category = category;
            Amount = amount;
            Description = description;
            Date = date;
        }
    }
}
