using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            if (idade < 0 || idade > 120)
            {
                Console.WriteLine("ERRO\a, Idade invalida");
            }
            else if (idade <=10)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade <= 18)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (idade <= 50)
            {
                Console.WriteLine("Você é um adulto");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }
                    Console.ReadLine();
                }
            }
}
