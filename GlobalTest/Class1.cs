namespace GlobalTest
{
    public class Class1
    {
        // сортировка, заполнение, вывод
        public static int[] FillingArray(int[] arr, int min = int.MinValue, int max = int.MaxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            return arr;
        }
    }

}


