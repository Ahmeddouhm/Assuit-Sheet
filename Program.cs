int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();

int max = 0;

for (int i = 0; i < nums.Length; i++)
{
    int parsedNum = int.Parse(nums[i]);
	if (parsedNum > max)
	{
		max = parsedNum;
	}
}

Console.WriteLine(max);