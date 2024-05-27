// Define um método estático chamado Like que recebe uma conexão com o banco de dados e um termo de pesquisa como parâmetros
static void Like(SqlConnection connection, string term)
{
    // Lê o termo de pesquisa a partir da entrada do console (usado apenas para teste)
    var exemplo = Console.ReadLine();

    // Define a consulta SQL que seleciona registros da tabela Course onde o título contém o termo de pesquisa
    var query = @"SELECT * FROM [Course] WHERE [Title] LIKE @exp";

    // Executa a consulta SQL utilizando o método Query da conexão com o banco de dados
    // Passa um objeto anônimo como parâmetro contendo o termo de pesquisa com curingas (%)
    var items = connection.Query<Course>(query, new
    {
        exp = $"%{exemplo}%"  // Adiciona os curingas (%) ao redor do termo de pesquisa
    });

    // Itera sobre os itens retornados e os exibe no console
    foreach (var item in items)
    {
        Console.WriteLine(item.Title);
    }
}
