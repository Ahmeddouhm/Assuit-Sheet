string[] s = (Console.ReadLine() ?? "").Split();
Console.WriteLine(Swap(s[0], s[1]));
string Swap(string n1, string n2)
{
	return $"{n2} {n1}";
}