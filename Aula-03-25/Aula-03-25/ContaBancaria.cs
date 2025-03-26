namespace POO
{
    public class ContaBancaria
    {
        private string titular;
        private decimal saldo;
        private const decimal tarifaSaque = 2.5m;

        public string Titular
        {
            get { return titular; }
            set { 
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("O nome não pode ser vazio!");
                    } else {
                        titular = value; 
                    }
                }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public ContaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
        }
        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular} - Saldo: R$ {saldo}");
        }

        public void Sacar(decimal valor)
        {   
            decimal valorTotal = valor + tarifaSaque;
            
            if (valor <= 0){
                Console.WriteLine("Valor para saque inválido. Digite um número maior que zero.");
            } else if (valorTotal <= Saldo) {
                Saldo -= valorTotal;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso! Tarifas inclusas: R$ {tarifaSaque}");
                Console.WriteLine($"Saldo atual R$ {valor}");
            } else {
                Console.WriteLine($"Saldo insuficiente.");
            }
        }
    }
}