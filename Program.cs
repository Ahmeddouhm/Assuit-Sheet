string[] numsInput = Console.ReadLine().Split();
int a = int.Parse(numsInput[0]);
int b = int.Parse(numsInput[1]);
string input = Console.ReadLine();

//try
//{
//    bool checkLength = input.Length == a + b + 1;
//    bool checkDash = input[a] == '-' && input.Count('-') == 1;
//    bool checkDigits = true;
//    string[] digitsInput = input.Split('-');
//    string pt1 = digitsInput[0];
//    string pt2 = digitsInput[1];

//    for (int i = 0; i < pt1.Length; i++)
//    {
//        if (!char.IsDigit(pt1[i]))
//        {
//            checkDigits = false;
//            break;
//        }
//    }
//    for (int i = 0; i < pt2.Length; i++)
//    {
//        if (!char.IsDigit(pt2[i]))
//        {
//            checkDigits = false;
//            break;
//        }
//    }

//    Console.WriteLine(checkDigits && checkDash && checkLength ? "Yes" : "No");
//}
//catch
//{
//    Console.WriteLine("No");
//}

if (input[a] != '-')
{
    Console.WriteLine("No");
    return;
}

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
        continue;

    if (i != a)
    {
        Console.WriteLine("No");
        return;
    }
}

Console.WriteLine("Yes");