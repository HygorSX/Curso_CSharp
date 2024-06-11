using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens.PostScreens
{
    public class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um Post");
            Console.WriteLine("---------------");
            Console.Write("Qual o ID do Post que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Post exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
