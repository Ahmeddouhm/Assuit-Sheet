int num = int.Parse(Console.ReadLine());
Fibonacci fibonacci = new();
Console.WriteLine(fibonacci.Calculate(num));


class Fibonacci 
{
    Dictionary<long, long> cache = new Dictionary<long, long>()
    {
        [1] = 0,
        [2] = 1
    };

    public long Calculate(long n)
    {
        if (cache.TryGetValue(n, out long value))
        {
            return value;
        }

        cache[n] = Calculate(n - 1) + Calculate(n - 2);

        return cache[n];
    }
}