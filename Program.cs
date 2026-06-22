string[] input = Console.ReadLine().Split();

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);
int max, min;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

if (c > max)
{
    max = c;
}
else if (c < min) { min = c; }

Console.WriteLine($"{min} {max}");