using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade >= 5 && Idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (Idade >= 8 && Idade <= 10)
            {
                Console.WriteLine("Infaltil B");
            }
            else if (Idade >= 11 && Idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (Idade >= 14 && Idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else if (Idade >= 18 && Idade <= 110)
            {
                Console.WriteLine("Senior");
            }
            else
                Console.WriteLine("[ERRO!]Idade inválida\a");
                Console.ReadLine();
        }
    }
}

