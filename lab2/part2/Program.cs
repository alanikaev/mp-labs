using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 3, k = 4;
            Console.WriteLine("{0},{1}", d, k);
            Console.WriteLine("{0},{1}", ++d, --k);
            Console.WriteLine("{0},{1}", d++, k--);
            Console.WriteLine("{0},{1}", d, k);

            d = 3;
            k = 4;
            bool y = true, n = false;
            Console.WriteLine("{0},{1}", -d, -k);
            Console.WriteLine("{0},{1}", !y, !n);

            int i = -4;
            byte j = 4;
            int a = (int)j;
            byte b = (byte)i;
            Console.WriteLine("{0},{1}", a, b);

            int x = 100, c = 15;
            double o = 14.2, p = 3.5;
            Console.WriteLine("{0} {1} {2}", x* c, x/ c, x % c);
            Console.WriteLine("{0} {1} {2}", o* p, o / p, o % p);

            int w = 15, e = 15;
            Console.WriteLine(i < j);
            Console.WriteLine(i <= j);
            Console.WriteLine(i > j);
            Console.WriteLine(i >= j);
            Console.WriteLine(i == j);
            Console.WriteLine(i != j);

            Console.WriteLine("x     y     x и y    x или y");
            Console.WriteLine("{0} {1} {2} {3}", false, false, false && false, false || false);
            Console.WriteLine("{0} {1} {2} {3}", false, true, false && true, false || true);
            Console.WriteLine("{0} {1} {2} {3}", true, false, true && false, true || false);
            Console.WriteLine("{0} {1} {2} {3}", true, true, true && true, true || true);

            int m = 5; int l = 10;
            int max = (m > l) ? m : l;
            Console.WriteLine(max);
        }
    }
}
