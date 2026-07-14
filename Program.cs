int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();
long[] arr = new long[itr];

for (long i = 0; i < itr; i++)
{
    arr[i] = long.Parse(nums[i]);
}

long min = arr[0];
int minFreq = 1;


for (int i = 1; i < itr; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
        minFreq = 1;
    }
    else if (arr[i] == min)
    {
        minFreq++;
    }
}

Console.WriteLine(minFreq % 2 == 0 ? "Unlucky" : "Lucky");
