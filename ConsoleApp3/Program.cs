// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Function;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime testInput = new DateTime(2025, 5, 7);
            IDateFunction dateFunction = new DateFunction();
            dateFunction.GetNextMonthDateCount(testInput);

            int[] arrayInput = [1, 2, 3, 4, 5, 6, 7, 8];
            IArrayFunction arrayFunction = new ArrayFunction();
            arrayFunction.AddOnlyOdd(arrayInput);

            string[] nameInput = ["Sandro", "Indra"];
            string[] secondNameInput = ["Mawar", "Melati", "Indra"];
            INameFunction nameFunction = new NameFunction();
            nameFunction.UniqueNames(nameInput, secondNameInput);
        }
    }
}

