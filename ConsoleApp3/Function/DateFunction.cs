using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Function
{
    internal class DateFunction: IDateFunction
    {
        ////1.Create a function that return the max date of next month
        public int GetNextMonthDateCount(DateTime date)
        {
            var firstDayofMonth = new DateTime(date.Year, date.Month, 1);
            var twoMontshAhead = firstDayofMonth.AddMonths(2);
            var lastDayofOneMonthAhead = twoMontshAhead.AddDays(-1);

            return lastDayofOneMonthAhead.Day;
        }
    }
}
