using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fiind dată nota unui elev să se afișeze dacă acesta este corigent sau promovat.
            int n;
            Console.WriteLine("Introduceti nota elevului : ");
            n = int.Parse(Console.ReadLine());            
            if (n < 5)
                Console.WriteLine("Elevul este corigent :(");
            else
                Console.WriteLine("Elevul este promovat :)");
            Console.ReadKey();
        }
    }
}
