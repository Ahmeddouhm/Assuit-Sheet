// Optimized Divisors O(sqrt(n))

int num = int.Parse(Console.ReadLine());

List<int> res = new();
List<int> larges = new();

for (int i = 1; i*i <= num; i++)
{
    if (num % i == 0) 
    {
        if (i == num / i)
        {
            res.Add(i);
        }
        else
        {
            res.Add(i);
            larges.Add(num / i);
        }
    }
}

res.AddRange(larges);
res.Sort();

foreach (var item in res)
{
    Console.WriteLine(item);
}
