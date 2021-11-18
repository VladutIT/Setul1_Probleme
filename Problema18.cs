using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n, p = 0, d = 2;
            n = int.Parse(Console.ReadLine());
            while(n!=1)
            {
                p = 0;
                while(n%d==0)
                {
                    n = n / d;
                    p++;
                }
                if(p!=0)
                {
                    Console.Write($"{d}^{p}*");
                }
                d++;
            }
        }
    }
}
