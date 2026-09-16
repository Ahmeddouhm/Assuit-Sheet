using System.Text;

string org = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
string key = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/";

string option = Console.ReadLine() ?? "";
string s = Console.ReadLine() ?? "";

var sb = new StringBuilder();

string from = option == "1" ? org : key;
string to = option == "1" ? key : org;

for (int i = 0; i < s.Length; i++)
{
    int idxOfS = from.IndexOf(s[i]);

    sb.Append(to[idxOfS]);
}

Console.WriteLine(sb.ToString());