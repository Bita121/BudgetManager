﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public static class GlobalVariables
    {
        public static decimal CashLeft { get; set; } = 0;
        public static List<Expenses> listExpenses = new List<Expenses>();
        public static List<Incomes> listIncomes = new List<Incomes>();
        public static List<Goals> listGoals = new List<Goals>();

    }

}
