using DesafioAcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioAcessoDados.Repositories;
using Blog;

namespace DesafioAcessoDados.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("Novo usuário");
            Console.WriteLine("------------");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Senha: ");
            string password = Console.ReadLine();

            Console.Write("Bio: ");
            string bio = Console.ReadLine();

            Console.Write("Url da sua imagem: ");
            string url_imagem = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = url_imagem,
                Slug =  slug
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
