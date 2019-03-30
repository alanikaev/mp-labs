using System;

namespace ComplexClass
{
    public class Complex
    {
        double re,im;

        public Complex(double r, double i){
            re = r;
            im = i;
        }

        public static Complex sum(Complex C1, Complex C2){
            return new Complex(C1.re + C2.re, C1.im + C2.im);
        }

        public override string ToString(){
            return $"re: {re}, im: {im}";
        }
    }
}