char c = char.Parse(Console.ReadLine());

Console.WriteLine(char.IsAsciiDigit(c) ? "IS DIGIT" : char.IsAsciiLetterUpper(c) ? "ALPHA\r\nIS CAPITAL" : "ALPHA\r\nIS SMALL");