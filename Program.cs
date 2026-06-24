string[] stringNums = Console.ReadLine().Split();

long l1 = long.Parse(stringNums[0]);
long r1 = long.Parse(stringNums[1]);
long l2 = long.Parse(stringNums[2]);
long r2 = long.Parse(stringNums[3]);

long leftBoundary = Math.Max(l1, l2);
long rightBoundary = Math.Min(r1, r2);

if (r1 < l2 || r1 < r2)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine($"{leftBoundary} {rightBoundary}");
}
