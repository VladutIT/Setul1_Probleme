using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n, ogl = 0,a=0;
            n = int.Parse(Console.ReadLine());
            a = n;
            while(a!=0)
            {
                ogl = ogl * 10 + a % 10;
                a = a / 10;
            }
            if(n==ogl)
            {
                Console.WriteLine("numarul este palindrom");
            }
        }
    }
}
