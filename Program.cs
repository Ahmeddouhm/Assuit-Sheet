string[] input = Console.ReadLine().Split();

int len = int.Parse(input[0]);
int itr = int.Parse(input[1]);

string[] arrayInput = Console.ReadLine().Split();
long[] arr = Array.ConvertAll(arrayInput, long.Parse);

for (int i = 0; i < itr; i++)
{
    long inputLR = long.Parse(Console.ReadLine());

    if (BinarySearch(arr, inputLR))
        Console.WriteLine("found");
	else
        Console.WriteLine("not found");
	
}

bool BinarySearch(long[] arr, long key) 
{
	long low = 0, high = arr.Length - 1;

	while (low <= high)
	{
		long mid = low + (high - low) / 2;

		if (arr[mid] == key)
			return true;

		if (arr[mid] < key)
			low = mid + 1;
		else
			high = mid - 1;

	}

	return false;
}