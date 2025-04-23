using Interface;

namespace Model 
{
    public class ClienteComum: Cliente, IPrintable {
        public ClienteComum(string nome, string sobrenome) : base(nome, sobrenome) { }

        public override string MostrarTipo() {
            return "Tipo: Cliente Comum";
        }
    
        public string PrintDetails() {
            return $"Nome: {Nome} {Sobrenome}";
        }
    }
}