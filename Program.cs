using System.Text;

int itrs = int.Parse(Console.ReadLine() ?? "");
string s = (Console.ReadLine() ?? "");
var sb = new StringBuilder();

for (int i = 0; i < itrs; i++)
{
	if (i == 0)
	{
		sb.Append(s[i]);
		continue;
	}

	char lastChar = s[i - 1];
	if (s[i] != lastChar)
	{
		sb.Append(s[i]);
	}
}

Console.WriteLine(sb.Length);