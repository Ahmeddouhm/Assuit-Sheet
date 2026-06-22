string[] input = Console.ReadLine().Split();

int lastNum1 = int.Parse(input[0].Substring(input[0].Length-1));
int lastNum2 = int.Parse(input[1].Substring(input[1].Length-1));

Console.WriteLine(lastNum1+lastNum2);