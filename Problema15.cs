using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            if(a>=b && a>=c)
            {
                Console.WriteLine(a);
            }
            if(b>=a && c>=a)
            {
                Console.WriteLine(b);
            }
            if(c>=b && c>=a)
            {
                Console.WriteLine(c); 
            }
        }
    }
}
