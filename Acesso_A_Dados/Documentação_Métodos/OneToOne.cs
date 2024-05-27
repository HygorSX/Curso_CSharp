// Define um método estático chamado OneToOne que recebe uma conexão com o banco de dados como parâmetro
static void OneToOne(SqlConnection connection)
{
    // Define a consulta SQL para selecionar todos os registros da tabela CareerItem e seus cursos correspondentes na tabela Course
    var sql = @"
        SELECT 
            * 
        FROM 
            [CareerItem] 
        INNER JOIN 
            [Course] ON [CareerItem].[CourseId] = [Course].[Id]
        ORDER BY [Course].[Id]";

    // Executa a consulta SQL usando a conexão com o banco de dados
    // Mapeia os resultados para objetos CareerItem e Course, utilizando a relação One-to-One entre as tabelas
    var items = connection.Query<CareerItem, Course, CareerItem>(
        sql,
        (careerItem, Course) => {
            careerItem.Course = Course;  // Associa o curso ao item de carreira
            return careerItem;
        }, splitOn: "Id");  // Divide os resultados quando encontrar uma coluna com o nome "Id"

    // Itera sobre cada item retornado pela consulta SQL
    foreach(var item in items)
    {
        // Exibe no console o título do item de carreira e o título do curso associado
        Console.WriteLine($"{item.Title} - Curso {item.Course.Title} ");
    }
}
