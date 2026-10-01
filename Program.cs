Int128 num = Int128.Parse(Console.ReadLine() ?? "");

Console.WriteLine((num > 0 && (num & (num - 1)) == 0 ) ? "YES" : "NO");