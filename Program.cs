using System.Text;

string[] inputNums = Console.ReadLine().Split();
long start = long.Parse(inputNums[0]);
long end = long.Parse(inputNums[1]);
StringBuilder luckyNums = new();

for (long i = start; i <= end; i++)
{
	string currNum = i.ToString();

	for (int j = 0; j < currNum.Length; j++)
	{
		if (currNum[j] != '7' && currNum[j] != '4')
		{
			break;
		}
		else
		{
			if (j == currNum.Length - 1)
			{
				luckyNums.Append(i+" ");
			}
		}
	}
}

if (luckyNums.Length == 0)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine($"{luckyNums}");
}
