// Define um método estático chamado ExecuteProcedure que recebe uma conexão com o banco de dados como parâmetro
static void ExecuteProcedure(SqlConnection connection)
{
    // Define o nome do procedimento armazenado que será executado
    var procedure = /*EXEC*/ "[spDeleteStudent]";
    // Quando passado o "CommandType.StoredProcedure", não há necessidade de ter um "EXEC"
    
    // Define os parâmetros que serão passados para o procedimento armazenado
    var pars = new { StudentId = "C55390D4-71DD-4F3C-B978-D1582F51A327" };
    
    // Executa o procedimento armazenado usando a conexão com o banco de dados
    // Passa o nome do procedimento, os parâmetros e especifica que o tipo de comando é um procedimento armazenado
    var affectedRows = connection.Execute(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    // Exibe no console o número de linhas que foram afetadas pelo procedimento armazenado
    Console.WriteLine($"{affectedRows} linhas afetadas");
}
