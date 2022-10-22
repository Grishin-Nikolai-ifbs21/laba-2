using LocalLogic;

int[,] arr = new int[3, 3];
arr = LocalLogic.Localclass.FillingArray(arr);

Console.WriteLine("Массив: ");
LocalLogic.Localclass.PrintAray(arr);

int sum = LocalLogic.Localclass.GetNegativeSumFromArray(arr);

Console.WriteLine($"Сумма элементов на четных позициях в массиве равна: {sum}");


Console.ReadLine();
