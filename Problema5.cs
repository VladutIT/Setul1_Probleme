using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int nr, k, cnt=0;
            nr = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            while(nr!=0)
            {
                cnt++;
                if(cnt==k)
                {
                    Console.WriteLine(nr % 10);
                }
                nr = nr / 10;
            }
        }
    }
}
