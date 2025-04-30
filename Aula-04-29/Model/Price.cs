using Interface;

namespace Model 
{
    public struct Price : IDisplay {
        public decimal Valor {    get; set;   }
        public string Moeda {    get; set;   }

        public Price(decimal valor, string moeda) {
            Valor = valor;
            Moeda = moeda;
        }

        public string Display() {
            return $"Preço: {Valor.ToString("N")} {Moeda}";
        }
    }
}