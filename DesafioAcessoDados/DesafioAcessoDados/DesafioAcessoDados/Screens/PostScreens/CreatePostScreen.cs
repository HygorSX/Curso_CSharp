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
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("---------");

            Console.Write("Id da categoria: ");
            var id_category = Console.ReadLine();

            Console.Write("Id do autor: ");
            var id_author = Console.ReadLine();

            Console.Write("Titulo: ");
            var title = Console.ReadLine();

            Console.Write("Sumário: ");
            var summary = Console.ReadLine();

            Console.Write("Body: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();


            //Pedir ajuda do vini para fazer o envio das datas corretamente
            //DateTime createdate = DateTime.Now;

            Create(new Post
            {
                CategoryId = id_category,
                AuthorId = id_author,
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                //CreateDate = createdate,
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
