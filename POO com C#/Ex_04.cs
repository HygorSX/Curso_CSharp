namespace TreinaWeb;

class Program
{
    public class Biblioteca
    {
        public int Emprestimo { get; set; }
    }
    static void Main(string[] args)
    {
        //2. Fazer um sistema de biblioteca (Deve imprimir 
        // uma lista com 10 livros, pedir o nome do solicitante 
        //do empréstimo, pedir para selecionar um livro e 
        // imprimir o livro selecionado)-Criar usando classes

        try
        {
            System.Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Bem-vindo a Biblioteca Gama! Os livros para empréstimo são: \n" +
                "[0] O universo numa casca de noz,\n" +
                "[1] Uma breve história do tempo,\n" +
                "[2] O grande projeto,\n" +
                "[3] A teoria de tudo"
                );
          
            var livros = new List<string> { "O universo numa casca de noz", "Uma breve história do tempo", "O grande projeto", "A teoria de tudo" };
            int escolha_livro = int.Parse(Console.ReadLine());

            if (escolha_livro >= 0 && escolha_livro < livros.Count)
            {
                Biblioteca emprestimo = new Biblioteca();
                emprestimo.Emprestimo = escolha_livro;

                System.Console.WriteLine($"O livro {livros[escolha_livro]} foi emprestado para você, tenha uma boa leitura {name}!");
            }
            else
            {
                System.Console.WriteLine("ERRO!\a Digite uma opção válida");
            }
        }

        catch (Exception ErroString)
        {
            Console.WriteLine(ErroString.Message);
            Console.WriteLine("Caracteres de texto não são aceitos, digite um número");
        }
    }
}
