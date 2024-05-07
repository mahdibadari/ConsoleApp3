// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Function;
using ConsoleApp3.Interfaces;

DateTime testInput = new DateTime(2025, 5, 7);
DateFunction dateFunction = new DateFunction();
dateFunction.GetNextMonthDateCount(testInput);

int[] arrayInput = [1, 2, 3, 4, 5, 6, 7, 8];
ArrayFunction arrayFunction = new ArrayFunction();
arrayFunction.AddOnlyOdd(arrayInput);

string[] nameInput = ["Sandro", "Indra"];
string[] secondNameInput = ["Mawar", "Melati", "Indra"];
NameFunction nameFunction = new NameFunction();
nameFunction.UniqueNames(nameInput, secondNameInput);


namespace ConsoleApp3
{
    //internal class Main
    //{
    //        private IDateFunction _dateFunction;
    //        private IArrayFunction _arrayFunction;
    //        private INameFunction _nameFunction;

    //        internal Main()
    //        {
    //            _arrayFunction = new ArrayFunction();
    //            _dateFunction = new DateFunction();
    //            _nameFunction = new NameFunction();

    //            _arrayFunction.AddOnlyOdd([1, 2, 3, 4, 5, 6, 7, 8]);
    //            _nameFunction.UniqueNames(["Sandro", "Indra"], ["Mawar", "Melati", "Indra"]);
    //            _dateFunction.GetNextMonthDateCount(new DateTime(2025, 5, 7));
    //        }

    //        DateTime testInput = new DateTime(2025, 5, 7);
    //        DateFunction dateFunction = new DateFunction();
    //        dateFunction.GetNextMonthDateCount(testInput);

    //int[] arrayInput = [1, 2, 3, 4, 5, 6, 7, 8];
    //        ArrayFunction arrayFunction = new ArrayFunction();
    //        arrayFunction.AddOnlyOdd(arrayInput);

    //string[] nameInput = ["Sandro", "Indra"];
    //        string[] secondNameInput = ["Mawar", "Melati", "Indra"];
    //        NameFunction nameFunction = new NameFunction();
    //        nameFunction.UniqueNames(nameInput, secondNameInput);
    //}
}

