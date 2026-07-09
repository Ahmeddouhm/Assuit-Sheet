string[] nums = Console.ReadLine().Split();
int k = int.Parse(nums[0]), s = int.Parse(nums[1]), counter = 0;

for (int i = 0; i <= k; i++)
{
	for (int j = 0; j <= k; j++)
	{
		if (s - i - j >= 0 && s - i - j <= k)
			counter++;
	}
}

Console.WriteLine(counter);