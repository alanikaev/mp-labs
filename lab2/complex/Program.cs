using System;
using ComplexClass;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1,1);
            Complex t2 = new Complex(2,3);
            Complex t3 = Complex.sum(t1, t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
