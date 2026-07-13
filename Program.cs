int cases = int.Parse(Console.ReadLine());

while (cases > 0)
{
    int itr = int.Parse(Console.ReadLine());
    string[] nums = Console.ReadLine().Split();
    long[] arr = new long[itr];
    long min = int.MaxValue;

    for (long i = 0; i < itr; i++)
    {
        arr[i] = long.Parse(nums[i]);
    }

    for (int i = 0; i < itr; i++)
    {

        for (int j = i + 1; j < itr; j++)
        {
            long result = arr[i] + arr[j] + j - i;
            if (result < min)
            {
                min = result;
            }
        }

    }

    Console.WriteLine(min);
    cases--;
}