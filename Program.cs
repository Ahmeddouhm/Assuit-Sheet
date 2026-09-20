int s = int.Parse(Console.ReadLine() ?? "");
Print(s);
void Print(int num) 
{
	for (int i = 1; i <= s; i++)
	{
        Console.Write(i);

        if (i != s)
            Console.Write(" ");
    }
}