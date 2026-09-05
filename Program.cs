string s = (Console.ReadLine() ?? "");
string target = "hello";
int j = 0;

for (int i = 0; i < s.Length; i++)
{
	if (j < target.Length && s[i] == target[j])
		j++;
}

Console.WriteLine(j == target.Length ? "YES" : "NO");