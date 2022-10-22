using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[] ArraySortDescending(int[] arr)
        {
            int[] arr_result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr_result[i] = arr[i];
            }

            Array.Sort(arr_result);
            Array.Reverse(arr_result);
            return arr_result;
        }
    }
}

