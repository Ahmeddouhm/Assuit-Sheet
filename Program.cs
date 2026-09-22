int itrs = int.Parse(Console.ReadLine() ?? "");
while (itrs -- > 0)
{
	string[] input = (Console.ReadLine() ?? "").Split();
	Loop(int.Parse(input[0]), input[1]);
    Console.WriteLine();
}
void Loop(int n, string c) 
{
	for (int i = 0; i < n; i++)
	{
        Console.Write($"{c} ");
	}
}