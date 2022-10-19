using System;
using GlobalLogic;

namespace LocalLogic
{
    public class LocalClass
    {
        public static bool ComparisonArray(int[] arrFirst, int[] arrSecond)
        {
            Array.Sort(arrFirst);
            Array.Sort(arrSecond);

            if (arrFirst.Length == arrSecond.Length)
            {
                for (int i = 0; i < arrSecond.Length; i++)
                {
                    if (arrFirst[i] != arrSecond[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}

