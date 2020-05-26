using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithms
{
    internal class Program
    {
        public delegate void SortFunction<T>(T[] array) where T : IComparable;

        private static void Main()
        {
            SortFunction<int>[] sortFunctions = { SelectionSort.Sort, InsertionSort.Sort, InsertionSort.SortBetterTimeComplexity , BubbleSort.Sort, BubbleSort.SortBetterTimeComplexity, QuickSort.Sort, MargeSort.Sort };

            string[] namesOfFunctions = new string[sortFunctions.Length];
            for (int i = 0; i < namesOfFunctions.Length; i++)
            {
                namesOfFunctions[i] = $"{sortFunctions[i].Method.DeclaringType.Name}.{sortFunctions[i].Method.Name}";
            }
            int arrayLength = 10;
            int[] integerValues = new int[arrayLength];
            Random random = new Random();
            Console.Write("Before sort: ".PadRight(namesOfFunctions.Select(f => f.Length).Max() + 2));
            for (int i = 0; i < integerValues.Length; i++)
            {
                integerValues[i] = random.Next(-100, 100);
                Console.Write(integerValues[i] + " | ");
            }
            Console.WriteLine();

            int[] arrayToSort = new int[arrayLength];
            Array.Copy(integerValues, arrayToSort, arrayLength);

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine();
            for (int i = 0; i < sortFunctions.Length; i++)
            {
                Console.Write($"{namesOfFunctions[i]}: ".PadRight(namesOfFunctions.Select(f => f.Length).Max() + 2));
                stopwatch.Start();
                sortFunctions[i](arrayToSort);
                stopwatch.Stop();
                Console.WriteLine(string.Join(" | ", arrayToSort));
                Console.WriteLine($"Elapsed Ticks: {stopwatch.ElapsedTicks}");
                stopwatch.Reset();
                Array.Copy(integerValues, arrayToSort, arrayLength);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}