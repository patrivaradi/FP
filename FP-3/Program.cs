using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se scrie un program care citeşte de la tastatură un număr natural cu exact două cifre și determină suma cifrelor sale.
            Console.Write("Introduceti un numar natural din 3 cifre : ");
            int n = int.Parse(Console.ReadLine());
            int c1 = n / 100;
            int c2 = (n % 100) / 10;
            int c3 = n % 10;
            Console.WriteLine("{0}+{1}+{2}={3}",c1,c2,c3,(c1+c2+c3));
        }
    }
}
