using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro número:");
            int num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu segundo número");
            int num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (num01 < (num02 - 1)) 
            {
                num01++;
                Console.WriteLine(num01);
            }
            Console.ReadLine();   
        }
    }
}
