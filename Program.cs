int itrs = int.Parse((Console.ReadLine() ?? ""));
double[] input = Array.ConvertAll((Console.ReadLine() ?? "").Split(), double.Parse);

Console.WriteLine($"{Avg(input):F6}");
double Avg(double[] arr) 
{
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];

    return sum / arr.Length;
}