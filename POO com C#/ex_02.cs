// 3) Crie uma classe chamada Fatura para que uma loja de suprimentos de Informática possa utilizá-la para representar uma fatura de um ou mais itens vendidos na loja.
// a-) Uma fatura deve incluir as seguintes informações como atributos:​
// o número, ​
// a descrição, ​
// a quantidade comprada de um item, ​
// o preço por item. ​
// b-) Sua classe deve ter um método para exibir e armazenar para cada atributo. ​
// c-) Crie um método para calcular o valor da fatura (isto é, um método que multiplique a quantidade pelo preço por item) e depois retorna o valor total.​
// d-) Se a quantidade não for positiva, ela deve ser configurada como 0. Se o preço por item não for positivo, ele deve ser configurado como 0.0. ​

public class Fatura
{
    public int numero { get; set; }
    public string descricao { get; set; }
    public int quantidade { get; set; }
    public double preco { get; set; }


    public Fatura(int numero, string descricao, int quantidade, double preco)
    {
        this.numero = numero;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.preco = preco;

        if (quantidade < 0 || preco < 0)
        {
            this.quantidade = 0; this.preco = 0.0;
        }
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;

    }
    public void ExibirNum()
    {
        System.Console.WriteLine($"Número da fatura é: {this.numero}");
    }
    public void ExibirDesc()
    {
        System.Console.WriteLine($"Descrição do produto: {this.descricao}");
    }
    public void ExibirQuant()
    {
        System.Console.WriteLine($"Quantidade de produtos: {this.quantidade}");
    }
    public void ExibirPreco()
    {
        System.Console.WriteLine($"O valor do produto é: R${this.preco}");
    }
    public void Calcular()
    {

        double valorTotal = this.quantidade * this.preco;
        System.Console.WriteLine($"O valor total desta compra é: R${valorTotal}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fatura fatura1 = new Fatura(2323, "Mouse_Gamer", 2, 250.40);
        Fatura fatura2 = new Fatura(2323, "Mouse_Gamer", 0, 0);
        Console.WriteLine("Fatura 1: ");
        fatura1.ExibirNum();
        fatura1.ExibirDesc();
        fatura1.ExibirQuant();
        fatura1.ExibirPreco();
        fatura1.Calcular();
        Console.WriteLine("");
        Console.WriteLine("Fatura 2: ");
        fatura2.ExibirNum();
        fatura2.ExibirDesc();
        fatura2.ExibirQuant();
        fatura2.ExibirPreco();
        fatura2.Calcular();
    }
}
