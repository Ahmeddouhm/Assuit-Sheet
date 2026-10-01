Int128 num = Int128.Parse(Console.ReadLine() ?? "");

Console.WriteLine((isPrime(num)) ? "YES" : "NO");

bool isPrime(Int128 n) 
{
	if (n < 2)
		return false;

	for (long i = 2; i*i <= n; i++)
		if (n % i == 0)
			return false;

	return true;
}