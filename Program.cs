string[] points = Console.ReadLine().Split();
double x = double.Parse(points[0]);
double y = double.Parse(points[1]);

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (double.IsPositive(x) && double.IsPositive(y))
{
    Console.WriteLine("Q1");
}
else if (double.IsNegative(x) && double.IsPositive(y))
{
    Console.WriteLine("Q2");
}
else if (double.IsNegative(x) && double.IsNegative(y))
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}
