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
            if (a > 0 && b > 0 && c >0)
            {
                if (a == b || a == c)
                {
                    if (b > a && b > c || c > a && c > b)
                    {
                        Console.WriteLine("a b c sunt laturile unui triunghi");
                    }
                }
            }
        }
    }
}
