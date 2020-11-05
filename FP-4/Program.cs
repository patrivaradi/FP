using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculați ultima cifră a sumei a două numere naturale.
            int n1, n2, c;
            Console.WriteLine("Introduceti 2 numere naturale: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            c = ((n1 + n2) % 10);
            Console.WriteLine("Suma lor = {0}", n1+n2);
            Console.WriteLine("Ultima cifra a sumei = {0}",c);
            Console.ReadKey();
        }
    }
}
