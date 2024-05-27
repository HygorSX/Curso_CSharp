// Define um método estático chamado QueryMultiple que recebe uma conexão com o banco de dados como parâmetro
static void QueryMultiple(SqlConnection connection)
{
    // Define a consulta SQL que seleciona todos os registros das tabelas Category e Course
    var query = "SELECT * FROM [Category]; SELECT * FROM [Course]";

    // Usa o objeto QueryMultiple para executar múltiplas consultas SQL
    using (var multi = connection.QueryMultiple(query))
    {
        // Lê os resultados da primeira consulta e os mapeia para objetos da classe Category
        var categories = multi.Read<Category>();

        // Lê os resultados da segunda consulta e os mapeia para objetos da classe Course
        var courses = multi.Read<Course>();

        // Itera sobre os resultados da primeira consulta (categorias) e os exibe no console
        foreach (var item in categories)
        {
            Console.WriteLine(item.Title);
        }

        // Itera sobre os resultados da segunda consulta (cursos) e os exibe no console
        foreach (var item in courses)
        {
            Console.WriteLine(item.Title);
        }
    }
}
