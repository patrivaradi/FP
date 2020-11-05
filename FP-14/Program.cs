using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se dau două numere naturale și un simbol pentru una dintre operațiile +, -, *, /.
             * Să se determine rezultatul operației aplicate pentru cele două numere.*/
            
            int n1, n2;
            Console.WriteLine("Introduceti 2 numere naturale "); 
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("si un simbol pentru una dintre operațiile +, -, *, /.");
            char s =char.Parse(Console.ReadLine());
            if (s == '+')
                Console.WriteLine(n1+n2);
            if (s == '-')
                Console.WriteLine(n1 - n2);
            if (s == '*')
                Console.WriteLine(n1 * n2);
            if (s == '/')
                Console.WriteLine(n1 / n2);            
            Console.ReadKey();
        }
    }
}
