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
	sumPrimaryDiagonal += arr[i, i];

	sumSecondaryDiagonal += arr[i, n - 1 - i];
}

Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
