float num = float.Parse(Console.ReadLine());

int intPart = (int)num;

float fPart = num - intPart;

Console.WriteLine(fPart == 0 ? $"int {intPart}" : $"float {intPart} {fPart.ToString("F3")}");