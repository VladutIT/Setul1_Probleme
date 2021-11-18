using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int y1, y2;
            y1 = int.Parse(Console.ReadLine());
            y2= int.Parse(Console.ReadLine());
            for(int i=y2;i<=y2;i++)
            {
                if((i%4==0 && i%100!=0)||i%400==0)
                {
                    Console.WriteLine($"{i} este an bisect");
                }
            }
        }
    }
}
