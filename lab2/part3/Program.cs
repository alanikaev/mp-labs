using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.1 //

            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());

            if (x >= y){
                Console.WriteLine("max = "+x);
            }else{
                Console.WriteLine("max = "+y);
            }

            // 3.2 //

            int Ball = 0;
            x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = float.Parse(Console.ReadLine());
            if (x * x + y * y <= 1){ 
                Ball = 10;
            }    
            else if (x * x + y * y <= 4){
                Ball = 5;
            }    
            else if (x * x + y * y <= 9){
                Ball = 1;
            }
            Console.WriteLine("Ball = ", Ball);

            // 3.3 //

            Console.WriteLine("OPER = ");
            char oper = char.Parse(Console.ReadLine());
            bool ok = true;
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            float res = 0;
            switch (oper)
            {
                case '+': res = a + b; goto case '-';
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case ':': if (b != 0) res = (float)a / b; break;
                default: ok = false; break;
            }
            Console.WriteLine((ok) ? $"{a}{oper}{b} = {res}" : "error");

            // 3.4 //

            int n = int.Parse(Console.ReadLine());
            while (n >= 1)
            {
                Console.Write(" " + ((n % 2 == 1) ? "" + n : ""));
                n--;
            }

            // 3.5 //

            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(" " + ((n % 2 == 0) ? "" + n : ""));
                n--;
            } while (n >= 1);

            // 3.6 //

            n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--){
                Console.WriteLine(i * i);
            }   

            // 3.7 //

            n = int.Parse(Console.ReadLine()); 
            Console.Write("M = "); 
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i, Console.WriteLine()){
                for (int j = 1; j <= m; ++j){
                    Console.Write(" " + 2); 
                }    
            }        
        }
    }
}
