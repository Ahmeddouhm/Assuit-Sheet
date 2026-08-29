using System.Text;

string input = (Console.ReadLine() ?? "");
var sb = new StringBuilder(input);

for (int i = 0; i < input.Length; i++)
{
	if (sb[i] == ',')
	{
		sb[i] = ' ';
	}

	if (char.IsUpper(sb[i]))
	{
		sb[i] = char.ToLower(sb[i]);
	}

	if (char.IsLower(input[i]))
	{
		sb[i] = char.ToUpper(sb[i]);
	}
}

Console.WriteLine(sb.ToString());