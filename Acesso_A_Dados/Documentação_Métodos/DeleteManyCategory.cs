static void DeleteManyCategory(SqlConnection connection)
{
    // Define a consulta SQL para deletar uma categoria específica na tabela 'Category'
    var deleteCategory =
        @"DELETE FROM [Category] 
        WHERE [Id]=@Id";

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Passa os valores necessários para a consulta como uma matriz de objetos
    var rows = connection.Execute(deleteCategory, new[]
    {
        new
        {
            id = "85DB9A4B-3121-42B8-86D8-D77235EAE565"  // Define o Id da primeira categoria que será deletada
        },
        new
        {
            id = "E98DE5F7-DF7F-44A9-8A0F-426C3ED088E7"  // Define o Id da segunda categoria que será deletada
        },
        new
        {
            id = "7116D04A-D37D-4A66-BAE9-C92563AC7FA4"  // Define o Id da terceira categoria que será deletada
        }
    });

    // Exibe no console o número de registros que foram deletados no banco de dados
    Console.WriteLine($"{rows} registros deletados!");
}
