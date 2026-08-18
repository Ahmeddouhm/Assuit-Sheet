string[] len = Console.ReadLine().Split();

string[] arr = Console.ReadLine().Split();

string[] sub = Console.ReadLine().Split();

int index = 0;

for (int i = 0; i < arr.Length && index < sub.Length; i++)
{
	if (sub[index] == arr[i])
	{
		index++;
	}
}

Console.WriteLine(index == sub.Length ? "YES" : "NO");