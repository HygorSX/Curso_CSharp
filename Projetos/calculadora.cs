// See https://aka.ms/new-console-template for more information
Menu();


static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    System.Console.WriteLine("");

    Console.WriteLine("Selecione uma opção");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        default: Menu(); break;

    }

}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float numUsuario1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float numUsuario2 = float.Parse(Console.ReadLine());


    Console.WriteLine("");

    float resultado = numUsuario1 + numUsuario2;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float numUsuario1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float numUsuario2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = numUsuario1 - numUsuario2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float numUsuario1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float numUsuario2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = numUsuario1 / numUsuario2;
    Console.WriteLine($"O resultado da divisao é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float numUsuario1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float numUsuario2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = numUsuario1 * numUsuario2;
    Console.WriteLine($"O resultado da multiplicacao é: {resultado}");
    Console.ReadKey();
    Menu();
}

