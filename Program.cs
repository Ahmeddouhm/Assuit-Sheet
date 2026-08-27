using System.Text;

string input1 = Console.ReadLine() ?? "";
string input2 = Console.ReadLine() ?? "";

Console.WriteLine($"{input1.Length} {input2.Length}");

Console.WriteLine($"{input1}{input2}");

Console.WriteLine(Swap(input1, input2));

string Swap(string s1, string s2) 
{
    char[] chars1 = s1.ToCharArray();
    char[] chars2 = s2.ToCharArray();

    (chars1[0], chars2[0]) = (chars2[0], chars1[0]);

    string output1 = new(chars1);
    string output2 = new(chars2);

    return $"{output1} {output2}";
}
