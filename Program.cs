int num = int.Parse(Console.ReadLine());

if (num <= 1)
{
    Console.WriteLine("-1");
}

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}