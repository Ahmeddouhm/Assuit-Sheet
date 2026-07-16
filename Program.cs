int cases = int.Parse(Console.ReadLine());

while (cases > 0)
{
    int itr = int.Parse(Console.ReadLine());
    string[] numsInput = Console.ReadLine().Split();
    int[] arr = Array.ConvertAll(numsInput , int.Parse);

    for (int i = 0; i < itr; i++)
    {
        int currMax = arr[i];

        for (int j = i; j < itr; j++)
        {
            if (arr[j] > currMax)
            {
                currMax = arr[j];
            }

            Console.Write($"{currMax} ");
        }
    }
    Console.WriteLine();

    cases--;
}