int itr = int.Parse(Console.ReadLine());
string nums = Console.ReadLine();
long sum = 0;

for (int i = 0; i < itr; i++)
{
    sum += long.Parse(nums[i].ToString());
}

Console.WriteLine(sum);