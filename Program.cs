string[] input = Console.ReadLine().Split();
// + * -
long num1 = long.Parse(input[0]);
long num2 = long.Parse(input[1]);

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
Console.WriteLine($"{num1} - {num2} = {num1 - num2}");