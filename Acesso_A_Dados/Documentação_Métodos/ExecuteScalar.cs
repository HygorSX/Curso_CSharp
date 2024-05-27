// Define um método estático chamado ExecuteScalar que recebe uma conexão com o banco de dados como parâmetro
static void ExecuteScalar(SqlConnection connection)
{
    // Cria uma nova instância do objeto Category
    var category = new Category();

    // Define os valores para as propriedades do objeto Category
    category.Title = "Amazon AWS";  // Define o título da categoria
    category.Url = "amazon";  // Define a URL da categoria
    category.Description = "Categoria destinada a serviços do AWS";  // Define a descrição da categoria
    category.Order = 8;  // Define a ordem da categoria
    category.Summary = "AWS Cloud";  // Define o resumo da categoria
    category.Featured = false;  // Define se a categoria é destacada ou não

    // Define a consulta SQL para inserir uma nova categoria na tabela 'Category' e obter o Id gerado
    var insertSql = @"INSERT INTO 
            [Category] 
        OUTPUT inserted.[Id]  -- Retorna o Id da categoria inserida
        VALUES(
            NEWID(),  -- Gera um novo identificador único para a categoria
            @Title,
            @Url,
            @Summary,
            @Order,
            @Description,
            @Featured)
        SELECT SCOPE_IDENTITY()";  -- Retorna o Id inserido

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Passa os valores do objeto category como parâmetros
    // Espera um valor escalar de tipo Guid como resultado, que é o Id da categoria inserida
    var id = connection.ExecuteScalar<Guid>(insertSql, new
    {
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
    });

    // Exibe no console o Id da categoria que foi inserida
    Console.WriteLine($"A categoria inserida foi: {id}");
}
