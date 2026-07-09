int n = int.Parse(Console.ReadLine());

int a = 0, b = 1;
for (int i = 0; i < n; i++)
{
    int res = a + b;
    Console.Write($"{a} ");
    (a, b) = (b, res);
}