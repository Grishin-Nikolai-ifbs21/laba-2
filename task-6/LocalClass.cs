using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[] ArrayDoublingNegativeDigit(int[] arr)
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
                arr_doubling[index] = arr[i];
                if (arr[i] < 0)
                {
                    arr_doubling[index + 1] = arr[i];
                    index++;
                }
                index++;                
            }

            return arr_doubling;
        }
    }
}

