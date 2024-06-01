using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um usuário");
            Console.WriteLine("------------------");
            Console.Write("Qual o id do usuário que deseja exluir? ");

            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
            var repository = new Repository<User>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Usuário deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
