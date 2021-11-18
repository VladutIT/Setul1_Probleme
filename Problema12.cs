using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int a, b, n;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine()); 
            for(int i=a;i<=b;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
