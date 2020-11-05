using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citeşte de la tastatură cele trei note ale unui elev și determină media lor.
            Console.WriteLine("Introduceti 3 note ale elevului : ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int c1 = (n1 + n2 + n3) / 3;
            Console.WriteLine("Media este : {0}", c1);
            Console.ReadKey();
        }
    }
}
