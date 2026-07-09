using System.Text;

int itr = int.Parse(Console.ReadLine());

for (int i = 0; i < itr; i++)
{
    StringBuilder onesInBinary = new();

    int dec = int.Parse(Console.ReadLine());

    string binary = Convert.ToString(dec, 2);

    for (int j = 0; j < binary.Length; j++)
    {
        if (binary[j] == '1')
            onesInBinary.Append("1");
    }

    Console.WriteLine(Convert.ToInt32(onesInBinary.ToString(),2));
}
