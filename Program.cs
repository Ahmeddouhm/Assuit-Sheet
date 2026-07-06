int itr = int.Parse(Console.ReadLine());

for (int i = 0; i < itr; i++)
{
    string inputNums = Console.ReadLine();
    ReverseString(inputNums);
}

static void ReverseString(string str) 
{
    char[] chars = str.Reverse().ToArray();

    foreach (var digit in chars)
    {
        Console.Write($"{digit} ");
    }
    Console.WriteLine();

}