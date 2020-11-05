using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un număr n. Calculați ultima cifră a lui 2n.
            Console.Write("Introduceti n : ");
            int n, n1, d;
            n = int.Parse(Console.ReadLine());
            n1 = 2;
            d = (int)Math.Pow(n1, n);
            Console.WriteLine(d);
            Console.WriteLine("Ultima cifra a lui 2^{0} = {1}", n, d % 10);
            Console.ReadKey();
        }
    }
}
