int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    string[] input = Console.ReadLine().Split();
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		arr[i, j] = int.Parse(input[j]);
	}
}

int sumPrimaryDiagonal = 0, sumSecondaryDiagonal = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
		if (i == j)
		{
			sumPrimaryDiagonal += arr[i, j];
		}

		if (i + j == n-1)
		{
			sumSecondaryDiagonal += arr[i, j];
        }
    }
}

Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
