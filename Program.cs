string input1 = Console.ReadLine();
Console.WriteLine($"{input1.Remove(input1.IndexOf('\\'))}");