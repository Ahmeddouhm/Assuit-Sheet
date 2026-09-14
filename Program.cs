using System.Text;
string s = new (Console.ReadLine() ?? "");
int balance = 0, start = 0;
List<string> balancedStrings = new();

for (int i = 0; i < s.Length; i++)
{
	if (s[i] == 'R')
	{
		balance++;
	}
	else
	{
		balance--;
	}

	if (balance == 0)
	{
		balancedStrings.Add(s.Substring(start, i - start + 1));
		start = i + 1;
	}
}
Console.WriteLine(balancedStrings.Count);
foreach (var balancedStr in balancedStrings)
{
    Console.WriteLine(balancedStr);
}
