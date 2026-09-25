using System;

namespace Day10CSharp
{
    public static class SortingAlgorithm
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (array == null || index1 < 0 || index2 < 0 || index1 >= array.Length || index2 >= array.Length)
                return;

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }

    public class SortingAlgorithm<T> where T : IComparable<T>, ICloneable
    {
        public static void Sort(T[] array)
        {
            if (array == null || array.Length <= 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        SortingAlgorithm.Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void Swap<TItem>(ref TItem a, ref TItem b)
        {
            SortingAlgorithm.Swap(ref a, ref b);
        }

        public static void Swap<TItem>(TItem[] array, int index1, int index2)
        {
            SortingAlgorithm.Swap(array, index1, index2);
        }
    }
}
