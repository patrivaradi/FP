using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Să se scrie un program care citeşte de la tastatură un număr natural cu exact trei cifre 
             * şi determină numărul obţinut prin eliminarea cifrei din mijloc.*/
            Console.Write("Introduceti un numar natural din 3 cifre : ");
            int n = int.Parse(Console.ReadLine());
            int c1 = n / 100;
            int c2 = n % 10;
            Console.WriteLine("Numarul obtinut prin eliminarea cifrei din mijloc = {0}{1}", c1, c2);
            Console.ReadKey();
        }
    }
}
