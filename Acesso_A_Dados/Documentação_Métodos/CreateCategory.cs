static void CreateCategory(SqlConnection connection)
{
    // Cria uma nova instância do objeto Category
    var category = new Category();

    // Define os valores para as propriedades do objeto Category
    category.Id = Guid.NewGuid();  // Gera um novo identificador único para a categoria
    category.Title = "Amazon AWS";  // Define o título da categoria
    category.Url = "amazon";  // Define a URL da categoria
    category.Description = "Categoria destinada a serviços do AWS";  // Define a descrição da categoria
    category.Order = 8;  // Define a ordem da categoria
    category.Summary = "AWS Cloud";  // Define o resumo da categoria
    category.Featured = false;  // Define se a categoria é destacada ou não

    // Define a consulta SQL para inserir uma nova categoria na tabela 'Category'
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

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Passa os valores do objeto category para a consulta usando parâmetros
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

    // Exibe no console o número de linhas que foram inseridas no banco de dados
    Console.WriteLine($"Linhas inseridas: {rows}");
}
