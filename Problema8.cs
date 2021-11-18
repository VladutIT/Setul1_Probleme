using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"{a},{b}");
        }
    }
}
