// Define um método estático chamado Transactions que recebe uma conexão com o banco de dados como parâmetro
static void Transactions(SqlConnection connection)
{
    // Cria um novo objeto da classe Category e atribui valores aos seus membros
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Minha Categoria que não";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    // Define a consulta SQL para inserir um novo registro na tabela Category
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

    // Abre a conexão com o banco de dados
    connection.Open();

    // Inicia uma transação no banco de dados
    using (var transaction = connection.BeginTransaction())
    {
        // Executa a consulta SQL de inserção dentro da transação
        var rows = connection.Execute(insertSql, new
        {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        }, transaction);

        // Commit: confirma a transação, salvando as alterações no banco de dados
        transaction.Commit();

        // Rollback: cancela a transação, revertendo as alterações no banco de dados
        //transaction.Rollback();

        // Exibe a quantidade de linhas afetadas pela operação de inserção
        Console.WriteLine($"Linhas inseridas: {rows}");
    }
}
