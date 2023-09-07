using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Lanchonete
        {
            public string nomeCliente { get; set; }
            public double taxaDeServico { get; set; }


            public Lanchonete()
            {
                this.nomeCliente = nomeCliente;
                this.taxaDeServico = 2.0;

            }


            public void Pizzaa()
            {
                try
                {
                    string[] Sabores = { "Frango c/ Catupiry", "Calabresa", "Portuguesa" };
                    string[] Bordas = { "borda de catupiry", "borda de chocolate", "borda de cheddar" };
                    double[] Precos = { 25.00, 27.00, 35.00 };
                    Console.WriteLine("Essas são as nossas opções de pizzas, escolha com sabedoria: \n 0 - Pizza de catupiry R$25,00\n 1 - Pizza de calabresa R$27,00\n 2 - Pizza de Portuguesa R$35,00");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ótima escolha! Você deseja acrescentar borda recheada por apenas R$2,00?\n 0 - SIM\n 1-NÃO");
                    var Op_escolha = int.Parse(Console.ReadLine());
                    switch (Op_escolha)
                    {
                        case 0:
                            Console.WriteLine("Certo, aqui estão algumas opções: \n 0 - Borda de catupiry\n 1 -  Borda de chocolate\n 2 - Borda de cheddar");
                            var Op_borda = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Você não erra nunca nas escolhas! Sua pizza de {Sabores[Op]}, com borda de {Bordas[Op_borda]} está sendo preparada!");
                            Console.WriteLine("Digite o valor da sua nota: ");
                            var dinheiro = int.Parse(Console.ReadLine());
                            if (dinheiro >= 27)
                            {
                                double troco = (dinheiro -  Precos[Op]) - this.taxaDeServico;
                                Console.WriteLine($"Aqui está o seu troco R${troco}, obrigado e volte sempre! :)");
                            }
                            else
                            {
                                Console.WriteLine("Não vendemos fiado, CALOTEIRO");
                            }
                            break;

                        case 1:
                            Console.WriteLine($"Você não erra nunca nas escolhas! Sua pizza de {Sabores[Op]} está sendo preparada!");
                            Console.WriteLine("Digite o valor da sua nota: ");
                            var dinheiro1 = int.Parse(Console.ReadLine());
                            if (dinheiro1 >= 25)
                            {
                                double troco = (dinheiro1 - Precos[Op]);
                                Console.WriteLine($"Aqui está o seu troco R${troco}, obrigado e volte sempre! :)");
                            }
                            else
                            {
                                Console.WriteLine("Não vendemos fiado, CALOTEIRO");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("ERRO! Verifique as informações e tente novamente");
                 }
            }
            public void Lanche()
            {
                try
                {
                    string[] Sabores = { "X-Salada", "McChicken", "X-Tudo" };
                    string[] Molhos = { "barbecue", "maionese", "maionese temperada" };
                    double[] Precos = { 20.00, 27.00, 30.00 };
                    Console.WriteLine("Essas são as nossas opções de lanches, escolha com sabedoria: \n 0 - X-Salada R$20,00\n 1 - McChicken R$27,00\n 2 - X-Tudo R$30,00");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ótima escolha! Você deseja acrescentar algum de nossos molhos especiais por apenas R$2,00?\n 0 - SIM\n 1-NÃO");
                    var Op_escolha = int.Parse(Console.ReadLine());
                    switch (Op_escolha)
                    {
                        case 0:
                            Console.WriteLine("Certo, aqui estão algumas opções: \n 0 - Barbecue\n 1 - Maionese\n 2 - Maionese Temperada");
                            var Op_molho = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Você não erra nunca nas escolhas! Seu {Sabores[Op]} com molho de {Molhos[Op_molho]} está sendo preparado!");
                            Console.WriteLine("Digite o valor da sua nota: ");
                            var dinheiro = int.Parse(Console.ReadLine());
                            if (dinheiro >= 22)
                            {
                                double troco = (dinheiro - Precos[Op]) - this.taxaDeServico;
                                Console.WriteLine($"Aqui está o seu troco R${troco}, obrigado e volte sempre! :)");
                            }
                            else
                            {
                                Console.WriteLine("Não vendemos fiado, CALOTEIRO");
                            }
                            break;

                        case 1:
                            Console.WriteLine($"Você não erra nunca nas escolhas! Seu {Sabores[Op]} está sendo preparado!");
                            Console.WriteLine("Digite o valor da sua nota: ");
                            var dinheiro1 = int.Parse(Console.ReadLine());
                            if (dinheiro1 >= 20)
                            {
                                double troco = (dinheiro1 - Precos[Op]);
                                Console.WriteLine($"Aqui está o seu troco R${troco}, obrigado e volte sempre! :)");
                            }
                            else
                            {
                                Console.WriteLine("Não vendemos fiado, CALOTEIRO");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("ERRO! Verifique as informações e tente novamente");
                }
            }

                public void Salgadinho()
            {
                try
                {
                    string[] Lanches = { "coxinha", "risoli", "fogaça" };
                    double[] Precos = { 2, 1.5, 3 };
                    Console.WriteLine("Essas são as nossas opções de salgados, escolha com sabedoria: \n 0 - Coxinha R$2,00\n 1 - Risoli R$1,50\n 2 - Fogaça R$3,00");
                    var Op = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Você não erra nunca nas escolhas! {Lanches[Op]} está sendo preparado(a)!");
                    Console.WriteLine("Digite o valor da sua nota: ");
                    var dinheiro1 = int.Parse(Console.ReadLine());
                    if (dinheiro1 >= 1.5)
                    {
                        double troco = (dinheiro1 - Precos[Op]);
                        Console.WriteLine($"Aqui está o seu troco R${troco}, obrigado e volte sempre! :)");
                    }
                    else
                    {
                        Console.WriteLine("Não vendemos fiado, CALOTEIRO");
                    }
                }

                catch
                {
                    Console.WriteLine("ERRO! Verifique as informações e tente novamente");
                }
            }


            public void Pedido()
            {

            }
            public void CalcularPreco()
            {

            }

            public void CalcularTotal()
            {

            }
            public void MostrarFatura()
            {

            }

        }


        static void Main(string[] args)
        {
            Lanchonete pi = new Lanchonete();
            Console.WriteLine("Esse é o nosso cardápio disponível:\n 0 - Pizzas\n 1 - Salgados\n 2 - Lanches");
            var Op = int.Parse(Console.ReadLine());
            switch (Op)
            {
                case 0: pi.Pizzaa(); break;

                case 1: pi.Salgadinho(); break;

                case 2: pi.Lanche(); break;
            }
        }
    }
}
