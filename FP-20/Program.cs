using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_20
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, p, ar, d;
            Console.WriteLine("a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            c = float.Parse(Console.ReadLine());
            p = (float)(a + b + c) / 2;
            d = (float)(p * (p - a) * (p - b) * (p - c));
            ar = ((float)Math.Sqrt(d));
            Console.WriteLine("Aria triunghiului:{0:0.00}", ar);
            Console.ReadKey();
        }
    }
}
