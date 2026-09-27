int n = int.Parse(Console.ReadLine() ?? "");
int[] a = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);

Shift_Zeros(a);

void Shift_Zeros(int[] array)
{
    int idx = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] != 0)
        {
            (array[i], array[idx]) = (array[idx], array[i]);
            idx++;
        }
    }

	foreach (var x in array)
        Console.Write($"{x} ");
}