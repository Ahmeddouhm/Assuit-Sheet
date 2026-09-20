long s = long.Parse(Console.ReadLine() ?? "");
Console.WriteLine(Wonderful_Num(s) ? "YES" : "NO");
bool Wonderful_Num(long num)
{
	string binary = Convert.ToString(num, 2);
	bool isPalindrome = true;

	for (int i = 0; i < binary.Length/2; i++)
	{
		if (binary[i] != binary[binary.Length - 1 - i])
			isPalindrome = false;
	}

	return isPalindrome && num % 2 != 0;
}