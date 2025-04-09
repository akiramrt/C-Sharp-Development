namespace Model
{
    public class Cliente : Pessoa
    {
        //Atributo
        private DateOnly? dataUltimaCompra;

        //propriedade
        public DateOnly? DataUltimaCompra
        {
            get { return dataUltimaCompra; }
            set { dataUltimaCompra = value; }
        }

        //Método
        public override void Cadastar(string nome, string cpf, string celular, DateOnly? dataUltCompra)
        {
            base.Cadastar(nome, cpf, celular);

            DataUltimaCompra = dataUltCompra;
        }

        public override string ExibirInformacoes()
        {
            return base.ExibirInformacoes() + " Data da última compra: " + DataUltimaCompra;
        }
    }
    
}