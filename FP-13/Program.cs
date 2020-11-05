using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere naturale, fiecare având câte două cifre. Afișați-le pe acelea care au suma cifrelor maximă.
            int n1, n2, n3, c1, c2,c3,c4,c5,c6;
            Console.WriteLine("Introduceti 3 numere naturale cu 2 cifre : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            c1 = n1 / 10;
            c2 = n1 % 10;
            c3 = n2 / 10;
            c4 = n2 % 10;
            c5 = n3 / 10;
            c6 = n3 % 10;

            if (((c1+c2) >= (c3+c4))&&((c1+c2)>=(c5+c6)))
                 Console.WriteLine("{0} are suma cifrelor maxima." , n1);                
            if (((c3 + c4) >= (c5 + c6)) && ((c3 + c4) >= (c1 + c2)))
                Console.WriteLine("{0} are suma cifrelor maxima." , n2);
            if (((c5 + c6) >= (c1 + c2))&& ((c5 + c6) >= (c3 + c4)))
                Console.WriteLine("{0} are suma cifrelor maxima." , n3);
            Console.ReadKey();
        }
    }
}
