using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Function
{
    internal class ArrayFunction: IArrayFunction
    {
        //2.Given an array of ints, write a C# method to total all the values that are odd numbers.
        public int AddOnlyOdd(int[] ints)
        {
            var sum = 0;
            foreach (int i in ints)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
