
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
                Console.WriteLine("Qual o seu salário?");
                float sal = float.Parse(Console.ReadLine());

                if (sal <= 300)
                {
                    float salReajuste = sal * 0.5f;
                    float salReajustado = sal - salReajuste;
                    Console.WriteLine("O seu salário reajustado é: " +salReajustado);

                }
                else
                {
                    float salReajuste = sal * 0.3f;
                    float salReajustado = sal - salReajuste;
                    Console.WriteLine("O seu salário reajustado é: " + salReajustado);

            }
            
                Console.ReadLine();
            }
        }
    }
