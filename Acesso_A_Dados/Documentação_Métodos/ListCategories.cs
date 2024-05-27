// Define um método estático chamado ListCategories que recebe uma conexão com o banco de dados como parâmetro
static void ListCategories(SqlConnection connection)
{
    // Executa uma consulta SQL para selecionar o Id e o Título de todas as categorias da tabela 'Category'
    // e armazena o resultado em uma lista de objetos 'Category'
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category] ORDER BY [Title]");

    // Percorre cada item na lista de categorias obtidas
    foreach (var item in categories)
    {
        // Exibe no console o Id e o Título de cada categoria
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}
