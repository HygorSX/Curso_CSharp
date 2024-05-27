static void UpdateCategory(SqlConnection connection)
{
    // Define a consulta SQL para atualizar o título de uma categoria específica na tabela 'Category'
    var updateQuery = 
        @"UPDATE [Category] 
        SET [Title]=@title 
        WHERE [Id]=@Id";

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Passa os valores necessários para a consulta como parâmetros
    var rows = connection.Execute(updateQuery, new
    {
        id = "AF3407AA-11AE-4621-A2EF-2028B85507C4",  // Define o Id da categoria que será atualizada
        title = "Frontend 2024",  // Define o novo título para a categoria
        // O parâmetro 'url' está presente aqui, mas não é usado na consulta SQL
    });

    // Exibe no console o número de registros que foram atualizados no banco de dados
    Console.WriteLine($"{rows} registros atualizados!");
}
