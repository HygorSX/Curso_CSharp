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
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um usuário");
            Console.WriteLine("----------------------");

            Console.Write("Digite o ID do usuário que deseja atualizar: ");
            int id_usu = int.Parse(Console.ReadLine());

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

            Update(new User
            {
                Id = id_usu,
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = url_imagem,
                Slug = slug
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("usuário atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
