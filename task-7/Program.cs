using LocalLogic;
using GlobalLogic;

int sizeArray = 0;
Console.Write("Введите размер массива: ");

if (!int.TryParse(Console.ReadLine(), out sizeArray) || sizeArray <= 0)
{
    Console.Write("Ошибка! Размер массива может быть только положительное число!");
    Console.ReadLine();
    return;
}

int[] arr = new int[sizeArray];
arr = GlobalLogic.GlobalClass.FillingArray(arr, -100, 100);

Console.Write("Массив: ");
GlobalLogic.GlobalClass.PrintArray(arr);

arr = LocalLogic.LocalClass.SortArray(arr);

Console.Write("Массив после сортировки по убыванию: ");
GlobalLogic.GlobalClass.PrintArray(arr);


Console.ReadLine();