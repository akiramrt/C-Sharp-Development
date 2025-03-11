// ======================================AULA 14-02==========================================

// const double PI = 3.141592;
// const string nomeAplicacao = "Nome da Aplicação";

// Console.WriteLine(PI);
// Console.WriteLine(nomeAplicacao);

// ==========================================================================================

// int numero = 10;

// Console.WriteLine("Valor inicial: " + numero);

// numero += 5;

// Console.WriteLine("Valor após += 5: " + numero);

// ==========================================================================================

// int numero1 = 10;
// int numero2 = 20;

// Console.WriteLine("Número 1: " + numero1);
// Console.WriteLine("Número 2: " + numero2);
// Console.WriteLine("Número 1 > Número 2 ? " + (numero1 > numero2));

// ==========================================================================================

// bool isAdult = true;
// bool hasPermission = false;
// bool isMember = true;

// if (isAdult && hasPermission) {
//     Console.WriteLine("Acesso concedido! Você é adulto e tem permissão.");
// } else {
//     Console.WriteLine("Você não atende os requisitos.");
// }

// ==========================================================================================

bool wannaContinue = true;
while (wannaContinue) {
    Console.Clear();

    Console.Write("\nDigite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.Write("Digite o tipo de operação que você deseja fazer | + | - | * | / |: ");
    char choice = Console.ReadKey().KeyChar;

    switch (choice) {
        case '+':
            Console.WriteLine("\nA somatória dos números informados é: " + (num1 + num2));
            break;
        case '-':
            Console.WriteLine("\nA subtração dos números informados é: " + (num1 - num2));
            break;
        case '*':
            Console.WriteLine("\nA multiplicação dos números informados é: " + (num1 * num2));
            break;
        case '/':
            if (num2 != 0){
                Console.WriteLine("\nA divisão dos números informados é: " + (num1 / num2));
            } else {
                Console.WriteLine("Erro: Divisão por zero não é permitido!");
            }
            break;
        default:
            Console.WriteLine("\nOpcão inválida!");
            break;
    }

    Console.Write("\nVocê deseja realizar mais uma operação (S/N) ? ");
    char answer = Console.ReadKey().KeyChar;

    wannaContinue = (answer == 's' || answer == 'S');
}
// ==========================================================================================