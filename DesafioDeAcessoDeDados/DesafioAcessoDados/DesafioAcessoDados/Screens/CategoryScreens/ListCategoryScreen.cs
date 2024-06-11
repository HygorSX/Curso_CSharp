using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using DesafioAcessoDados.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens.CategoryScreens
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-------------------");

            List();

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach (var category in categories)
                Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");
        }
    }
}
