int[] input = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
int n = input[0], x = input[1];
int[] array = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
List<int> ints = new List<int>(array);

int shiftTimes = x % n;

Shift_Right_Array(array, shiftTimes);
Print_Array(ints);

void Shift_Right_Array(int[] array, int shifts)
{
    for (int i = 0; i < shifts; i++)
    {
        ints.Insert(0,ints[ints.Count - 1]);
        ints.RemoveAt(ints.Count - 1);
    }
}
void Print_Array(List<int> array) 
{
    for (int i = 0; i < array.Count; i++)
        Console.Write($"{array[i]} ");
}