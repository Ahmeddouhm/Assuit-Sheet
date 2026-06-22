string[] input = Console.ReadLine().Split();

decimal a = decimal.Parse(input[0]);
decimal b = decimal.Parse(input[1]);
decimal result = a / b;

Console.WriteLine($"floor {a} / {b} = {Math.Floor(result)}");
Console.WriteLine($"ceil {a} / {b} = {Math.Ceiling(result)}");
Console.WriteLine($"round {a} / {b} = {Math.Round(result,MidpointRounding.AwayFromZero)}");
