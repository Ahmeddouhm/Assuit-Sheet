long ageInDays = long.Parse(Console.ReadLine());
long days, months, years , livedYears;

years = ageInDays / 365;
livedYears = ageInDays - years * 365;
months = livedYears / 30;
days = livedYears - (months * 30);

Console.WriteLine($"{years} years");
Console.WriteLine($"{months} months");
Console.WriteLine($"{days} days");