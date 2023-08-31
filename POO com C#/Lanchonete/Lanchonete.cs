using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Lanchonete
        {
            public string nomeCliente { get; set; }
            public double taxaDeServico { get; set; }
            public string molho { get; set; }
            public string recheio { get; set; }
            public string borda { get; set; }
            public string pao { get; set; }
            public string massa { get; set; }

            public Lanchonete(string nomeCliente, double taxaDeServico, string molho, string recheio, string borda, string pao, string massa)
            {
                this.nomeCliente = nomeCliente;
                this.taxaDeServico = 2.0;
                this.molho = molho;
                this.recheio = recheio;
                this.borda = borda;
                this.pao = pao;
                this.recheio = recheio;
                this.massa = massa;
            }


            public void Pizza()
            {
                this.molho = molho;
                this.recheio = recheio;
                this.borda = borda;

                Console.WriteLine("Essas são as nossas opções de pizzas, escolha com sabedoria: \n" +
                    "0 - Pizza de catupiry R$25,00\n" +
                    "1 - Pizza de calabresa R$27,00\n" +
                    "2 - Pizza de Portuguesa R$35,00");
                var Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 0: //frango c/ catupiry
                        Console.WriteLine("Escolha uma de nossas bordas: \n" +
                            "0 - Borda de catupiry\n" +
                            "1 -  Borda de chocolate\n" +
                            "2 - Borda de cheddar");
                        var Op1 = int.Parse(Console.ReadLine());
                        string[] Bordas = { "Borda de catupiry", "Borda de chocolate", "Borda de cheddar" };
                        Console.WriteLine($"Otima escolha!! Sua pizza de catupiry com {Bordas[Op1]} está sendo preparada");
                        Console.WriteLine("Digite o valor da nota");
                        double valor_recebido = double.Parse(Console.ReadLine());
                        float troco = (float)(valor_recebido - 25.00 - this.taxaDeServico);
                        Console.WriteLine($"O seu troco é R${troco}");
                        break;

                    case 1:
                        Console.WriteLine("Escolha uma de nossas bordas: \n" +
                            "0 - Borda de catupiry\n" +
                            "1 -  Borda de chocolate\n" +
                            "2 - Borda de cheddar");
                        var Op2 = int.Parse(Console.ReadLine());
                        string[] Bordas1 = { "Borda de catupiry", "Borda de chocolate", "Borda de cheddar" };
                        Console.WriteLine($"Otima escolha!! Sua pizza de calabresa com {Bordas1[Op2]} está sendo preparada");
                        Console.WriteLine("Digite o valor da nota");
                        double valor_recebido1 = double.Parse(Console.ReadLine());
                        float troco1 = (float)(valor_recebido1 - 27.00 - this.taxaDeServico);
                        Console.WriteLine($"O seu troco é R${troco1}");

                        break;

                    case 2:
                        Console.WriteLine("Escolha uma de nossas bordas: \n" +
                            "0 - Borda de catupiry\n" +
                            "1 -  Borda de chocolate\n" +
                            "2 - Borda de cheddar");
                        var Op3 = int.Parse(Console.ReadLine());
                        string[] Bordas3 = { "Borda de catupiry", "Borda de chocolate", "Borda de cheddar" };
                        Console.WriteLine($"Otima escolha!! Sua pizza de portuguesa {Bordas3[Op3]} está sendo preparada");
                        Console.WriteLine("Digite o valor da nota");
                        double valor_recebido2 = double.Parse(Console.ReadLine());
                        float troco2 = (float)(valor_recebido2 - 27.00 - this.taxaDeServico);
                        Console.WriteLine($"O seu troco é R${troco2}");

                        break;

                }
            }
            public void Lanche()
            {

            }
            public void Salgadinho()
            {

            }
            public void Prato()
            {

            }
            public void CalcularTotal()
            {

            }
            public void MostrarFatura()
            {

            }
            public void CalcularPreco()
            {

            }
             public void Pedido()
            {

            }
            
        }


        static void Main(string[] args)
        {
            
        }
    }
}
