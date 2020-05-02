﻿using System;
using System.Collections.Generic;

namespace Budget_Lab
{
    public interface IBudgetRepo
    {
        List<Budget> GetAll();
    }

    public class Budget
    {
        public string YearMonth { get; set; }
        public int Amount { get; set; }

        public DateTime FirstDay()
        {
            return DateTime.ParseExact(YearMonth + "01", "yyyyMMdd", null);
        }

        public DateTime LastDay()
        {
            var daysInBudgetMonth = DateTime.DaysInMonth(FirstDay().Year, FirstDay().Month);
            return new DateTime(FirstDay().Year, FirstDay().Month, daysInBudgetMonth);
        }
    }
}
