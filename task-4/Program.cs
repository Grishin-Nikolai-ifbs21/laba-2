using LocalLogic;

int[,] arr = new int[3, 3];
arr = LocalLogic.Localclass.FillingArray(arr);

Console.WriteLine("Массив: ");
LocalLogic.Localclass.printArray(arr);

int sum = LocalLogic.Localclass.GetSum(arr);

Console.WriteLine($"Сумма элементов на четных позициях в массиве равна: {sum}");


Console.ReadLine();