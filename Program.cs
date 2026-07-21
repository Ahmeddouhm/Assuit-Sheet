string[] numsInput = Console.ReadLine().Split();
int a = int.Parse(numsInput[0]);
int b = int.Parse(numsInput[1]);
string input = Console.ReadLine();

if (input[a] != '-')
{
    Console.WriteLine("No");
    return;
}

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
        continue;

    if (i != a)
    {
        Console.WriteLine("No");
        return;
    }
}

Console.WriteLine("Yes");