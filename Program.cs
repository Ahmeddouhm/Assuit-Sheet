long[] count = new long[26];

int c;
while ((c = Console.Read()) != -1)
{
	if (c >= 'a' && c <= 'z')
	{
		count[c - 'a']++;
	}
}

for (int i = 0; i < 26; i++)
{
	if (count[i] > 0)
		Console.WriteLine($"{(char)(i + 'a')} : {count[i]}");

}

