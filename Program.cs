int n = int.Parse(Console.ReadLine() ?? "");
int[] a = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);

Console.WriteLine(Distinct_Numbers(a));

int Distinct_Numbers(int[] array)
{
    HashSet<int> hSet = new();

    foreach (var x in array)
        hSet.Add(x);

    return hSet.Count;
}