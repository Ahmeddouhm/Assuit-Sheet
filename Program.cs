string[] input = Console.ReadLine().Split();

int len = int.Parse(input[0]);
int itr = int.Parse(input[1]);

string[] arrayInput = Console.ReadLine().Split();
long[] arr = Array.ConvertAll(arrayInput, long.Parse);
List<long> longs = new();
long sum = 0;

for (int i = 0; i < arr.Length; i++)
{
	sum += arr[i];
	

	longs.Add(sum);
}


for (int i = 0; i < itr; i++)
{
    string[] inputLR = Console.ReadLine().Split();

    int l = int.Parse(inputLR[0]) - 1;
    int r = int.Parse(inputLR[1]) - 1;

	if (l-1 < 0)
	{
		Console.WriteLine(longs[r]);
	}
	else
	{
		Console.WriteLine(longs[r] - longs[l-1]);
	}
}
