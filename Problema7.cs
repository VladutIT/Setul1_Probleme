using System;

namespace Setul1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int a, b, aux = 0;
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
        }
    }
}
