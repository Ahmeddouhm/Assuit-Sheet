string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]), col = int.Parse(input[1]);

int[,] jgd = new int[row,col];
bool found = false;

for (int i = 0; i < row; i++)
{
    string[] rowInput = Console.ReadLine().Split();

    for (int j = 0; j < col; j++)
	{
		jgd[i, j] = int.Parse(rowInput[j]);
	}
}

int key = int.Parse(Console.ReadLine());

for (int i = 0; i < row; i++)
{
	for (int j = 0; j < col; j++)
	{
		if (jgd[i,j] == key)
		{
			Console.WriteLine("will not take number");
			found = true;
			return;
		}
	}
}

if (!found)
{
	Console.WriteLine("will take number");
}