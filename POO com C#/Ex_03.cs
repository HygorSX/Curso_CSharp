//1. Fazer um cadastro de viagem (Deve pedir o nome do 
//viajante, dar as opções de destino e imprimir a 
//selecionada)-Criar usando classes
    
    public class Usuario
    {
        public string Name {get; set;}
    }

    Usuario viajante = new Usuario();
    Console.WriteLine("Olá viajante! Qual o seu nome?");
    viajante.Name = Console.Readline();
    Console.WriteLine($"Olá {viajante.Name}, vamos dar continuidade ao seu atendimento");
    Console.WriteLine("Selecione um de nossos destinos:\n 0 = Rio Grande Do Norte\n 1 = João Pessoa\n 2 = Rio Grande Do Sul\n 3 = Rio de Janeiro");
    int Opcao = int.Parse(Console.Readline());
    string[] destinos = {"RN", "JP", "RS","RJ"}

    switch(Opcao)
    {
    case 0:
            Console.WriteLine($"Sua viagem ao {destinos[0]} será marcada :)");
            break;
    case 1:
            Console.WriteLine($"Sua viagem ao {destinos[1]} será marcada :)");
            break;
    case 2:
            Console.WriteLine($"Sua viagem ao {destinos[2]} será marcada :)");
            break;
    case 3:
            Console.WriteLine($"Sua viagem ao {destinos[3]} será marcada :)");
            break;
    default: 
        Console.WriteLine("ERRO! Digite um caracter válido!")
    }
