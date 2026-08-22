string[] len = Console.ReadLine().Split();

int row = int.Parse(len[0]);
int col = int.Parse(len[1]);

char[,] arr = new char[row, col];

for (int i = 0; i < arr.GetLength(0); i++)
{
    string input = Console.ReadLine() ?? "";

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = input[j];
    }
}

string[] pos = Console.ReadLine().Split();

int r = int.Parse(pos[0]);
int c = int.Parse(pos[1]);
r--;
c--;

try
{
    if (arr[r,c-1] != '.' && arr[r,c+1] != '.' &&
        arr[r-1,c] != '.' && arr[r+1,c] != '.' &&
        arr[r-1,c-1] != '.' && arr[r-1,c+1] != '.' &&
        arr[r+1,c+1] != '.' && arr[r+1,c-1] != '.' )
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
catch (Exception ex)
{
    Console.WriteLine("yes");
}

