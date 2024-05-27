// Define um método estático chamado CreateManyCategory que recebe uma conexão com o banco de dados como parâmetro
static void CreateManyCategory(SqlConnection connection)
{
    // Cria uma nova instância do objeto Category para a primeira categoria
    var category = new Category();

    // Define os valores para as propriedades da primeira categoria
    category.Id = Guid.NewGuid();  // Gera um novo identificador único
    category.Title = "Amazon AWS";  // Define o título da categoria
    category.Url = "amazon";  // Define a URL da categoria
    category.Description = "Categoria destinada a serviços do AWS";  // Define a descrição
    category.Order = 8;  // Define a ordem da categoria
    category.Summary = "AWS Cloud";  // Define o resumo
    category.Featured = false;  // Define se a categoria é destacada

    // Cria uma nova instância do objeto Category para a segunda categoria
    var category2 = new Category();

    // Define os valores para as propriedades da segunda categoria
    category2.Id = Guid.NewGuid();  // Gera um novo identificador único
    category2.Title = "Categoria Nova";  // Define o título da categoria
    category2.Url = "categoria-nova";  // Define a URL da categoria
    category2.Description = "Categoria nova";  // Define a descrição
    category2.Order = 9;  // Define a ordem da categoria
    category2.Summary = "Categoria";  // Define o resumo
    category2.Featured = true;  // Define se a categoria é destacada

    // Define a consulta SQL para inserir novas categorias na tabela 'Category'
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
    // Passa os valores das categorias como uma matriz de objetos
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

    // Exibe no console o número de linhas que foram inseridas no banco de dados
    Console.WriteLine($"Linhas inseridas: {rows}");
}
