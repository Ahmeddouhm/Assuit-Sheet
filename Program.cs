string exp = Console.ReadLine();

string[] expOperands = exp.Split('+', '-', '*', '/');
int op1 = int.Parse(expOperands[0]);
int op2 = int.Parse(expOperands[1]);

if (exp.Contains("+"))
{
    Console.WriteLine(op1+op2);
}
else if (exp.Contains("-"))
{
    Console.WriteLine(op1-op2);
}
else if (exp.Contains("*"))
{
    Console.WriteLine(op1*op2);
}
else if (exp.Contains("/"))
{
    Console.WriteLine(op1/op2);
}