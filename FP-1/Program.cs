using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citeşte de la tastatura două numere naturale şi determină suma lor.
            int n1, n2;
            Console.WriteLine("Introduceti 2 numere naturale pentru a primi suma lor");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + n2);
            Console.ReadKey();
        }
    }
}
