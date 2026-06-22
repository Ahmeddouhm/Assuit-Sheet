string[] input = Console.ReadLine().Split();

// (A*B) - (C*D)

long a = long.Parse(input[0]);
long b = long.Parse(input[1]);
long c = long.Parse(input[2]);
long d = long.Parse(input[3]);

long result = (a * b) - (c * d);

Console.WriteLine("Difference = "+result);