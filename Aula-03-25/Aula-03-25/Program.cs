// ======================================AULA 25-03==========================================
using POO;

Console.Write("Entre com o nome: ");
string nome = Console.ReadLine();

Console.Write("Entre com o saldo em conta: ");
string input = Console.ReadLine();

Console.Write("Entre com o valor para depósito: ");
string input2 = Console.ReadLine();

Console.Write("Entre com o valor para sacar: ");
string input3 = Console.ReadLine();

if (!decimal.TryParse(input, out decimal saldo) || 
    !decimal.TryParse(input2, out decimal valorDep) ||
    !decimal.TryParse(input3, out decimal valorSaq))
{
    Console.WriteLine("Valor inválido!");
}
else
{
    try 
    {
        ContaBancaria conta = new ContaBancaria(nome, saldo);
        conta.ExibirSaldo();

        conta.Depositar(valorDep);
        conta.ExibirSaldo();

        conta.Sacar(valorSaq);
        conta.ExibirSaldo();
    } catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
}

// ==========================================================================================