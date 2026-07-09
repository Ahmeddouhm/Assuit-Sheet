int itr = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();
string key = Console.ReadLine();
bool isFound = false;
int counter = 0;

while (!isFound)
{
	if (counter == nums.Length && !isFound)
	{
        Console.WriteLine(-1);
		break;
	}

	if (key == nums[counter])
	{
        Console.WriteLine(counter);
		isFound = true;
	}


	counter++;
}