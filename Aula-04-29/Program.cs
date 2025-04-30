using Model;

List<Product> produtoList = new List<Product>();

Console.Write("Quantos produtos você deseja cadastrar? ");
int numProdcts = int.Parse(Console.ReadLine());

for (int i = 0; i < numProdcts; i++) {
    Console.WriteLine($"Cadastro do Produto {i + 1}");

    Console.Write("Digite o nome do produto: ");
    string produtoNome = Console.ReadLine();

    Console.Write("Digite a quantidade de produtos: ");
    int quantidade = int.Parse(Console.ReadLine());

    Console.Write("Digite o preço do produtos: ");
    decimal precoProduto = decimal.Parse(Console.ReadLine());

    Console.Write("Digite a moeda(ex. USD, BRL, EUR, ...): ");
    string moeda = Console.ReadLine();


    Price price = new Price(precoProduto, moeda);
    Product produto = new Product(produtoNome, quantidade, price);

    produtoList.Add(produto);
}

Console.WriteLine("\nProdutos cadastrados: ");
foreach (Product prod in produtoList)
    Console.WriteLine(prod.Display());