using System.Text;

string s = (Console.ReadLine() ?? "");
var sb = new StringBuilder();

for (int i = 0; i < s.Length; i++)
{
	if (s[i] == 'E')
	{
		if (i + 5 <= s.Length && s.Substring(i, 5) == "EGYPT")
		{
			sb.Append(' ');
			i += 4;
			continue;
		}
	}
	sb.Append(s[i]);
}

Console.WriteLine(sb.ToString());