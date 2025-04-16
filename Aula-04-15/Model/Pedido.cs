namespace Model 
{
    public class Pedido {
        public int ID {   get; set;   }

        public Pagamento FormaDePagamento {    get; set;   }

        public Pedido(int id, Pagamento formaDePagamento) {
            ID = id;
            FormaDePagamento = formaDePagamento;
        }

        public List<string> FinalizarPedido() {
            List<string> mensagem = new List<string>();

            mensagem.Add($"Finalizando pedido #{ID}");
            mensagem.Add(FormaDePagamento.ProcessarPagamento());
            mensagem.Add(FormaDePagamento.EmitirRecibo());

            return mensagem;
        }
    }
}