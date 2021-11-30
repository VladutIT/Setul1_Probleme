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
            int n;
            n = int.Parse(Console.ReadLine());
            if((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

    }
}