static void DeleteCategory(SqlConnection connection)
{
    // Define a consulta SQL para deletar uma categoria específica na tabela 'Category'
    var deleteCategory = 
        @"DELETE FROM [Category] 
        WHERE [Id]=@Id";

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Passa o valor necessário para a consulta como parâmetro
    var rows = connection.Execute(deleteCategory, new
    {
        id = "12F88683-0FF5-4916-BBF3-85655B9BF82D",  // Define o Id da categoria que será deletada
    });

    // Exibe no console o número de registros que foram deletados no banco de dados
    Console.WriteLine($"{rows} registros deletados!");
}
