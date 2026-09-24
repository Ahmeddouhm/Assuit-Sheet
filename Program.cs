int[] input = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
int n = input[0], x = --input[1], y = --input[2];
int[,] twoDimArray = new int[n, n];

for (int i = 0; i < n; i++)
{
    int[] row = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);

    for (int j = 0; j < n; j++)
        twoDimArray[i, j] = row[j];
}

Swap_Rows_2D_Array(twoDimArray, x, y);
Swap_Cols_2D_Array(twoDimArray, x, y);
Print_2D_Array(twoDimArray);

void Swap_Rows_2D_Array(int[,] twoDimArray, int r1, int r2)
{
    for (int i = 0; i < twoDimArray.GetLength(1); i++)
    {
        (twoDimArray[r1,i], twoDimArray[r2,i]) = (twoDimArray[r2,i], twoDimArray[r1,i]);
    }
}
void Swap_Cols_2D_Array(int[,] twoDimArray, int c1, int c2)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        (twoDimArray[i,c1], twoDimArray[i,c2]) = (twoDimArray[i,c2], twoDimArray[i,c1]);
    }
}
void Print_2D_Array(int[,] twoDimArray) 
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            Console.Write($"{twoDimArray[i, j]} ");
        }
        Console.WriteLine();
    }
}