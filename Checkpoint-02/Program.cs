using Model;

Console.Clear();
bool continuar = true;

while(continuar){
    Console.WriteLine("");
    Menu.ExibirMenu();
    string opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine();

            Console.Write("Informe o valor do pagamento: ");
            decimal valorCartao = decimal.Parse(Console.ReadLine());
            
            var pagamentoCartao = new PagamentoCartao(valorCartao, numeroCartao);
            pagamentoCartao.ProcessarPagamento();
            break;
        
        case "2":        
            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine();

            Console.Write("Informe o valor do pagamento: ");
            decimal valorBoleto = decimal.Parse(Console.ReadLine());

            var pagamentoBoleto = new PagamentoBoleto(valorBoleto, codigoBarras);
            pagamentoBoleto.ProcessarPagamento();
            break;
        
        case "3":
            continuar = false;
            Console.WriteLine("Você Saiu.");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;

        if (continuar){
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}