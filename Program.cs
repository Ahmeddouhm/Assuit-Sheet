int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();
long summation = 0;

for (int i = 0; i < itr; i++)
{
    long currNum = long.Parse(nums[i]);
    summation += currNum;
}

Console.WriteLine(Math.Abs(summation));