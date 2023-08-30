public class Animais
{
    public string nome {get; set;}
    public string classe {get; set;}
    public string familia {get; set;}
    public int idade {get; set;}
    public bool estado {get; set;}
    public int caloria {get; set;}
    public int forca {get; set;}

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
    public String getNome() {
    	return nome;
	}

	public String getClasse() {
		return classe;
	}

	public String getFamilia() {
		return familia;
	}

	public Integer getIdade() {
		return idade;
	}

	public Boolean getEstado() {
		return estado;
	}

	public Integer getCaloria() {
		return caloria;
	}

	public Integer getForca() {
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
        if(this.caloria < 100 && this.estado = true)
        {
            this.caloria += 10;
            this.forca -= 2;

            return $"O animal comeu, agora sua força é de {this.forca}, e tem {this.caloria} calorias!";
        }
        else if(this.caloria >= 100)
        {
            return "O animal já está cheio :)";
        }
        else
        {
            return "O animal está morto :(";
        }
    }
    public void Correr()
    {
        if(this.estado = true && this.caloria > 0)
        {
            this.forca -= 5;
            this.caloria -= 5;

            return $"O animal está correndo!! Agora sua força é de {this.forca} e suas calorias valem {this.caloria}";
        }
        else if(this.caloria = 0)
        {
            return "O animal está exausto :(";
        }
        else
        {
            return "O animal está morto :(";
        }
    }
    public void Dormir()
    {
        if(this.estado = true)
        {
            this.forca += 10;
            this.caloria -= 2;

            return $"O animal está dormindo! Sua força aumentou para {this.forca} e suas calorias subiram para {this.caloria}";
        }
        else
        {
            return "O animal está morto :("
        }
    }
