using Model;

Console.Write("Digite o número do pedido: ");
int numeroPedido = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do pedido: ");
decimal valor = decimal.Parse(Console.ReadLine());

Console.Write("Escolha a forma de pagamento (Cartão ou Boleto): ");
string formaPagamento = Console.ReadLine().Trim().ToLower();

Pagamento pagamento;

if (formaPagamento == "cartão" || formaPagamento == "cartao") {

    Console.Write("Digite o número do cartão: ");
    string numeroCartao = Console.ReadLine();
    pagamento = new PagamentoCartao(valor, numeroCartao);

} else if (formaPagamento == "boleto") {

    Console.Write("Digite o código de barras: ");
    string codigoBarras = Console.ReadLine();
    pagamento = new PagamentoBoleto(valor, codigoBarras);

} else {
    Console.Write("Opção Inválida!");
    return;
}

Pedido pedido = new Pedido(numeroPedido, pagamento);

Console.WriteLine("----- Resultado -----");

foreach (var msg in pedido.FinalizarPedido()) {
    Console.WriteLine(msg);
}

Console.ReadLine();