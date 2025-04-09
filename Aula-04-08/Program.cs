// ======================================AULA 08-04==========================================

using POO;

// ==========================================================================================

Console.Write("Digite o nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o e-mail: ");
string email = Console.ReadLine();

Console.Write("Digite o CPF: ");
string cpf = Console.ReadLine();


ClientePF cliente = new ClientePF();

cliente.Nome  = nome;
cliente.Email = email;
cliente.CPF  = cpf;


if (cliente.ValidarCadastro()){
    cliente.ExibirInformacoes();
} else {
    Console.WriteLine("CPF Inválido");
}