int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    for (int j = num; j > i; j--)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = num; i >= 1; i--)
{
    for (int j = i; j < num; j++)
    {
        Console.Write(" ");
    }

    for (int k = 2 * i - 1; k >= 1; k--)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}