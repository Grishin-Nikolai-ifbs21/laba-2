using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[] SortArray(int[] arr)
        {
            int[] arr_sort = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr_sort[i] = arr[i];
            }

            int tmp;
            for (int i = 0; i < arr_sort.Length; i++)
            {
                for (int j = i + 1; j < arr_sort.Length; j++)
                {
                    if (arr_sort[i] < arr_sort[j])
                    {
                        tmp = arr_sort[i];
                        arr_sort[i] = arr_sort[j];
                        arr_sort[j] = tmp;
                    }
                }
            }

            return arr_sort;
        }
    }
}

