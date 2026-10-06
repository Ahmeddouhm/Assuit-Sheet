long n = long.Parse(Console.ReadLine() ?? "");

long sum = 0;
int count = 0;

for (long i = 1; ;i++)
{
	if (sum + i > n)
		break;

	sum += i;
	count++;
}

Console.WriteLine(count);