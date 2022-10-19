using LocalLogic;
using GlobalLogic;

int[] arr = new int[10];
arr = GlobalLogic.GlobalClass.FillingArray(arr, -10, 10);

Console.Write("Массив: ");
GlobalLogic.GlobalClass.PrintArray(arr);

int sum = LocalLogic.LocalClass.GetSum(arr);
Console.Write($"Сумма положительных элементов в массиве равна: {sum}");

Console.ReadLine();