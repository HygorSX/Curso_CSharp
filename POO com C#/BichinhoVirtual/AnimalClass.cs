using System.Threading.Channels;

namespace TreinaWeb
{
    class Program
    {
        public class Animais
        {
            public string nome { get; set; }
            public string classe { get; set; }
            public string familia { get; set; }
            public int idade { get; set; }
            public bool estado { get; set; }
            public int caloria { get; set; }
            public int forca { get; set; }

            public Animais(string nome, string classe, string familia, int idade, bool estado, int caloria, int forca)
            {
                this.nome = nome;
                this.classe = classe;
                this.familia = familia;
                this.idade = idade;
                this.estado = estado;
                this.caloria = caloria;
                this.forca = forca;
            }

            public Animais(string nome, string classe, string familia)
            {
                this.nome = nome;
                this.classe = classe;
                this.familia = familia;
                this.forca = 10;
                this.caloria = 0;
                this.idade = 0;
                this.estado = true;

            }
            public String getNome()
            {
                return nome;
            }

            public String getClasse()
            {
                return classe;
            }

            public String getFamilia()
            {
                return familia;
            }

            public Int32 getIdade()
            {
                return idade;
            }

            public Boolean getEstado()
            {
                return estado;
            }

            public Int32 getCaloria()
            {
                return caloria;
            }

            public Int32 getForca()
            {
                return forca;
            }
            public String Nasceu()
            {
                return $"O nome do animal é {this.nome}, pertencente a familia {this.familia}, da classe {this.classe}.\n O animal possui força de {this.forca}, {this.caloria} calorias, e {this.idade} anos";
            }

            public String Morrer()
            {
                this.forca = 0;
                this.estado = false;

                return "O animal morreu! :(";
            }
            public String Comer()
            {
                if (this.caloria < 100 && this.estado == true)
                {
                    this.caloria += 10;
                    this.forca -= 2;

                    return $"O animal comeu, agora sua força é de {this.forca}, e tem {this.caloria} calorias!";
                }
                else if (this.caloria >= 100)
                {
                    return "O animal já está cheio :)";
                }
                else
                {
                    return "O animal está morto :(";
                }
            }
            public String Correr()
            {
                if (this.estado = true && this.caloria > 0)
                {
                    this.forca -= 5;
                    this.caloria -= 5;

                    return $"O animal está correndo!! Agora sua força é de {this.forca} e suas calorias valem {this.caloria}";
                }
                else if (this.caloria == 0)
                {
                    return "O animal está exausto :(";
                }
                else
                {
                    return "O animal está morto :(";
                }
            }
            public String Dormir()
            {
                if (this.estado == true)
                {
                    this.forca += 10;
                    this.caloria -= 2;

                    return $"O animal está dormindo! Sua força aumentou para {this.forca} e suas calorias desceram para {this.caloria}";
                }
                else
                {
                    return "O animal está morto :(";
                }
            }


            static void Main(string[] args)
            {

                try
                {
                    Console.WriteLine("Crie o seu animalzinho! Digite o nome: ");
                    String nome = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Digite a classe do animal: ");
                    String classe = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Digite a familia: ");
                    String familia = Console.ReadLine();
                    Console.WriteLine("");

                    Animais a1 = new Animais(nome, classe, familia);
                    Console.WriteLine("");
                    Console.WriteLine(a1.Nasceu());
                    Console.WriteLine("");

                    Console.WriteLine($"O que {a1.nome} irá fazer? \n" +
                        "0 - Comer\n" +
                        "1 - Correr\n" +
                        "2 - Dormir\n" +
                        "3 - Morrer"
                        );

                    var Op = int.Parse(Console.ReadLine());

                    if (Op >= 0 && Op <= 3)
                    { 
                        switch (Op)
                        {
                            case 0: Console.WriteLine(a1.Comer()); break;

                            case 1: Console.WriteLine(a1.Correr()); break;

                            case 2: Console.WriteLine(a1.Dormir()); break;

                            case 3: Console.WriteLine(a1.Morrer()); break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERRO!\a Opção inválida");
                    }
                }
                catch (Exception ErroGenerico)
                {
                    Console.WriteLine(ErroGenerico.Message);
                }
            }
        }
    }
}
