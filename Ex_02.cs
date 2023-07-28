using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            float num_usuario = float.Parse(Console.ReadLine());

            if (num_usuario == 0)
            {
                Console.WriteLine("Seu número é igual a zero");
            } else if(num_usuario > 0)  
            {
                Console.WriteLine("Seu número é Positivo");
            }else
            {
                Console.WriteLine("Seu número é negativo");
            }
            Console.ReadLine();
        }
    }
}
