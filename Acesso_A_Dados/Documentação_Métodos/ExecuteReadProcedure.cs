// Define um método estático chamado ExecuteReadProcedure que recebe uma conexão com o banco de dados como parâmetro
static void ExecuteReadProcedure(SqlConnection connection)
{
    // Define o nome do procedimento armazenado que será executado
    var procedure = /*EXEC*/ "[spGetCoursesByCategory]";
    // Quando passado o "CommandType.StoredProcedure", não há necessidade de ter um "EXEC"

    // Define os parâmetros que serão passados para o procedimento armazenado
    var pars = new { CategoryId = "AF3407AA-11AE-4621-A2EF-2028B85507C4" };

    // Executa o procedimento armazenado usando a conexão com o banco de dados
    // Passa o nome do procedimento, os parâmetros e especifica que o tipo de comando é um procedimento armazenado
    var courses = connection.Query(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    // Itera sobre cada item retornado pelo procedimento armazenado
    foreach(var item in courses)
    {
        // Exibe cada item no console
        Console.WriteLine(item);
    }
}
