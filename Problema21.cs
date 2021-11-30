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
            int x,a=0;
            x = int.Parse(Console.ReadLine());
          for(int i=1;i<=1024;i++)
            {
                if(i>x)
                {
                    if(i==x)
                    {
                        i = x;
                    }
                    i = x;
                    a = i;
                }
            }
            Console.WriteLine($"Numarul este {a}");
        }

    }
}