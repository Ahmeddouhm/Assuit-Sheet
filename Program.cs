string s = (Console.ReadLine() ?? "").ToLower();
int[] frqArr = new int[5];

for (int i = 0; i < s.Length; i++)
{
	foreach (var c in s)
	{
		int idx = "egypt".IndexOf(c);

		if (idx != -1)
		{
			frqArr[idx]++;
		}
	}
}

Console.WriteLine(frqArr.Min());