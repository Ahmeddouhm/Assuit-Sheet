string input = Console.ReadLine();
string[] stringNums = input.Split();

int a = int.Parse(stringNums[0]);
int b = int.Parse(stringNums[2]);
int c = int.Parse(stringNums[4]);

char opeartor = char.Parse(stringNums[1]);

if (opeartor == '+')
{
    int sum = a + b;
    Console.WriteLine((sum == c) ? "Yes" : sum);
}
else if (opeartor == '-')
{
    int diff = a - b;
    Console.WriteLine(diff == c ? "Yes" : diff);

}
else if (opeartor == '*')
{
    int mtply = a * b;
    Console.WriteLine(mtply == c ? "Yes" : mtply);

}