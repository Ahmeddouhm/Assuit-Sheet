string[] s = (Console.ReadLine() ?? "").Split();

for (int i = 0; i < s.Length; i++)
{
    for (int j = s[i].Length - 1; j >= 0; j--)
    {
        string currString = s[i];
        Console.Write($"{currString[j]}");
    }
    if (i != s.Length - 1)
    {
        Console.Write(" ");
    }
}