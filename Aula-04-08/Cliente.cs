namespace POO
{
    public abstract class Cliente {

        public string Nome { get; set; }
        public string Email { get; set; }

        //private string _nome;
        // private string _email;

        // public string Nome {
        //     get {   return _nome;    }
        //     set {   _nome = value;    }
        // }

        // public string Email {
        //     get {   return _email;    }
        //     set {   _email = value;    }
        // }
        
        //Método abstrato que força subclasses a implementar a validação
        public abstract bool ValidarCadastro();

        public virtual void ExibirInformacoes(){
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
        }

    }
}