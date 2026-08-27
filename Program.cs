using System.Text;

string input1 = Console.ReadLine() ?? "";

long count = 0;

for (int i = 0; i < input1.Length; i++)
{
    count += input1[i] - '0';
}

Console.WriteLine(count);