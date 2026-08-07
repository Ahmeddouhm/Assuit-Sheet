int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
double[] arr = Array.ConvertAll(input, double.Parse);

int operations = 0;
bool validOperation = true;

while (validOperation)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 2 != 0)
		{
			validOperation = false;
			break;
		}
		arr[i] /= 2;
	}
	operations++;
}

Console.WriteLine(operations - 1 < 0 ? 0 : operations - 1);
