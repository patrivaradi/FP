using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau trei numere naturale a b x. Să se verifice dacă numărul x aparține intervalului [a,b].
            int x, a, b;
            Console.Write("Introduceti primul nr al intervalului : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti ultimul nr al intervalului : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul, pentru care doriti sa aflati daca este in intervalul dat : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if ((x >= a) && (x <= b))
                Console.WriteLine("Numarul dat se afla in interval.");
            else
                Console.WriteLine("Numarul dat nu se afla in interval.");
            Console.ReadKey();
        }
    }
}
