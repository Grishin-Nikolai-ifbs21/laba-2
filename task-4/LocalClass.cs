using System;

namespace LocalLogic
{
    public class Localclass
    {
        public static int[,] FillingArray(int[,] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-9, 9);
                }
            }

            return arr;
        }

        public static void PrintAray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    else
                    {
                        Console.Write($" {arr[i, j]} ");
                    }
                }
                Console.Write('\n');
            }
        }

        public static int GetNegativeSumFromArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            return sum;
        }
    }
}

