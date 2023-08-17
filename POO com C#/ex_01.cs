// Crie uma classe Animal contendo os atributos tipo e cor. Adicione dois métodos para exibir o tipo e a cor, um construtor para classe que inicialize os atributos, e um método toJson() para retornar o tipo e a cor do animal no formato JSON.​
// • Construa uma classe Cachorro que estenda a classe Animal e tenha os atributos nome e raça do cachorro, construa para classe os métodos para exibir estes atributos, um construtor e um método toJson() retornando todos os atributos em formato JSON. ​
// • Construa uma classe Cocker que estenda a classe Cachorro e tenha os atributos tosa do tipo boolean (falso, verdadeiro), com um método tosar() e um método precisaTosa() que deve retornar apenas se precisa ou não de tosa. ​
// • Escreva um arquivo de teste (CockerTeste.js) adequado para esta classe testando os métodos da classe e os métodos herdados.​

using System;
using System.Text.Json;

public class Animal
{
    public string Tipo { get; set; }
    public string Cor { get; set; }

    public Animal(string tipo, string cor)
    {
        Tipo = tipo;
        Cor = cor;
    }

    public void ExibirTipo()
    {
        Console.WriteLine($"Tipo: {Tipo}");
    }

    public void ExibirCor()
    {
        Console.WriteLine($"Cor: {Cor}");
    }

    public string ToJson()
    {
        var animalData = new { Tipo, Cor };
        return JsonSerializer.Serialize(animalData);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal gato = new Animal("Gato", "Branco");
        Animal cachorro = new Animal("Cachorro", "Marrom");

        gato.ExibirTipo();
        gato.ExibirCor();
        Console.WriteLine("JSON para gato: " + gato.ToJson());

        cachorro.ExibirTipo();
        cachorro.ExibirCor();
        Console.WriteLine("JSON para cachorro: " + cachorro.ToJson());
    }
}
