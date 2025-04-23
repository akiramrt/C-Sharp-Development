using Interface;

namespace Model 
{
    public class ClienteVIP : Cliente, IPrintable {
        public ClienteVIP (string nome, string sobrenome) : base (nome, sobrenome) { }

        public override string MostrarTipo() {
            return "Tipo: Cliente VIP";
        }
    
        public string PrintDetails() {
            return $"Nome: {Nome} {Sobrenome}";
        }
    }
}