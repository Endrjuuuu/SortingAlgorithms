using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main()
        {
            int[] integerValuesOriginal = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };


            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            int[] arr2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            Console.Write("Before sorting:".PadRight(25));
            Console.WriteLine(string.Join(" | ", integerValues));


            SelectionSort.Sort(integerValues);
            Console.Write($"After {nameof(SelectionSort)}:".PadRight(25));
            Console.WriteLine(string.Join(" | ", integerValues));

            Array.Copy(integerValuesOriginal, integerValues, integerValues.Length);

            InsertionSort.Sort(integerValues);
            Console.Write($"After {nameof(InsertionSort)}:".PadRight(25));
            Console.WriteLine(string.Join(" | ", integerValues));

            Console.ReadKey();
        }
    }
}