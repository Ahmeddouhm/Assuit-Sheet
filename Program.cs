string input = Console.ReadLine();
string[] stringNums = input.Split();
int a = int.Parse(stringNums[0]);
int b = int.Parse(stringNums[2]);
char opeartor = char.Parse(stringNums[1]);

if (opeartor == '<')
{
    Console.WriteLine(a < b ? "Right" : "Wrong");
}
else if (opeartor == '=')
{
    Console.WriteLine(a == b ? "Right" : "Wrong");

}
else if (opeartor == '>')
{
    Console.WriteLine(a > b ? "Right" : "Wrong");

}