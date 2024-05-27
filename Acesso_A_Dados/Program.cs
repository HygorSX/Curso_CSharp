using System.Data;
using System.Data.SqlClient;
using AcessoAosDados;
using Dapper;
class Program
{
    static void Main(string[] args)
    {

        /*
        const string connectionString = @"Server=DESKTOP-73M6QT8\MSSQLSERVER01;Database=balta_curso;Integrated Security=True;";

        using (var connection = new SqlConnection(connectionString))
        {
            //Abrir a conexao com banco
            connection.Open();
            Console.WriteLine("Conectado");

            using (var command = new SqlCommand())
            {
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "SELECT [Id], [Title] FROM [Category]";


                var reader = command.ExecuteReader();

                //Enquanto ler, trará informações
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }

            }
        }
        */


        //---------------------Exemplo utilizando DAPPER---------------------\\


        const string connectionString = @"Server=DESKTOP-73M6QT8\MSSQLSERVER01;Database=balta_curso;Integrated Security=True;";


        //Fazendo conexao com o banco

        using (var connection = new SqlConnection(connectionString))
        {
            //UpdateCategory(connection);
            //DeleteCategory(connection);
            //CreateManyCategory(connection);
            //DeleteManyCategory(connection);
            //CreateCategory(connection);
            //ListCategories(connection);
            //ExecuteProcedure(connection);
            //ExecuteReadProcedure(connection);
            //ExecuteScalar(connection);
            //ReadView(connection);
            OneToOne(connection);

        }

    }
  
    //Listando categorias do Banco
    static void ListCategories(SqlConnection connection)
    {
        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category] ORDER BY [Title]");

        foreach (var item in categories)
        {
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    //Adionando um registro ao Banco
    static void CreateCategory(SqlConnection connection)
    {
        var category = new Category();

        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;

        var insertSql = @"INSERT INTO 
                [Category] 
            VALUES(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured)";

        var rows = connection.Execute(insertSql, new
        {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        });
        Console.WriteLine($"Linhas inseridas: {rows}");
    }

    //Atualizando registros do Banco
    static void UpdateCategory(SqlConnection connection)
    {
        var updateQuery = 
            @"UPDATE [Category] 
            SET [Title]=@title 
            WHERE [Id]=@Id";

        var rows = connection.Execute(updateQuery, new
        {
            id = "AF3407AA-11AE-4621-A2EF-2028B85507C4",
            title = "Frontend 2024",
            url = "NewFrontEnd",
        });

        Console.WriteLine($"{rows} registros atualizados!");
    }

    //Deletando um registro do Banco
    static void DeleteCategory(SqlConnection connection)
    {
        var deleteCategory = 
            @"DELETE FROM [Category] 
            WHERE [Id]=@Id";

        var rows = connection.Execute(deleteCategory, new
        {
            id = "12F88683-0FF5-4916-BBF3-85655B9BF82D",
        });

        Console.WriteLine($"{rows} registros deletados!");
    }

    //Adicionando vários registros ao Banco
    static void CreateManyCategory(SqlConnection connection)
    {
        var category = new Category();

        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;


        var category2 = new Category();

        category2.Id = Guid.NewGuid();
        category2.Title = "Categoria Nova";
        category2.Url = "categoria-nova";
        category2.Description = "Categoria nova";
        category2.Order = 9;
        category2.Summary = "Categoria";
        category2.Featured = true;

        var insertSql = @"INSERT INTO 
                [Category] 
            VALUES(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured)";

        var rows = connection.Execute(insertSql, new[] {
            new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            },
            new
            {
                category2.Id,
                category2.Title,
                category2.Url,
                category2.Summary,
                category2.Order,
                category2.Description,
                category2.Featured
            }
        });
        Console.WriteLine($"Linhas inseridas: {rows}");
    }

    //Deletando vários registros do Banco
    static void DeleteManyCategory(SqlConnection connection)
    {
        var deleteCategory =
            @"DELETE FROM [Category] 
            WHERE [Id]=@Id";

        var rows = connection.Execute(deleteCategory, new[]
        {
            new
            {
                id = "85DB9A4B-3121-42B8-86D8-D77235EAE565"
            },
            new
            {
                id = "E98DE5F7-DF7F-44A9-8A0F-426C3ED088E7"
            },
            new
            {
                id = "7116D04A-D37D-4A66-BAE9-C92563AC7FA4"
            }
        });

        Console.WriteLine($"{rows} registros deletados!");
    }

    //Executa uma procedure
    static void ExecuteProcedure(SqlConnection connection)
    {
        var procedure = /*EXEC*/ "[spDeleteStudent]";
        //Quando passado o "CommanType.StoreProcedure", não há necessidade de ter um "EXEC"

        var pars = new { StudentId = "C55390D4-71DD-4F3C-B978-D1582F51A327" };
        var affectedRows = connection.Execute(
            procedure,
            pars,
            commandType: CommandType.StoredProcedure);

        Console.WriteLine($"{affectedRows} linhas afetadas");
    }

    //Executa uma procedure de leitura
    static void ExecuteReadProcedure(SqlConnection connection)
    {
        var procedure = /*EXEC*/ "[spGetCoursesByCategory]";
        //Quando passado o "CommanType.StoreProcedure", não há necessidade de ter um "EXEC"

        var pars = new { CategoryId = "AF3407AA-11AE-4621-A2EF-2028B85507C4" };
        var courses = connection.Query(
            procedure,
            pars,
            commandType: CommandType.StoredProcedure);

        foreach(var item in courses)
        {
            Console.WriteLine(item);
        }
    }

    //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta.
    static void ExecuteScalar(SqlConnection connection)
    {
        var category = new Category();

        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;

        var insertSql = @"INSERT INTO 
                [Category] 
            OUTPUT inserted.[Id]
            VALUES(
                NEWID(),
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured)
            SELECT SCOPE_IDENTITY()";

        var id = connection.ExecuteScalar<Guid>(insertSql, new
        {
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        });
        Console.WriteLine($"A categoria inserida foi: {id}");
    }

    static void ReadView(SqlConnection connection)
    {
        var sql = "SELECT * FROM [vwCourses]";
        var courses = connection.Query(sql);

        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    //Método Um para Um
    static void OneToOne(SqlConnection connection)
    {
        var sql = @"
            SELECT 
                * 
            FROM 
                [CareerItem] 
            INNER JOIN 
                [Course] ON [CareerItem].[CourseId] = [Course].[Id]
            ORDER BY [Course].[Id]";

        var items = connection.Query<CareerItem, Course, CareerItem>(
            sql,
            (careerItem, Course) => {
                careerItem.Course = Course;
                return careerItem;
            }, splitOn: "Id");

        foreach(var item in items)
        {
            Console.WriteLine($"{item.Title} - Curso {item.Course.Title} ");
        }
    }
}
