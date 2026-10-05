long[] nums = Array.ConvertAll((Console.ReadLine() ?? "").Split(), long.Parse);

long a = nums[0], b = nums[1], q = nums[2];
long itr = q % 3;

if (itr == 1)
    Console.WriteLine(a);
else if (itr == 2)
    Console.WriteLine(b);
else if (itr == 0)
    Console.WriteLine(a ^ b);
