string itrs = (Console.ReadLine() ?? "");
int[] input = Array.ConvertAll((Console.ReadLine() ?? "").Split(),int.Parse);
Max_Min(input);
void Max_Min(int[] arr) 
{
    Console.WriteLine($"{arr.Min()} {arr.Max()}");
}