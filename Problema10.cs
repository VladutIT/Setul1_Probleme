using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n,div=0;
            n = int.Parse(Console.ReadLine());
           for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    div++;
                }
            }
            if(div==2)
            {
                Console.WriteLine("numarul este prim");
            }
            else
            {
                Console.WriteLine("numarul nu este prim");
            }
        }
    }
}
