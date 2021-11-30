using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int a=-1, b=-1, n,cnt=1,c;
            n = int.Parse(Console.ReadLine());
            a = n % 10;
            c = n;
            while(n!=0)
            {
                if(n%10!=a)
                {
                    b = n % 10;
                    cnt--;
                }
                n = n / 10;
            }
            if(cnt==0)
            {
                Console.WriteLine($"Numarul {c} este format doar din cifrele {a} si {b}");
            }
            else
            {
                Console.WriteLine("Numarul este format din mai mult de 2 cifre");
            }
        }
    }
}
