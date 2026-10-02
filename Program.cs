long[] nums = Array.ConvertAll((Console.ReadLine() ?? "").Split(), long.Parse);
long start = nums.Min(), end = nums.Max();
long totalSum = SumNatural(end) - SumNatural(start - 1);
long evenSum = SumEven(start, end);
long oddSum = totalSum - evenSum;

Console.WriteLine(totalSum);
Console.WriteLine(evenSum);
Console.WriteLine(oddSum);
static long SumNatural(long n)
{
    return (n * (n + 1)) / 2; ;
}
static long SumEven(long l, long r)
{
    return SumNatural(r / 2) * 2 - SumNatural((l - 1) / 2) * 2;
}
