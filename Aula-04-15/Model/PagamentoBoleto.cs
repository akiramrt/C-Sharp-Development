using Interface;

namespace Model
{
    public class  PagamentoBoleto : Pagamento, IPagavel {
        public string CodigoBarras {    get; set;   }

        public PagamentoBoleto(decimal valor, string codigoBarras) : base(valor) {
            CodigoBarras = codigoBarras;
        }

        public override string ProcessarPagamento() {
            return $"Processando pagamento via boleto: {CodigoBarras}";
        }
    }
}