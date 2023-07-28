using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}
        static void Main(string[] args)
        {

            //MODELO DE MENU COM "ENUM"


            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
           Opcao opcaoselecionada = (Opcao)index;

            switch(opcaoselecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
               case Opcao.Deletar:
                    Console.WriteLine("Delete imediatamente!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você editará algo!");
                    break;
              case Opcao.Listar:
                   Console.WriteLine("Você listará algo!");
                   break;
                case Opcao.Atualizar:
                  Console.WriteLine("Você atualizará algo!");
                   break;
            }

        }
    }
}
