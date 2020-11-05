using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citeşte de la tastatură un număr natural şi verifică dacă numărul este par sau impar.
            int n;
            Console.WriteLine("Introduceti un numar natural : ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Numarul este par.");
            else
                Console.WriteLine("Numarul este impar.");
            Console.ReadKey();
        }
    }
}
