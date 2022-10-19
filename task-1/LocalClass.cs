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
                for (int j = i+1; j < arr_sort.Length; j++)
                {
                    if (arr_sort[i] > arr_sort[j])
                    {
                        tmp = arr_sort[i];
                        arr_sort[i] = arr_sort[j];
                        arr_sort[j] = tmp;
                    }
                }
            }

            return arr_sort;
        }

        public static int GetMinValue(int[] arr)
        {
            int tmp_min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < tmp_min)
                {
                    tmp_min = arr[i];
                }
            }

            return tmp_min;
        }

        public static int GetMaxValue(int[] arr)
        {
            int tmp_min = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > tmp_min)
                {
                    tmp_min = arr[i];
                }
            }

            return tmp_min;
        }
    }
}

