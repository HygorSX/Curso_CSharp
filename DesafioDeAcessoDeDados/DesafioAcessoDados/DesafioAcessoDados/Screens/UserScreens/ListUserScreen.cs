using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using DesafioAcessoDados.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-----------------");

            List();

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name} - {user.Bio}");
            }
        }
    }
}
