int itr = int.Parse(Console.ReadLine());
long factorial = 1;

for (int j = 0; j < itr; j++)
{
    int num = int.Parse(Console.ReadLine());
    for (int i = num; i > 1; i--)
    {
        if (num == 1 || num == 0)
            break;

        factorial *= i;
    }
    Console.WriteLine(factorial);
    factorial = 1;
}
