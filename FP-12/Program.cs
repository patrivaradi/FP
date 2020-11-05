using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dă un număr natural n. Calculați ultima cifră a lui 9^n.
            Console.Write("Introduceti n : ");
            int n,n1,d;            
            n = int.Parse(Console.ReadLine());
            n1 = 9;
            d =(int)Math.Pow(n1,n);
            Console.WriteLine(d);
            Console.WriteLine("Ultima cifra a lui 9^{0} = {1}",n,d%10);
            Console.ReadKey();


        }
    }
}
