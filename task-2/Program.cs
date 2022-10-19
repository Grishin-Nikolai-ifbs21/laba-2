using LocalLogic;

int[,,] arr = new int[,,] { { { 4, 3, -5 }, { 3, -5, 6 }, { -7, 5, 6 } },
                            { { -1, 3, 0 }, { 3, -6, 6 }, { 2, -4, 0 } },
                            { { 1, -5, 6 }, { -8, 9, 2 }, { -9, 5, 2 } } };

Console.WriteLine("Массив до замены:");
LocalLogic.LocalClass.PrintArray(arr);

int[,,] arr_replace = LocalLogic.LocalClass.ReplaceInArray(arr);

Console.WriteLine("\nМассив после замены:");
LocalLogic.LocalClass.PrintArray(arr_replace);

Console.ReadLine();