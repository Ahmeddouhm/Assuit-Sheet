int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
	for (int j = num; j > i; j--)
	{
        Console.Write(" ");
	}

	for (int k = 1; k <= 2*i-1; k++)
	{
        Console.Write("*");
	}

    Console.WriteLine();
}
