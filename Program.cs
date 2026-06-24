string[] numInput = Console.ReadLine().Split();
long a = long.Parse(numInput[0]);
long b = long.Parse(numInput[1]);
long c = long.Parse(numInput[2]);
long[] arr = { a, b, c };

Array.Sort(arr);

Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);

Console.WriteLine();

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);