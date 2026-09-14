using System.Text;
string num = Console.ReadLine() ?? "";
StringBuilder s = new (Console.ReadLine() ?? "");
int score = 0;

for (int i = 0; i < s.Length; i++)
{
	switch (s[i])
	{
		case 'V':
			score += 5;
			break;
		case 'W':
			score += 2;
			break;
		case 'X':
			if (i < s.Length-1)
				i++;
			break;
		case 'Y':
			if (i < s.Length-1)
			{
				char nextChar = s[i + 1];
				s.Append(nextChar);
				i++;
			}
			break;
		case 'Z':
			if (i < s.Length-1)
			{
				if (s[i+1] == 'V')
				{
					score /= 5;
					i++;
				}
				else if (s[i + 1] == 'W')
				{
					score /= 2;
					i++;
				}
			}
			break;
	}
}

Console.WriteLine(score);