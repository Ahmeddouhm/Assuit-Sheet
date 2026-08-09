int len = int.Parse(Console.ReadLine());

string[] input = Console.ReadLine().Split();
long[] arr = Array.ConvertAll(input, long.Parse);

string[] input2 = Console.ReadLine().Split();
long[] arr2 = Array.ConvertAll(input2, long.Parse);

int counter = 0;

for (int i = 0; i < len; i++)
{
	if (arr2.Contains(arr[i]))
	{
        int arrayIndex = Array.IndexOf(arr2, arr[i]);
        arr2[arrayIndex] = 0;
		counter++;
	}
}

Console.WriteLine(counter == len ? "yes" : "no");
