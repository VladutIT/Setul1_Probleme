using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            double a, b, c, x, delta;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            x = (-b + Math.Sqrt(delta)) / 2*a;
            Console.WriteLine(x);
            x = (-b - Math.Sqrt(delta)) / 2 * a;
            Console.WriteLine(x);
        }
    }
}
