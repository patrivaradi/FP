using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieți un program care citește de la tastatură un număr natural de două cifre 
             * și care afișează pe ecran pătratul valorii obținute prin schimbarea între ele a celor două cifre.*/
            Console.Write("Introduceti un numar natural de 2 cifre : ");
            int n = int.Parse(Console.ReadLine());
            int c1 = n / 10;
            int c2 = n % 10;
            int n2=c1+10*c2;
            Console.WriteLine("Inversul este = "+n2);
            Console.WriteLine(" {1}{0}^2 = {2}", c1, c2,(Math.Pow(n2,2)));
            Console.ReadKey();
        }
    }
}
