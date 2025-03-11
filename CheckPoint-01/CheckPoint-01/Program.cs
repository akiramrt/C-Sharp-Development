static (double, double) CollectNumbers()
{
    Console.Write("\nDigite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    return (num1, num2);
}

double Sum ( double num1, double num2 ) {
    return num1 + num2;
}

double Sub ( double num1, double num2 ) {
    return num1 - num2;
}

double Div ( double num1, double num2 ) {
    return num1 / num2;
}

double Mult ( double num1, double num2 ) {
    return num1 * num2;
}

bool wannaContinue = true;
    while (wannaContinue) {
        Console.Clear();

        Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine(" 1. Adição");
        Console.WriteLine(" 2. Subtração");
        Console.WriteLine(" 3. Multiplicação");
        Console.WriteLine(" 4. Divisão");
        Console.WriteLine(" 5. Sair");
        Console.Write("Resposta: ");

        char choice = Console.ReadKey().KeyChar;

        double num1 = 0;
        double num2 = 0;

        switch (choice)
        {
            case '1':
                (num1, num2) = CollectNumbers();
                Console.WriteLine($"\nA somatória dos números informados é: {Sum(num1, num2)}");
                break;
            case '2':
                (num1, num2) = CollectNumbers();
                Console.WriteLine($"\nA subtração dos números informados é: {Sub(num1, num2)}");
                break;
            case '3':
                (num1, num2) = CollectNumbers();
                Console.WriteLine($"\nA multiplicação dos números informados é: {Mult(num1, num2)}");
                break;
            case '4':
                (num1, num2) = CollectNumbers();
                if (num2 != 0) {
                    Console.WriteLine($"\nA divisão dos números informados é: {Div(num1, num2)}");
                } else {
                    Console.WriteLine("\nErro: Divisão por zero não é permitido!");
                }
                break;
            case '5':
                Console.WriteLine("\nVocê saiu.");
                wannaContinue = false;
                continue;
            default:
                Console.WriteLine("\nOpção inválida!");
                break;
        }

        Console.Write("\nVocê deseja realizar mais uma operação (S/N)? ");

        char answer = Console.ReadKey().KeyChar;
        
        wannaContinue = (answer == 's' || answer == 'S');
}