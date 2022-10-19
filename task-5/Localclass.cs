using System;

using System.Reflection;

namespace LocalLogic
{
    public class Localclass
    {
        public static int[] DeleteFromArray(int[] arr)
        {
            int count_negative = 0;            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count_negative += 1;
                }
            }

            int[] arr_result = new int[arr.Length - count_negative];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr_result[index] = arr[i];
                    index++;
                }
            }

            return arr_result;
        }
    }
}

