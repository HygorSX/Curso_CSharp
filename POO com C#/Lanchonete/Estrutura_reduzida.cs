public void Pizzaa()
            {
                try
                {   
                    string[] Sabores = {"Frango c/ Catupiry", "Calabresa", "Portuguesa"};
                    string[] Bordas = {"borda de catupiry", "borda de chocolate", "borda de cheddar"};
                    double[] Precos = { 25.00, 27.00, 35.00}
                    Console.WriteLine("Essas são as nossas opções de pizzas, escolha com sabedoria: \n 0 - Pizza de catupiry R$25,00\n 1 - Pizza de calabresa R$27,00\n 2 - Pizza de Portuguesa R$35,00");
                    var Op = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ótima escolha! Você deseja acrescentar borda recheada por apenas R$2,00?\n 0 - SIM\n 1-NÃO");
                    var Op_escolha = int.Parse(Console.ReadLine());
                    if(Op_escolha != 1)
                    {
                        
                        Console.WriteLine("Certo, aqui estão algumas opções: \n 0 - Borda de catupiry\n 1 -  Borda de chocolate\n 2 - Borda de cheddar");
                        var Op_borda = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Você não erra nunca nas escolhas! Sua pizza de {Sabores[Op]}, com borda de {Bordas[Op_borda]} está sendo preparada!");
                        Console.WriteLine("Digite o valor da sua nota: ");
                        var dinheiro = int.Parse(Console.ReadLine());
                        if(dinheiro >= 25)
                        {
                        double troco = (dinheiro - {Precos[Op]}) - this.taxaDeServico;
                        Console.WriteLine($"Aqui está o seu troco {troco}, obrigado e volte sempre! :)")
                        }
                        else
                        {
                            Console.WriteLine("Não vendemos fiado, CALOTEIRO")
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Você não erra nunca nas escolhas! Sua pizza de {Sabores[Op]} está sendo preparada!");
                        Console.WriteLine("Digite o valor da sua nota: ");
                        var dinheiro = int.Parse(Console.ReadLine());
                        if(dinheiro >= 25)
                        {
                        double troco = (dinheiro - {Precos[Op]});
                        Console.WriteLine($"Aqui está o seu troco {troco}, obrigado e volte sempre! :)")
                        }
                        else
                        {
                            Console.WriteLine("Não vendemos fiado, CALOTEIRO")
                        } 
                    }
                }
                catch
                {
                    Console.WriteLine("ERRO! Verifique as informações e tente novamente")
                }
            }
