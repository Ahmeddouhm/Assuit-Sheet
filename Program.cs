char c = char.Parse(Console.ReadLine());

Console.WriteLine(char.IsAsciiLetterUpper(c) ? $"{char.ToLower(c)}" : $"{char.ToUpper(c)}");