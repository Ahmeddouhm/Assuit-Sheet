string num = Console.ReadLine();
int firstDigit = int.Parse(num[0].ToString());
Console.WriteLine(int.IsEvenInteger(firstDigit) ? "EVEN" : "ODD");