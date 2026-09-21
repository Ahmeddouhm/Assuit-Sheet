long[] s = Array.ConvertAll((Console.ReadLine() ?? "").Split(),long.Parse);
Console.WriteLine(Equation(s[0], s[1]));
long Equation(long x, long n)
{
	long equation = 0;
	
	for (int i = 2; i <= n; i+=2)
		equation += (long)Math.Pow(x, i);

	return equation;
}