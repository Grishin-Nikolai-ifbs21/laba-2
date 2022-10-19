using LocalLogic;
using GlobalLogic;

int sizeArray = 0;
int find_value = 0;
Console.Write("Введите размер массива: ");

if (!int.TryParse(Console.ReadLine(), out sizeArray) || sizeArray <= 0)
{
    Console.Write("Ошибка! Размер массива может быть только положительное число!");
    Console.ReadLine();
    return;
}

Console.Write("Введите значение для поиска: ");
if (!int.TryParse(Console.ReadLine(), out find_value))
{
    Console.Write("Ошибка! Введите число для поиска в массиве!");
    Console.ReadLine();
    return;
}

int[] arr = new int[sizeArray];
arr = GlobalLogic.GlobalClass.FillingArray(arr, 0, 10);

Console.Write("Массив: ");
GlobalLogic.GlobalClass.PrintArray(arr);
Console.Write('\n');

LocalLogic.LocalClass.PrintIndex(arr, find_value);

Console.ReadLine();