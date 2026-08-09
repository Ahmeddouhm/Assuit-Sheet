int iterations = int.Parse(Console.ReadLine());
while (iterations-- > 0)
{
	int len = int.Parse(Console.ReadLine());
	
	string[] input = Console.ReadLine().Split();
	int[] arr = Array.ConvertAll(input, int.Parse);

	int counter = 0;

	for (int i = 0; i < len; i++)
	{
		counter++;

		for (int j = i + 1; j < len; j++)
		{
			if (arr[j] >= arr[j-1])
				counter++;

			else
				break;
		}
	}

    Console.WriteLine(counter);

}
