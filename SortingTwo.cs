using System;

namespace Day10CSharp
{
    public class SortingTwo<T>
    {
        public static void Sort(T[] array, Func<T, T, bool> isSortCondition)
        {
            if (array == null || array.Length <= 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (isSortCondition(array[j], array[j + 1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void Sort(T[] array, Func<T, T, int> comparer)
        {
            if (array == null || array.Length <= 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
