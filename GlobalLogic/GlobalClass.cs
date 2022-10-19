using System;

namespace GlobalLogic
{
    public class GlobalClass
    {
        public static int[] FillingArray(int[] arr, int min = int.MinValue, int max = int.MaxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.Write('\n');
        }
    }
}

