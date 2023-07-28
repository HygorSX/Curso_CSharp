using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu sexo? (feminino ou masculino)");
            string sexo = Console.ReadLine();
            string masc = "masculino";
            string fem = "feminino";

            if (sexo == masc)
            {
                float pesoideal = (72.7f * altura) - 58f;
                Console.WriteLine("O seu peso ideal é " + pesoideal + "KG");
            } else
            {
                float pesoideal = (62.1f * altura) - 58f;
                Console.WriteLine("O seu peso ideal é " + pesoideal + "KG");
            }
            Console.ReadLine();
        }
        }
}
