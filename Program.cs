using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main()
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            Console.ReadKey();
        }
    }
}