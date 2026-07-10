int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();
int min = int.MaxValue , idx = int.MinValue;

for (int i = 0; i < itr; i++)
{
    int currNum = int.Parse(nums[i]);

	if (currNum < min)
	{
		min = currNum;
		idx = i + 1;
	}
}

Console.WriteLine($"{min} {idx}");
