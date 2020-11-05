using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care determină maximul a două numere întregi citite de la tastatură.
            int n1,n2;
            Console.WriteLine("Introduceti doua numere intregi : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1>n2)
                Console.WriteLine("Maximul este "+n1);
            else
                Console.WriteLine("Maximul este "+n2);
            Console.ReadKey();
        }
    }
}
