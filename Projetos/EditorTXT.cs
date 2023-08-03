// See https://aka.ms/new-console-template for more information
using System.IO;

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{

}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("_______________________________________");
    string text = "";


    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
        //quebrando a linha no fim de cada leitura

    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);
    //enquanto o usuário não apertar ESC, ele não poderá sair
    Console.WriteLine(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

}
