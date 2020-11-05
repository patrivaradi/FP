using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care determină minimul a trei numere întregi.
            int n1, n2, n3;
            Console.WriteLine("Introduceti trei numere intregi : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if ((n1 <= n2)&&(n1<=n3))
                Console.WriteLine("Minimul este " + n1);
            if((n2<=n1)&&(n2<=n3))
                Console.WriteLine("Minimul este " + n2);
            if((n3<=n1)&&(n3<=n2))
                Console.WriteLine("Minimul este " + n3);
            Console.ReadKey();
        }
    }
}
