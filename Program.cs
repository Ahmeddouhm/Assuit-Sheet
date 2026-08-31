string s = Console.ReadLine() ?? "";

for (int i = 0; i < s.Length/2; i++)
{
	if (s[i] != s[s.Length - 1 - i])
	{
        Console.WriteLine("NO");
		return;
	}
	
}

Console.WriteLine("YES");