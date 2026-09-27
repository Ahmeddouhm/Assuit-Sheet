int n = int.Parse(Console.ReadLine().Trim());

int[] arr = new int[n];

if (n > 0)
{
    string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < n; i++)
        arr[i] = int.Parse(parts[i]);
}

Console.WriteLine(CountDistinct(arr, n));
int CountDistinct(int[] array, int n)
{
    HashSet<int> set = new HashSet<int>();

    for (int i = 0; i < n; i++)
        set.Add(arr[i]);

    return set.Count;
}