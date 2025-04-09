namespace Model
{
    public class Pessoa
    {
        //atributos (encapsulamento)
        private string nome;
        private string cpf;
        private string celular;

        //propriedades
        private string Nome
        {
            get {return nome;}
            set {nome = value;}
        }
        private string CPF
        {
            get {return cpf;}
            set 
            {
                string digitos = "";
                                    
                foreach (char c in value)
                {
                    //Verifica se é número
                    if (char.IsDigit(c))
                    {
                        digitos += c;
                    }
                }
                
                //Verifica se tem 11 digitos
                if (digitos.Length != 11)
                {
                    throw new ArgumentException("CPF Inválido!");
                }

                cpf = string.Format("{0}.{1}.{2}-{3}",
                                        digitos.Substring(0,3),
                                        digitos.Substring(3,3),
                                        digitos.Substring(6,3),
                                        digitos.Substring(9,2));
            }
        }
        private string Celular
        {
            get {return celular;}
            set {celular = value;}
        }

        //Método
        public virtual void Cadastar(string nome, string cpf, string celular, DateOnly? dataUltCompra = null)
        {
            Nome = nome;
            CPF = cpf;
            Celular = celular;
        }
        public virtual string ExibirInformacoes()
        {
            string infoFormatada = PessoaInfoFormat.FormatarInformacoes(Nome, CPF, Celular);
            return infoFormatada;
        }

        private static class PessoaInfoFormat
        {
            public static string FormatarInformacoes(string nome, string cpf, string celular)
            {
                return $"Nome: {nome} CPF: {cpf} Celular: {celular}";
            }
        }
    }
    
}