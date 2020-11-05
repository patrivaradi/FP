using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fiind date vârstele a doi copii afișați care dintre ei este cel mai mare și cu cât.
            int n1, n2;
            Console.WriteLine("Introduceti varsta primului copil : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti varsta al doilea copil : ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine("Primul copil este mai mare cu {0} ani",n1-n2);
            else
                Console.WriteLine("Al doilea copil este mai mare cu {0} ani",n2-n1);
            Console.ReadKey();
        }
    }
}
