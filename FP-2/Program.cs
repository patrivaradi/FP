using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 2 numere naturale. Calculați suma, diferenţa, produsul şi câtul lor, în această ordine.
            int n1, n2;
            Console.WriteLine("Introduceti 2 numere naturale :");
            n1=int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",n1,n2,n1+n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2,n1-n2);
            Console.WriteLine("{0} * {1} = {2}", n1, n2, n1*n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            Console.ReadKey();
        }
    }
}
