using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}

