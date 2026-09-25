int n = int.Parse(Console.ReadLine() ?? "");
int[] a = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
int[] b = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);

Create_Array(a, b);

void Create_Array(int[] a, int[] b)
{
    int[] c = new int[a.Length + b.Length];

    for (int i = 0; i < b.Length; i++)
        c[i] = b[i];

    for (int i = 0; i < a.Length; i++)
        c[i + b.Length] = a[i];

    Print_Array(c);
}
void Print_Array(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}