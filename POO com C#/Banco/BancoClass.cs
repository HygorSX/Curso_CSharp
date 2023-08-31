public class Banco
{
    private Int numero {get; set;}
    private Int numero_Ag {get; set;}
    private String agencia_nome {get; set;}
    private Int tipo {get; set;}
    private Double saldo {get; set;}

    public Banco(Int numero, Int numero_Ag, String agencia_nome, Int tipo, Double saldo)
    {
        this.numero = numero;
        this.numero_Ag = numero_Ag;
        this.agencia_nome = agencia_nome;
        this.tipo = tipo;
        this.saldo = saldo;
    }
    public Banco(Int numero, Int numero_Ag, String agencia_nome, Int tipo)
    {
        this.numero = numero;
        this.numero_Ag = numero_Ag;
        this.agencia_nome = agencia_nome;
        this.tipo = tipo;
        this.saldo = 0.0;
    }
    public Int getNumero()
    {
        return numero;
    }
    public Int getNumeroAg()
    {
        return numero_Ag;
    }
    public String agencia_nome()
    {
        return agencia_nome;
    }
    public Int getTipo()
    {
        return tipo;
    }
    public Double getSaldo()
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

    public String ConsultarSaldo()
    {
        try{
        Console.WriteLine("Digite o número da sua conta: ");
        this.numero = int.TryParse(Console.ReadLine());
        return $"A conta de número: {this.numero}, possui o saldo de {this.saldo}";
        
        }
        catch(Exception ErroString)
        {
            Console.WriteLine("ERRO! Caracteres de tipo texto não são válidos nessa etapa")
        }
    }
    public Int32 EncerrarConta()
    {
        this.tipo = 4;
        return tipo;
    }
    public String EncerrarTexto()
    {
        return $"A conta de número: {this.numero}, de tipo{this.tipo} foi encerrada! O saldo da conta encerrada é {this.saldo}";
    }
}


//APLICAÇÃO//

try
{
    Banco conta1 = new Banco(1, 100, "Sede", 1)

        var Op = 0;
        while(Op != 4 )
        {
            Console.WriteLine($"Qual ação você deseja realizar? \n" +
                "0 - Creditar\n" +
                "1 - Debitar\n" +
                "2 - Consultar Saldo\n" +
                "3 - Encerrar Conta\n" +
                "4 - Sair"

            var Op = int.Parse(Console.ReadLine());
        );
        } 
            switch (Op)
            {
                case 0: 
                if(conta1.getTipo() != 4 ){
                    Console.WriteLine("Digite o valor a ser creditado: ")
                    conta1.Creditar() = Int.TryParse(Console.ReadLine());

                    Console.WriteLine($"O novo saldo da conta é {conta1.getSaldo()}")
                } 
                else {
                    Console.WriteLine("Conta encerrada! Não é possivel realizar esta operação");
				}
                break;

                case 1: 
                if(conta1.getTipo() != 4 ){
                    Console.WriteLine("Digite o valor a ser creditado: ")
                    conta1.Debitar() = Int.TryParse(Console.ReadLine());

                    Console.WriteLine($"O novo saldo da conta é {conta1.getSaldo()}")
                } 
                else {
                    Console.WriteLine("Conta encerrada! Não é possivel realizar esta operação");
				}
                break;

                case 2: 
                    Console.WriteLine($"O saldo da conta é: {conta1.getSaldo()}")
                    break;

                case 3: 
                    if(conta1.getSaldo() <= 0){
                    conta1.EncerrarConta();
                    Console.WriteLine(conta1.EncerrarTexto());
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel encerrar a conta, retire todo o dinheiro");
                    }
                    break;
                case 4: 
                    Console.WriteLine("\nVolte sempre! :)")
                    break;
            }
        }
catch(Exception ErroAplicação)
{   
    Console.WriteLine("Ocorreu um erro! :(")
}

