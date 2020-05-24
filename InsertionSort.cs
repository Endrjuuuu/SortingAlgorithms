using System;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        public static void SortBetterTimeComplexity<T>(T[] array) where T : IComparable
        {
            T current;
            int otherIndex;
            for (int i = 1; i < array.Length; i++)
            {
                current = array[i];
                otherIndex = i;
                while (otherIndex > 0 && current.CompareTo(array[otherIndex - 1]) < 0)
                {
                    array[otherIndex] = array[otherIndex - 1];
                    otherIndex--;
                }
                array[otherIndex] = current;
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}