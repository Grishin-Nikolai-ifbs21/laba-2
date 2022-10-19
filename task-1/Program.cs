using GlobalLogic;

int[] arr = new int[10];
arr = GlobalLogic.GlobalClass.FillingArray(arr, 0, 100);

Console.Write("Массив до сортировки: ");
GlobalLogic.GlobalClass.PrintArray(arr);

arr = LocalLogic.LocalClass.SortArray(arr);

Console.Write("Массив после сортировки: ");
GlobalLogic.GlobalClass.PrintArray(arr);

int min = LocalLogic.LocalClass.GetMinValue(arr);
int max = LocalLogic.LocalClass.GetMaxValue(arr);

Console.Write($"Минимальное значение в массиве: {min}\nМаксимальное значение в массиве: {max}\n");
Console.ReadLine();