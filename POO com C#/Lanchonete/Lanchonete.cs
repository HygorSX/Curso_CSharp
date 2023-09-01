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

                    Console.WriteLine("Essas são as nossas opções de pizzas, escolha com sabedoria: \n 0 - Pizza de catupiry R$25,00\n 1 - Pizza de calabresa R$27,00\n 2 - Pizza de Portuguesa R$35,00");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    if (Op >= 0 && Op <= 2)
                    {
                        switch (Op)
                        {
                            case 0:
                                Console.WriteLine("Escolha uma de nossas bordas: \n 0 - Borda de catupiry\n 1 -  Borda de chocolate\n 2 - Borda de cheddar");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Bordas = { "borda de catupiry", "borda de chocolate", "borda de cheddar" };
                                Console.WriteLine($"Otima escolha!! Sua pizza de catupiry com {Bordas[Op1]} está sendo preparada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido = double.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                if (valor_recebido >= 25.00)
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    float troco = (float)(valor_recebido - 25.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }
                                break;

                            case 1:
                                Console.WriteLine("Escolha uma de nossas bordas: \n 0 - Borda de catupiry\n 1 -  Borda de chocolate\n 2 - Borda de cheddar");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Bordas1 = { "borda de catupiry", "borda de chocolate", "borda de cheddar" };
                                Console.WriteLine($"Otima escolha!! Sua pizza de calabresa com {Bordas1[Op2]} está sendo preparada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota: ");
                                double valor_recebido1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                if (valor_recebido1 >= 27.00)
                                {
                                    float troco1 = (float)(valor_recebido1 - 27.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco1}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                            case 2:
                                Console.WriteLine("Escolha uma de nossas bordas: \n 0 - Borda de catupiry\n 1 -  Borda de chocolate\n 2 - Borda de cheddar");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Bordas3 = { "borda de catupiry", "borda de chocolate", "borda de cheddar" };
                                Console.WriteLine($"Otima escolha!! Sua pizza de portuguesa {Bordas3[Op3]} está sendo preparada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                if (valor_recebido2 >= 35.00)
                                {
                                    float troco2 = (float)(valor_recebido2 - 35.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco2}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Digite um valor valido");
                    }
                }
                catch
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Digite um caracter válido");
                }
            }
        
            public void Lanche()
            {
                try
                {

                    Console.WriteLine("Essas são as nossas opções de lanches, escolha com sabedoria: \n 0 - X-Salada R$20,00\n 1 - McChicken R$27,00\n 2 - X-Tudo R$30,00");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    if (Op >= 0 && Op <= 2)
                    {
                        switch (Op)
                        {
                            case 0:
                                Console.WriteLine("Escolha um de nossos molhos\n 0 - Barbecue\n 1 -  Maionese\n 2 - Maionese Temperada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Molhos = { "barbecue", "maionese", "maionese temperada" };
                                Console.WriteLine($"Otima escolha!! Seu X-Salada com molho de {Molhos[Op1]} está sendo preparado");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido = double.Parse(Console.ReadLine());
                                if (valor_recebido >= 20.00)
                                {
                                    float troco = (float)(valor_recebido - 20.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }
                                break;

                            case 1:
                                Console.WriteLine("Escolha um de nossos molhos\n 0 - Barbecue\n 1 - Maionese\n 2 - Maionese Temperada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Molhos1 = { "barbecue", "maionese", "maionese temperada" };
                                Console.WriteLine($"Otima escolha!! Seu McChicken com molho de {Molhos1[Op2]} está sendo preparado");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota: ");
                                double valor_recebido1 = double.Parse(Console.ReadLine());
                                if (valor_recebido1 >= 27.00)
                                {
                                    float troco1 = (float)(valor_recebido1 - 27.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco1}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                            case 2:
                                Console.WriteLine("Escolha um de nossos molhos\n 0 - Barbecue\n 1 - Maionese\n 2 - Maionese Temperada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                var Op3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                string[] Molhos3 = { "barbecue", "maionese", "maionese temperada" };
                                Console.WriteLine($"Otima escolha!! Seu X-Tudo com molho de {Molhos3[Op3]} está sendo preparado");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido2 = double.Parse(Console.ReadLine());
                                if (valor_recebido2 >= 30.00)
                                {
                                    float troco2 = (float)(valor_recebido2 - 30.00);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco2}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Digite um valor valido");
                    }
                }
                catch
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Digite um caracter válido");
                }
            }
        
    
            public void Salgadinho()
            {
                try
                {

                    Console.WriteLine("Essas são as nossas opções de salgados, escolha com sabedoria: \n 0 - Coxinha R$2,00\n 1 - Risoli R$1,50\n 2 - Fogaça R$3,00");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    if (Op >= 0 && Op <= 2)
                    {
                        switch (Op)
                        {
                            case 0:
                                Console.WriteLine($"Otima escolha!! Sua coxinha está sendo preparada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido = double.Parse(Console.ReadLine());
                                if (valor_recebido >= 2)
                                {
                                    float troco = (float)(valor_recebido - 2);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }
                                break;

                            case 1:
                                Console.WriteLine($"Otima escolha!! Seu risoli está sendo preparado");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota: ");
                                double valor_recebido1 = double.Parse(Console.ReadLine());
                                if (valor_recebido1 >= 1.50)
                                {
                                    float troco1 = (float)(valor_recebido1 - 1.50);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco1}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                            case 2:
                                Console.WriteLine($"Otima escolha!! Sua fogaça está sendo preparada");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Digite o valor da nota");
                                double valor_recebido2 = double.Parse(Console.ReadLine());
                                if (valor_recebido2 >= 3)
                                {
                                    float troco2 = (float)(valor_recebido2 - 3);
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"O seu troco é R${troco2}");
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Ainda não vendemos fiado, CALOTEIRO!");
                                }

                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Digite um valor valido");
                    }
                }
                catch
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Digite um caracter válido");
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
            pi.Salgadinho();
            pi.Lanche();
            pi.Pizzaa();
        }
    }
}
