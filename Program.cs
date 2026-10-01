int num = int.Parse(Console.ReadLine() ?? "");

int[] arr = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);

Console.WriteLine($"" +
	$"The maximum number : {MaxNum(arr)}\r\n" +
	$"The minimum number : {MinNum(arr)}\r\n" +
	$"The number of prime numbers : {CountPrimes(arr)}\r\n" +
	$"The number of palindrome numbers : {CountPalindromes(arr)}\r\n" +
	$"The number that has the maximum number of divisors : {CountDivisors(arr)}");

int MaxNum(int[] array) => array.Max();
int MinNum(int[] array) => array.Min();

int CountPrimes(int[] array) 
{
	int count = 0;

	for (int i = 0; i < array.Length; i++)
	{
		bool isPrime = true;

		if (array[i] < 2) 
			continue;

		for (int j = 2; j*j <= array[i]; j++)
		{

			if (array[i] % j == 0)
            {
                isPrime = false;
                break;
            }

        }

		if (isPrime)
			count++;
	}

	return count;
}

int CountPalindromes(int[] array) 
{
	int count = 0;

	for (int i = 0; i < array.Length; i++)
	{
		string num = Convert.ToString(array[i]);

		bool isPalindrome = true;

		for (int j = 0; j < num.Length/2; j++)
		{
			if (num[j] != num[num.Length - j - 1])
            {
                isPalindrome = false;
                break;
            }

        }

		if (isPalindrome)
			count++;
	}

	return count;
}

int CountDivisors(int[] array) 
{
	Dictionary<int, int> divs = new();

	for (int i = 0; i < array.Length; i++)
	{
		int count = 0;
		for (int j = 1; j * j <= array[i]; j++)
		{
			if (array[i] % j == 0)
			{
                if (j * j == array[i])
                    count++;
                else
                    count += 2;
            }
		}
		divs[array[i]] = count;
	}

    int maxDivs = 0;
    int result = 0;

    foreach (var item in divs)
    {
        if (item.Value > maxDivs || item.Value == maxDivs && item.Key > result)
        {
            maxDivs = item.Value;
            result = item.Key;
        }
    }

    return result;
}