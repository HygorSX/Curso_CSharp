﻿using Blog;
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
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma categoria");
            Console.WriteLine("---------------------");
            Console.Write("Qual o ID da categoria que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}