string[] inputNums = Console.ReadLine().Split();

Console.WriteLine(GCD(int.Parse(inputNums[0]), int.Parse(inputNums[1])));

static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);