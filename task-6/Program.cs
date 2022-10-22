using LocalLogic;
using GlobalLogic;

int[] arr = new int[10];
arr = GlobalLogic.GlobalClass.FillingArray(arr, -10, 10);

Console.Write("Массив: ");
GlobalLogic.GlobalClass.PrintArray(arr);


int[] arr_before_doubling = LocalLogic.LocalClass.ArrayDoublingNegativeDigit(arr);

Console.Write($"Массив после удвоения отрицательных элементов: ");
GlobalLogic.GlobalClass.PrintArray(arr_before_doubling);

Console.ReadLine();
