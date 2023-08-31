using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Banco
        {
            private int numero { get; set; }
            private int numero_Ag { get; set; }
            private string agencia_nome { get; set; }
            private int tipo { get; set; }
            private double saldo { get; set; }

            public Banco(int numero, int numero_Ag, string agencia_nome, int tipo, double saldo)
            {
                this.numero = numero;
                this.numero_Ag = numero_Ag;
                this.agencia_nome = agencia_nome;
                this.tipo = tipo;
                this.saldo = saldo;
            }
            public Banco(int numero, int numero_Ag, string agencia_nome, int tipo)
            {
                this.numero = numero;
                this.numero_Ag = numero_Ag;
                this.agencia_nome = agencia_nome;
                this.tipo = tipo;
                this.saldo = 0.0;
            }
            public int getNumero()
            {
                return numero;
            }
            public int getNumeroAg()
            {
                return numero_Ag;
            }
            public string getAgenciaNome() // Corrigido o nome do método
            {
                return agencia_nome;
            }
            public int getTipo()
            {
                return tipo;
            }
            public double getSaldo()
            {
                return saldo;
            }

            public void Creditar(float valor)
            {
                this.saldo += valor;
            }
            public void Debitar(float valor)
            {
                this.saldo -= valor;
            }

            public string ConsultarSaldo() // Corrigido o tipo de retorno
            {
                try
                {
                    Console.WriteLine("Digite o número da sua conta: ");
                    int numeroConta;
                    int.TryParse(Console.ReadLine(), out numeroConta); // Corrigido o erro aqui
                    return $"A conta de número: {numeroConta}, possui o saldo de {saldo}";
                }
                catch (Exception ErroString)
                {
                    return "ERRO! Caracteres de tipo texto não são válidos nessa etapa";
                }
            }
            public int EncerrarConta() // Corrigido o tipo de retorno
            {
                this.tipo = 4;
                return tipo;
            }
            public string EncerrarTexto() // Corrigido o tipo de retorno
            {
                return $"A conta de número: {this.numero}, de tipo {this.tipo} foi encerrada! O saldo da conta encerrada é {this.saldo}";
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Banco conta1 = new Banco(1, 100, "Sede", 1);

                int Op = 0;
                while (Op != 4)
                {
                    Console.WriteLine($"Qual ação você deseja realizar? \n" +
                        "0 - Creditar\n" +
                        "1 - Debitar\n" +
                        "2 - Consultar Saldo\n" +
                        "3 - Encerrar Conta\n" +
                        "4 - Sair"
                    );

                    int.TryParse(Console.ReadLine(), out Op);

                    switch (Op)
                    {
                        case 0:
                            if (conta1.getTipo() != 4)
                            {
                                Console.WriteLine("Digite o valor a ser creditado: ");
                                float valorCredito;
                                float.TryParse(Console.ReadLine(), out valorCredito);
                                conta1.Creditar(valorCredito);

                                Console.WriteLine($"O novo saldo da conta é {conta1.getSaldo()}");
                            }
                            else
                            {
                                Console.WriteLine("Conta encerrada! Não é possível realizar esta operação");
                            }
                            break;

                        // Casos restantes

                        case 1:
                            if (conta1.getTipo() != 4)
                            {
                                Console.WriteLine("Digite o valor a ser debitado: ");
                                float valorDebito;
                                float.TryParse(Console.ReadLine(), out valorDebito);
                                conta1.Debitar(valorDebito);

                                Console.WriteLine($"O novo saldo da conta é {conta1.getSaldo()}");
                            }
                            else
                            {
                                Console.WriteLine("Conta encerrada! Não é possivel realizar esta operação");
                            }
                            break;

                        case 2:
                            Console.WriteLine($"O saldo da conta é: {conta1.getSaldo()}");
                        break;

                        case 3:
                            if (conta1.getSaldo() <= 0)
                            {
                                conta1.EncerrarConta();
                                Console.WriteLine(conta1.EncerrarTexto());
                            }
                            else
                            {
                                Console.WriteLine("Não é possivel encerrar a conta, retire todo o dinheiro");
                            }
                            break;
                        case 4:
                            Console.WriteLine("\nVolte sempre! :)");
                        break;
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Ocorreu um erro! :(");
            }
        }
    }
}
