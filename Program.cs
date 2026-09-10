string s = (Console.ReadLine() ?? "");//.Split();

int count = 1;
bool flag = true;

for (int i = 1; i < s.Length; i++)
{
	if (char.IsLetter(s[i]))
	{
		if (!flag)
		{
			count++;
			flag = true;
		}
	}
	else
	{
		flag = false;
	}
}

Console.WriteLine(count);