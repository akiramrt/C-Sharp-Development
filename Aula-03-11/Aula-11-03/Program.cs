// ======================================AULA 11-03==========================================

using teste;

// ==========================================================================================

Functions.Saudacao("edu");

// ==========================================================================================

int num = 8;
if (Functions.EhPar(num))
    Console.WriteLine($"{num} é um número par.");
else
    Console.WriteLine($"{num} é um número ímpar.");

// ==========================================================================================

Functions.ExibirTabuada(10);

// ==========================================================================================

Functions.VerificarNumero(-3);
Functions.VerificarNumero(3);

// ==========================================================================================

List<string> tarefas = new List<string>();
string tarefa;
string continuar = "s";

while (continuar.ToLower() == "s")
{
    Console.Write("Digite uma tarefa para adicionar à lista: ");
    tarefa = Console.ReadLine() ?? "";
    tarefas.Add(tarefa);

    Console.Write("Deseja adicionar outra tarefa (S/N)? ");
    continuar = Console.ReadLine() ?? "n";
}

Functions.ExibirTarefas(tarefas);
    
// ==========================================================================================

List<int> numeros = new List<int>();
int numero;

do
{
    Console.Write("Digite um número para a soma (0 para sair): ");
    
    if (!int.TryParse(Console.ReadLine(), out numero)) {
        Console.WriteLine("Valor inválido, tente novamente.");
        continue;
    }

    if (numero != 0) 
        numeros.Add(numero);

} while (numero != 0);

Functions.ExibirNumerosDaSoma(numeros);