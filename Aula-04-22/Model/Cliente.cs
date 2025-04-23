namespace Model 
{
    public abstract class Cliente {
        public string Nome {    get; set;   }
        public string Sobrenome {    get; set;   }

    public Cliente (string nome, string sobrenome) {
        Nome      = nome;
        Sobrenome = sobrenome;
    }

    public abstract string MostrarTipo();

    }
}