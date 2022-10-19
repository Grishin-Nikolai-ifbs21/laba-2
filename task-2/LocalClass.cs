using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[,,] ReplaceInArray(int[,,] arr)
        {
            int[,,] arr_replace = new int[arr.GetLength(0), arr.GetLength(1), arr.GetLength(2)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr_replace[i, j, k] = arr[i, j, k];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr_replace[i, j, k] > 0)
                        {
                            arr_replace[i, j, k] = 0;
                        }
                    }
                }
            }

            return arr_replace;
        }

        public static void PrintArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");

                    }
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
    }
}

