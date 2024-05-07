using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Function
{
    internal class NameFunction(): INameFunction
    {
        public void UniqueNames(string[] firstArray, string[] secondArray)
        {
            var result = new List<string>();
            foreach (var name in firstArray)
            {
                if (!result.Contains(name))
                {
                    result.Add(name);
                }
            }
            foreach (var name in secondArray)
            {
                if (!result.Contains(name))
                {
                    result.Add(name);
                }
            }
            var arrayResult = result.ToArray();
            var stringResult = String.Join(", ", arrayResult);
            Console.WriteLine("Unique name(s) in these input arrays: {0}", stringResult);
        }
    }
}
