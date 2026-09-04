string[] nums = (Console.ReadLine() ?? "").Split();
string s = (Console.ReadLine() ?? "");

int n = int.Parse(nums[0]);
int q = int.Parse(nums[1]);

for (int i = 0; i < q; i++)
{
    string qryInput = (Console.ReadLine() ?? "");
    string[] qrySplitted = qryInput.Split();
    string qry = qrySplitted[0];

    switch (qry)
    {
        case "pop_back":
            s = s[..^1];
            break;
        case "front":
            Console.WriteLine($"{s[0]}");
            break;
        case "back":
            Console.WriteLine($"{s[^1]}");
            break;
        case "push_back":
            string x = qrySplitted[1];
            s += x;
            break;
        case "sort":
            int lsort = int.Parse(qrySplitted[1]);
            int rsort = int.Parse(qrySplitted[2]);
            if (lsort > rsort)
            {
                (lsort, rsort) = (rsort, lsort);
            }
            char[] sToArr = s[(lsort-1)..rsort].ToCharArray();
            Array.Sort(sToArr);
            s = s[..(lsort-1)] + new string (sToArr) + s[rsort..];
            break;
        case "substr":
            int l = int.Parse(qrySplitted[1]);
            int r = int.Parse(qrySplitted[2]);
            if (l > r)
            {
                (l, r) = (r, l);
            }
            Console.WriteLine(s[(l-1)..r]);
            break;
        case "reverse":
            int lreverse = int.Parse(qrySplitted[1]);
            int rreverse = int.Parse(qrySplitted[2]);
            if (lreverse > rreverse)
            {
                (lreverse, rreverse) = (rreverse, lreverse);
            }
            char[] sToArr2 = s[(lreverse-1)..rreverse].ToCharArray();
            Array.Reverse(sToArr2);
            s = s[..(lreverse-1)] + new string(sToArr2) + s[rreverse..];
            break;
        case "print":
            int pos = int.Parse(qrySplitted[1]);
            Console.WriteLine(s[pos-1]);
            break;
    }
}