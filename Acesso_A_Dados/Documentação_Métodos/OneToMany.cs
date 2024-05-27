// Define um método estático chamado OneToMany que recebe uma conexão com o banco de dados como parâmetro
static void OneToMany(SqlConnection connection)
{
    // Define a consulta SQL para selecionar os registros das tabelas Career e CareerItem, relacionados por CareerId
    var sql = @"
        SELECT
            [Career].[Id],
            [Career].[Title],
            [CareerItem].[CareerId],
            [CareerItem].[Title]
        FROM	
            [Career]
        INNER JOIN 
            [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
        ORDER BY 
            [Career].[Title]";

    // Cria uma lista para armazenar as carreiras e seus itens associados
    var careers = new List<Career>();

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Mapeia os resultados para objetos Career e CareerItem, utilizando a relação One-to-Many entre as tabelas
    var items = connection.Query<Career, CareerItem, Career>(
        sql,
        (career, item) => {
            // Verifica se a carreira já está na lista de carreiras
            var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
            if (car == null)
            {
                // Se a carreira não está na lista, adiciona-a à lista e adiciona o item associado
                car = career;
                car.Items.Add(item);
                careers.Add(car);
            }
            else
            {
                // Se a carreira já está na lista, apenas adiciona o item associado
                car.Items.Add(item);
            }
            return career;  // Retorna a carreira
        }, splitOn: "CareerId");  // Divide os resultados quando encontrar uma coluna com o nome "CareerId"

    // Itera sobre cada carreira na lista de carreiras
    foreach (var career in careers)
    {
        // Exibe o título da carreira
        Console.WriteLine($"{career.Title}");
        // Itera sobre cada item associado à carreira e exibe seus títulos
        foreach (var item in career.Items)
        {
            Console.WriteLine($"- {item.Title}");
        }
    }
}
