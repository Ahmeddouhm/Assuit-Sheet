int[] s = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
Console.WriteLine(Add(s[0], s[1]));
int Add(int num1, int num2) => num1 + num2;