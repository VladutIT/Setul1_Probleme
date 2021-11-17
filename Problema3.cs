using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if(n%k==0)
            {
                Console.WriteLine("se divide");
            }
            else
            {
                Console.WriteLine("nu se divide");
            }
        }
    }
}
