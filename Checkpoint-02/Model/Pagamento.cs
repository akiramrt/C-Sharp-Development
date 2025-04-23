namespace Model
{
    public abstract class Pagamento{
        public decimal Valor { get; set; }
            
        public DateTime Data { get; set; }

        public Pagamento(decimal valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }
        public abstract void ProcessarPagamento();
    }
}