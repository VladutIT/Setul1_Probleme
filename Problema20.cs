using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2611
{
    class Program
    {
        static void Main(string[] args)
        {

            fractie2();
        }

        
        private static void ScaraNumerelor()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
        }

  
        private static void AfisareTr()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // afisez linia i pe care am numerele de la 1 la i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

     
        private static void PatratPerfect2()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int nrDivizori = 2; // pt ca orice numar n se divide cu 1 si n
            for (int d = 2; d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    nrDivizori++;
                }
            }
            if (nrDivizori % 2 == 1)
            {
                Console.WriteLine("Patrat perfect");
            }
            else
                Console.WriteLine("Nu e patrat perfect");
        }

    
        private static void PatratPerfect1()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int sq = (int)(Math.Sqrt(n));
            if (sq * sq == n)
            {
                Console.WriteLine("Patrat perfect");
            }
            else
                Console.WriteLine("Nu e patrat perfect");
        }


        
        private static void AfisarePuteri()
        {
            int n, p;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            int putere = 1;
            do
            {
                Console.Write($"{putere} ");
                putere *= n;
            } while (putere <= p);

        }

      
        private static void fractie2()
        {
            int m = 13, n = 30;
            
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        
        private static void fractie()
        {
            int m = 13;
            int n = 30;
            double d;

            d = (double)m / n;
            Console.WriteLine(d);

            double fract = d - Math.Truncate(d);

            int maxDecimal = 6;
            while (maxDecimal > 0 && fract != 0)
            {
                
                int cifraZecimala;
                cifraZecimala = (int)Math.Truncate(fract * 10);
                Console.WriteLine($"{cifraZecimala} ");


                fract = fract * 10 - Math.Truncate(fract * 10);


                maxDecimal--;
            }
        }
    }
}