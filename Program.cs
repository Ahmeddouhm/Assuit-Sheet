int num = int.Parse(Console.ReadLine());


for (int i = 0; i < num; i++)
{
    string[] inputNums = Console.ReadLine().Split();

    int num1 = int.Parse(inputNums[0]);
    int num2 = int.Parse(inputNums[1]);

    int start = Math.Min(num1, num2);
    int end = Math.Max(num1, num2);

    int sum = 0;

    for (int j = start + 1; j < end; j++)
    {
        if (j % 2 != 0)
        {
            sum += j;
        }

    }

    Console.WriteLine($"{sum}");
}