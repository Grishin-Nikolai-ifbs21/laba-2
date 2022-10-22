using System;

namespace LocalLogic
{
    public class LocalClass
    {
        public static int[] GetIndexIfFind(int[] arr, int value)
        {
            int countFindIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    countFindIndex++;
                }
            }

            int index = 0;
            int[] arrFindIndex = new int[countFindIndex];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    arrFindIndex[index] = i;
                    index++;
                }
            }

            return arrFindIndex;
        }
    }
}

