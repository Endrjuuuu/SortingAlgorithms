using System;

namespace SortingAlgorithms
{
    public static class MargeSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                Marge(array, left, middle, right);
            }
        }

        private static void Marge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

            Array.Copy(array, left, leftArray, 0, middle - left + 1);
            Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}