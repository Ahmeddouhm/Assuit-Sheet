string input1 = Console.ReadLine() ?? "";
string input2 = Console.ReadLine() ?? "";

int len = Math.Min(input1.Length, input2.Length);

for (int i = 0; i < len; i++)
{
	if (input1[i] > input2[i])
	{
		Console.WriteLine(input2);
		return;
	}

	if (input1[i] < input2[i])
	{
		Console.WriteLine(input1);
		return;
	}
}

if (input1.Length > input2.Length)
    Console.WriteLine(input2);
else
    Console.WriteLine(input1);
