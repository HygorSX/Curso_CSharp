using Dapper;
using Dapper.Contrib.Extensions;
using ProjetoAcessoDados.Models;
using ProjetoAcessoDados.Repositories;
using System.Data.SqlClient;

namespace ProjetosAcessosDados
{
    class Program
    {
        private const string connection_string = @"Data Source = 192.168.222.243; Initial Catalog = Blog; User ID = sa; Password = sa;Connect Timeout = 30; Encrypt=true;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            var conn = new SqlConnection(connection_string);    
            conn.Open();

            ReadRoles(conn);
            ReadUsers(conn);
            ReadTags(conn);

            conn.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach ( var item in items )
                Console.WriteLine(item.Name);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }
    }
}
