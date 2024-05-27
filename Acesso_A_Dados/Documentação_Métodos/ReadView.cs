// Define um método estático chamado ReadView que recebe uma conexão com o banco de dados como parâmetro
static void ReadView(SqlConnection connection)
{
    // Define a consulta SQL para selecionar todos os registros da view 'vwCourses'
    var sql = "SELECT * FROM [vwCourses]";

    // Executa a consulta SQL usando a conexão com o banco de dados
    var courses = connection.Query(sql);

    // Itera sobre cada item retornado pela consulta SQL
    foreach (var item in courses)
    {
        // Exibe no console o Id e o título de cada curso
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}
