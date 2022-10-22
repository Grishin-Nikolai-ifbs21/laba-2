using LocalLogic;


int[] arrFirst = { 1, 3, 5, 3, 4, 9 };
int[] arrSecond = { 3, 1, 5, 3, 9, 4 };

Console.Write("Первый массив: ");
GlobalLogic.GlobalClass.PrintArray(arrFirst);

Console.Write("Второй массив: ");
GlobalLogic.GlobalClass.PrintArray(arrSecond);

if (LocalLogic.LocalClass.ArrayIsComparison(arrFirst, arrSecond))
{
    Console.Write($"Массивы равны");
}
else
{
    Console.Write($"Массивы не равны");
}

Console.ReadLine();
