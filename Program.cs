int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();

for (int i = 0; i < itr; i++)
{
    int currNum = int.Parse(nums[i]);

	if (currNum > 0)
	{
		nums[i] = "1";
	}

	if (currNum < 0)
	{
		nums[i] = "2";
	}
	Console.Write($"{nums[i]} ");
}

