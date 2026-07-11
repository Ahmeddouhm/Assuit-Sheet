int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();

for (int i = nums.Length - 1; i >= 0; i--)
{
    Console.Write($"{nums[i]} ");
}