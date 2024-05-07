// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Function;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDateFunction dateFunction = new DateFunction();
            IArrayFunction arrayFunction = new ArrayFunction();
            INameFunction nameFunction = new NameFunction();

            DateTime testInput = new(2025, 5, 7);
            int[] arrayInput = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            string[] nameInput = ["Sandro", "Indra"];
            string[] secondNameInput = ["Mawar", "Melati", "Indra"];

            var lastDay =  dateFunction.GetNextMonthDateCount(testInput);
            var sum = arrayFunction.AddOnlyOdd(arrayInput);
            var nameResult = nameFunction.UniqueNames(nameInput, secondNameInput);

            Console.WriteLine("Sum of all odd numbers: {0}",sum);
            Console.WriteLine("Unique name(s) in these input arrays: {0}", nameResult);
            Console.WriteLine("Maximum date of next month based on input date: {0}", lastDay);
        }
    }
}

