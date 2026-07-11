int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();

for (int i = 0; i < nums.Length/2; i++)
{
	if (nums[i] != nums[nums.Length - i - 1])
	{
        Console.WriteLine("NO");
		return;
	}

}
    Console.WriteLine("YES");