using LocalLogic;
using GlobalLogic;

int[] arr = new int[10];
arr = GlobalLogic.GlobalClass.FillingArray(arr, -10, 10);

Console.Write("Массив: ");
GlobalLogic.GlobalClass.PrintArray(arr);

int[] arr_after_delte = LocalLogic.Localclass.DeleteFromArray(arr);

Console.Write("Массив после удаления отрицательных элемеетов: ");
GlobalLogic.GlobalClass.PrintArray(arr_after_delte);

Console.ReadLine();