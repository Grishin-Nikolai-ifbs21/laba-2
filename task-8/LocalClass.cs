using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static void PrintIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine($"Найдено совпадение с элементом {i + 1}");
                }
            }
        }
    }
}

