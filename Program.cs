using System.Text;

while (true)
{
    string[] inputNums = Console.ReadLine().Split();

    int num1 = int.Parse(inputNums[0]);
    int num2 = int.Parse(inputNums[1]);
    StringBuilder numsInBetween = new();

    if (num1 <= 0 || num2 <= 0)
        break;

    int start = Math.Min(num1,num2);
    int end = Math.Max(num1,num2);

    for (int i = start; i <= end; i++)
    {
        numsInBetween.Append(i+" ");
    }

    int sum = 0;

    for (int i = start; i <= end; i++)
        sum += i;

    Console.WriteLine($"{numsInBetween.ToString()}sum ={sum}");
}