using Dapper;
using Dapper.Contrib.Extensions;
using ProjetoAcessoDados;
using System.Data.SqlClient;

namespace ProjetosAcessosDados
{
    class Program
    {
        private const string connection_string = @"Data Source = 192.168.222.243; Initial Catalog = Blog; User ID = sa; Password = sa;Connect Timeout = 30; Encrypt=true;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            UpdateUser();
        }

        public static void ReadUsers()
        {
            using (var conn = new SqlConnection(connection_string))
            {
                var users = conn.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void ReadUser()
        {
            using (var conn = new SqlConnection(connection_string))
            {
                var user = conn.Get<User>(4);
                Console.WriteLine(user.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "Equipe balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe balta.io",
                PasswordHash = "Hash",
                Slug = "equipe-balta"
            };

            using (var conn = new SqlConnection(connection_string))
            {
                conn.Insert<User>(user);
                Console.WriteLine("Cadastro finalizado com sucesso");
            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 4,
                Bio = "Equipe balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe balta.io",
                PasswordHash = "Hash",
                Slug = "equipe-balta"
            };

            using (var conn = new SqlConnection(connection_string))
            {
                conn.Update<User>(user);
                Console.WriteLine("Atualização finalizada com sucesso");
            }
        }

        public static void DeleteUser()
        {
            var user = new User()
            {
                Id = 2
            };

            using (var conn = new SqlConnection(connection_string))
            {
                conn.Delete<User>(user);
                Console.WriteLine("Usuário deletado com sucesso");
            }
        }
    }
}
