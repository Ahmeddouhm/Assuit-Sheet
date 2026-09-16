string s = Console.ReadLine() ?? "";
string res = "";
List<string> strings = new();

if (s.Length == 1)
{
    Console.WriteLine(s);
    return;
}

for (int i = 0; i < s.Length - 1; i++)
{
    string subStr1 = s[..(i+1)];
    string subStr2 = s[(i + 1)..];

    char[] sub1 = subStr1.ToCharArray();
    char[] sub2 = subStr2.ToCharArray();

    Array.Sort(sub1);
    Array.Sort(sub2);

    string s1 = new string(sub1);
    string s2 = new string(sub2);
    res = s1 + s2;
    strings.Add(res);
}

Console.WriteLine(strings.Min());