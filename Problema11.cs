using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            
        }
    }
}
