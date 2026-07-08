int n = int.Parse(Console.ReadLine());
int itr = 1;

for (int i = 0; i < n; i++)
{
    Console.Write($"{itr} {itr + 1} {itr + 2} PUM");
    Console.WriteLine();
    itr += 4;
}