// Define um método estático chamado SelectIn que recebe uma conexão com o banco de dados como parâmetro
static void SelectIn(SqlConnection connection)
{
    // Define a consulta SQL que seleciona registros da tabela Career onde o Id está contido em uma lista de valores
    var query = @"SELECT * FROM Career WHERE [Id] IN @Id";

    // Executa a consulta SQL utilizando o método Query da conexão com o banco de dados
    // Passa um objeto anônimo como parâmetro contendo a lista de valores de Id
    var items = connection.Query<Course>(query, new
    {
        Id = new[]
        {
            "4327AC7E-963B-4893-9F31-9A3B28A4E72B",
            "92D7E864-BEA5-4812-80CC-C2F4E94DB1AF"
        }
    });

    // Itera sobre os itens retornados e os exibe no console
    foreach (var item in items)
    {
        Console.WriteLine(item.Title);
    }
}
