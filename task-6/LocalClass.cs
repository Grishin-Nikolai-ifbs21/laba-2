using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[] ArrayDoubling(int[] arr)
        {
            int count_negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count_negative++;
                }
            }

            int[] arr_doubling = new int[arr.Length + count_negative];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr_doubling[index] = arr[i];
                    arr_doubling[index + 1] = arr[i];
                    index++;
                }
                else
                {
                    arr_doubling[index] = arr[i];
                }
                index++;                
            }

            return arr_doubling;
        }
    }
}

