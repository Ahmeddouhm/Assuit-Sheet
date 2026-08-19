string[] len = Console.ReadLine().Split();

int arrLen = int.Parse(len[0]);
int maxNum = int.Parse(len[1]);

string[] arr = Console.ReadLine().Split();

int[] ints = Array.ConvertAll(arr, int.Parse);

int[] frq = new int[maxNum+1];

for (int i = 0; i < arrLen; i++)
{
    int index = ints[i];
    frq[index]++;
}

for (int i = 1; i < frq.Length; i++)
{
    Console.WriteLine(frq[i]);
}