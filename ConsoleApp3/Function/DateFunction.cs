using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Function
{
    internal class DateFunction: IDateFunction
    {
        ////1.Create a function that return the max date of next month
        public void GetNextMonthDateCount(DateTime date)
        {
            var firstDayofMonth = new DateTime(date.Year, date.Month, 1);
            var twoMontshAhead = firstDayofMonth.AddMonths(2);
            var lastDayofOneMonthAhead = twoMontshAhead.AddDays(-1);

            Console.WriteLine("Maximum date of next month based on input date: {0}",lastDayofOneMonthAhead.Day);
        }
    }
}
