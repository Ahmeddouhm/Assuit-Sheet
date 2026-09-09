long[] count = new long[26];
int itrs = int.Parse(Console.ReadLine() ?? "");

int c;
while (itrs > 0)
{
    c = Console.Read();
    if (c >= 'a' && c <= 'z')
    {
        count[c - 'a']++;
    }
    itrs--;
}

for (int i = 0; i < count.Length; i++)
{
    for (int j = 0; j < count[i]; j++)
    {
        if (count[i] > 0)
        {
            Console.Write((char)(i + 'a'));
        }
    }
}