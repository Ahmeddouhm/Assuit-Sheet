string[] stringNums = Console.ReadLine().Split();

Int128 a = Int128.Parse(stringNums[0]);
Int128 b = Int128.Parse(stringNums[1]);
Int128 c = Int128.Parse(stringNums[2]);
Int128 d = Int128.Parse(stringNums[3]);

string strResult = (a * b * c * d).ToString();

Console.WriteLine($"{strResult[^2..]}");