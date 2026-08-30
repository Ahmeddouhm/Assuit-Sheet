int itrs = int.Parse(Console.ReadLine() ?? "");

for (int i = 0; i < itrs; i++)
{
    string s = Console.ReadLine() ?? "";

	if (s.Contains("010") || s.Contains("101"))
	{
        Console.WriteLine("Good");
	}
	else
	{
	    Console.WriteLine("Bad");
	}
	
}