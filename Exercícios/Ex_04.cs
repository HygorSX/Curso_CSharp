using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numusuario = int.Parse(Console.ReadLine());
            int num = 0;

            while(num<numusuario)
            {
                num++;
                Console.WriteLine(num);
            }
            Console.ReadLine();
 
        }
    }
}
