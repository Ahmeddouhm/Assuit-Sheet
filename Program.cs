string[] stringNums = Console.ReadLine().Split();

double a = double.Parse(stringNums[0]);
double b = double.Parse(stringNums[1]);
double c = double.Parse(stringNums[2]);
double d = double.Parse(stringNums[3]);

double leftSide = b * Math.Log(a);
double rightSide = d * Math.Log(c);

if (leftSide > rightSide)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
