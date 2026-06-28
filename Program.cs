string inputNum = Console.ReadLine();
string reversedNum = ReverseString(inputNum);

Console.WriteLine(reversedNum.TrimStart('0'));

if (inputNum == reversedNum)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}



static string ReverseString(string text) 
{
    if (text.Length <= 0)
        return string.Empty;

    return ReverseString(text.Substring(1)) + text[0];
}