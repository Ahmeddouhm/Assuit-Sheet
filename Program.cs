int itrs = int.Parse(Console.ReadLine() ?? "");

while (itrs -- > 0)
{
	long s = long.Parse(Console.ReadLine() ?? "");

	Console.WriteLine(IsPrime(s) ? "YES" : "NO");
}
bool IsPrime(long num)
{
	if (num <= 1)
		return false;

	for (int i = 2; i*i <= num; i++)
	{
		if (num % i == 0)
			return false;
	}

	return true;
}