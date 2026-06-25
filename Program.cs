int itr = int.Parse(Console.ReadLine());
string[] values = Console.ReadLine().Split();
int positives = 0, negatives = 0, evens = 0, odds = 0;

for (int i = 0; i < itr; i++)
{
	int num = int.Parse(values[i]);

	if (num % 2 == 0)
	{
		evens++;
	}
    else if (num % 2 != 0)
    {
		odds++;
	}

	if (num > 0)
	{
		positives++;
	}
	else if (num < 0)
	{
		negatives++;
	}
}

Console.WriteLine($"Even: {evens}\r\nOdd: {odds}\r\nPositive: {positives}\r\nNegative: {negatives}");