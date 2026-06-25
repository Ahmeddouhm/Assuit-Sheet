bool isCorrect = false;
string password = "1999";

do
{
    string inputPassword = Console.ReadLine();
	if (inputPassword == password)
	{
		Console.WriteLine("Correct");
		isCorrect = true;
	}
	else
	{
        Console.WriteLine("Wrong");
	}
}
while (!isCorrect);