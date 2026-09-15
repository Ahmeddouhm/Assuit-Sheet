string s = new (Console.ReadLine() ?? "");

int questionMarkIndex = s.IndexOf('?');
string[] parameters = s.Substring(questionMarkIndex + 1).Split('&');

string username = parameters[0].Substring(9);
string pwd = parameters[1].Substring(4);
string profile = parameters[2].Substring(8);
string role = parameters[3].Substring(5);
string key = parameters[4].Substring(4);

Console.WriteLine($"username: {username}");
Console.WriteLine($"pwd: {pwd}");
Console.WriteLine($"profile: {profile}");
Console.WriteLine($"role: {role}");
Console.WriteLine($"key: {key}");
