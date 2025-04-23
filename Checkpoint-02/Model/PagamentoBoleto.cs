namespace Model
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras {get; set;}

        public PagamentoBoleto(decimal valor, string codigoBarras) : base(valor)
        {
            CodigoBarras = codigoBarras;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"PROCESSANDO PAGAMENTO DE R$ {Valor:F2} VIA BOLETO (COD BARRA: {CodigoBarras}) NA DATA {Data:dd/MM/yyyy}.");
        }
    }
}