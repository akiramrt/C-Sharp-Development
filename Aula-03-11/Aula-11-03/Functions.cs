namespace teste
{
    public class Functions {
        public static void Saudacao(string name) {
            Console.WriteLine($"Olá, {name}!");
        }

    public static bool EhPar(int numero) {
        return (numero % 2 == 0);
    }

    public static void ExibirTabuada(int numero) {
        Console.WriteLine($"Tabuada do {numero}: ");
        for(int i = 1; i <= 10; i++){
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    public static void VerificarNumero(int numero) {
        if(numero > 0) {
            Console.WriteLine("O número é positivo.");
        } else {
            Console.WriteLine("O número é negativo.");
        }
    }

    public static void ExibirTarefas(List<string> tarefas){
        Console.WriteLine("\nLista de tarefas:");
        foreach (var item in tarefas)
        {
            Console.WriteLine($" - {item}");
        }
    }

    public static void ExibirNumerosDaSoma(List<int> lista){
        int soma = 0;
        Console.WriteLine("\nNúmeros digitados:");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
            soma += item;
        }

        Console.WriteLine($"Soma total: {soma}");
    }

    }
}