using Blog;
using System.Data.SqlClient;
using DesafioAcessoDados.Screens.TagScreens;
using DesafioAcessoDados.Screens.UserScreens;
using DesafioAcessoDados.Screens.CategoryScreens;
using DesafioAcessoDados.Screens.PostScreens;
using DesafioAcessoDados.Screens;
using DesafioAcessoDados.Repositories;

class Program
{
    private const string _connectionString = @"";

    static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(_connectionString);
        Database.Connection.Open();

        LoadMenu();

        Database.Connection.Close();

        Console.ReadKey();
    }
    private static void LoadMenu()
    {
        Console.Clear();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("-----------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuário");
        Console.WriteLine("2 - Gestão de perfil");
        Console.WriteLine("3 - Gestão de categoria");
        Console.WriteLine("4 - Gestão de tag");
        Console.WriteLine("5 - Gestão de post");
        Console.WriteLine("6 - Vincular perfil/usuário");
        Console.WriteLine("7 - Vincular post/tag");
        Console.WriteLine("8 - Relatórios");
        Console.WriteLine();
        Console.WriteLine();

        int option = int.Parse(Console.ReadLine()!);
        
        switch (option)
        {
            case 1:
                MenuUserScreen.Load();
                break;
            case 3:
                MenuCategoryScreen.Load();
                break;
            case 4:
                MenuTagScreen.Load();
                break;
            case 5:
                MenuPostScreen.Load();
                break;
            case 7:
                PostTag.connectPostTag();
                break;
            default: LoadMenu(); break;
        }
    }
}
