string[] inputNums = Console.ReadLine().Split();

int n = int.Parse(inputNums[0]);
int a = int.Parse(inputNums[1]);
int b = int.Parse(inputNums[2]);
int sum = 0;

for (int i = a; i <= n; i++)
{
    int sumOfDigits = SumOfDigits(i);

    if (sumOfDigits >= a && sumOfDigits <= b)
    {
        sum += i;
    } 
}

Console.WriteLine(sum);

static int SumOfDigits(int num) 
{
    string strNum = num.ToString();
    int sum = 0;

    for (int i = 0; i < strNum.Length; i++)
    {
        int lastDigit = num % 10;
        num /= 10;
        sum += lastDigit;
    }

    return sum;
}