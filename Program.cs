using System.Text;

int itrs = int.Parse(Console.ReadLine() ?? "");

while (itrs-- > 0)
{
    string[] s1 = (Console.ReadLine() ?? "").Split();
	string st1 = s1[0];
	string st2 = s1[1];

	int len = Math.Min(st1.Length, st2.Length);

	var sb = new StringBuilder();

    for (int i = 0; i < len; i++)
	{
		sb.Append(st1[i]);
		sb.Append(st2[i]);
	}

	if (st1.Length > st2.Length)
		sb.Append(st1[len..]);
	else
		sb.Append(st2[len..]);

    Console.WriteLine(sb.ToString());
}