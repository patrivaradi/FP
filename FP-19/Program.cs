using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_19
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, ma, mg;
            Console.WriteLine("a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = float.Parse(Console.ReadLine());
            ma = (a + b) / 2;
            Console.WriteLine("Media aritmetica:{0:0.00}", ma);
            mg = ((float)Math.Sqrt(a * b));
            Console.WriteLine("Media geometrica:{0:0.00}", mg);
            Console.ReadKey();
        }
    }
}
