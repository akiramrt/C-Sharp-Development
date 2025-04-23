namespace Model
{
    public class PagamentoCartao : Pagamento{
        public string NumeroCartao { get; set; }
        public PagamentoCartao(decimal valor, string numeroCartao) : base(valor){
            NumeroCartao = numeroCartao;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"PROCESSANDO PAGAMENTO DE R$ {Valor:F2} VIA CARTÃO (NÚMERO: {NumeroCartao}) NA DATA {Data:dd/MM/yyyy}.");
        }
    }
}