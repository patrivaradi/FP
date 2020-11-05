using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citește de la tastatură un număr natural de 3 cifre. Să se stabilească dacă are toate cifrele egale.
            Console.Write("Introduceti un numar natural din 3 cifre : ");
            int n = int.Parse(Console.ReadLine());
            int c1 = n / 100;
            int c2 = (n % 100) / 10;
            int c3 = n % 10;
            if ((c1 == c2) && (c2 == c3))
                Console.WriteLine("Cifrele numarului sunt egale : {0}", c1);
            else Console.WriteLine("Cifrele numarului difera.");
            Console.ReadKey();
        }
    }
}
