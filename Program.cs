double num = double.Parse(Console.ReadLine());

// [0,25], (25,50], (50,75], (75,100]
// Out Of Intervals

if (num < 0 || num > 100)
{
    Console.WriteLine("Out of Intervals");
}
else if (num >= 0 && num <= 25)
{
    Console.WriteLine("Interval [0,25]");
}
else if (num > 25 && num <= 50)
{
    Console.WriteLine("Interval (25,50]");
}
else if (num > 50 && num <= 75)
{
    Console.WriteLine("Interval (50,75]");
}
else if (num > 75 && num <= 100)
{
    Console.WriteLine("Interval (75,100]");
}