using System;

namespace CalculadoraFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = CalcularFatorial(numero);

            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }

        static int CalcularFatorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                int fatorial = 1;
                for (int i = num; i >= 1; i--)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
             Console.ReadLine();
            
        }
    }  
}
