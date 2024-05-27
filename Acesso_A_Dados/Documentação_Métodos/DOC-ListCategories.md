# Listagem de Categorias

Este método `ListCategories` é responsável por listar todas as categorias armazenadas em um banco de dados.

```csharp
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

````
## Criação do objeto Category:

```csharp
var category = new Category();
````
- Cria uma nova instância do objeto Category.


## Definição das propriedades da categoria:

```csharp
category.Id = Guid.NewGuid();
category.Title = "Amazon AWS";
category.Url = "amazon";
category.Description = "Categoria destinada a serviços do AWS";
category.Order = 8;
category.Summary = "AWS Cloud";
category.Featured = false;
````
- Atribui valores às propriedades do objeto Category.
- Id é gerado automaticamente usando Guid.NewGuid().

## Execução da consulta SQL:
```csharp
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
````
- Executa a consulta SQL usando a conexão com o banco de dados.
- Passa os valores do objeto Category como parâmetros para a consulta SQL.

## Exibição do resultado:

```csharp
Console.WriteLine($"Linhas inseridas: {rows}");
````

- Exibe no console o número de linhas que foram inseridas no banco de dados.
