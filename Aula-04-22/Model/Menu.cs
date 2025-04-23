namespace Model
{
    public static class Menu {
        public static void Show() {
            Console.WriteLine("\n---- Cadastro de Clientes ----");
            Console.WriteLine("1. Adicionar Cliente Comum");
            Console.WriteLine("2. Adicionar Cliente VIP");
            Console.WriteLine("3. Listar Clientes");
            Console.WriteLine("4. Sair");
        }

        public static byte GetOption() {
            Console.Write("Escolha uma opção: ");

            if (byte.TryParse(Console.ReadLine(), out byte opt)) {
                return opt;
            }

            return 0;
        }
    }
}