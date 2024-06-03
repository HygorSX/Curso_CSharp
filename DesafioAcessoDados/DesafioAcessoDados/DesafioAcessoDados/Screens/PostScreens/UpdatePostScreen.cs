using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using DesafioAcessoDados.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens.PostScreens
{
    public class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Post");
            Console.WriteLine("-------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.Write("Body: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            DateTime lastUpdate = DateTime.Now;

            int IdPostEditado = int.Parse(id);

            var repository = new Repository<Post>(Database.Connection);
            Post postEditavel = repository.Get().Where(p => p.Id == IdPostEditado).FirstOrDefault();

            if (postEditavel == null)
            {
                Console.WriteLine("Post não encontrado");
                return;
            }

            postEditavel.Id = IdPostEditado;
            postEditavel.Title = title;
            postEditavel.Summary = summary;
            postEditavel.Body = body;
            postEditavel.Slug = slug;
            postEditavel.LastUpdateDate = lastUpdate;


            Update(postEditavel); 

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
