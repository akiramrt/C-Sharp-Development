namespace Model
{
    public static class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("------ Sistem de Processamento de Pagamentos ------");
            Console.WriteLine("----------  Escolha a Forma de Pagamento ----------");
            Console.WriteLine("1. Cartão");
            Console.WriteLine("2. Boleto");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }
    }
}