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

            DateTime testInput = new DateTime(2025, 5, 7);
            int[] arrayInput = [1, 2, 3, 4, 5, 6, 7, 8];
            string[] nameInput = ["Sandro", "Indra"];
            string[] secondNameInput = ["Mawar", "Melati", "Indra"];
            
            dateFunction.GetNextMonthDateCount(testInput);

            arrayFunction.AddOnlyOdd(arrayInput);

            nameFunction.UniqueNames(nameInput, secondNameInput);
        }
    }
}

