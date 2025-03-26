// ======================================AULA 28-02==========================================

// Console.Write("Digite um número inteiro: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0){
//     Console.WriteLine($"O número {number} é par");
// } else {
//     Console.WriteLine($"O número {number} é ímpar");
// }

// ==========================================================================================

// Console.Write("Digite um número para ver a Tabuada: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Tabuada do número {number}:");

// for (int i = 1; i <= 10; i++)
//     Console.WriteLine($"{number} x {i} = {number * i}");

// ==========================================================================================

// int[] numbers = {10, 20, 30, 40, 50};
// int sum = 0;

// foreach (int item in numbers)
//     Console.WriteLine(item);

// foreach (int item in numbers)
//     sum += item;

// Console.WriteLine($"A soma dos números é {sum}");

// ==========================================================================================

// string[] fruits = {"Maça", "Banana", "Laranja", "Uva"};
// Console.WriteLine("Lista de frutas: ");

// foreach (var item in fruits)
//     Console.WriteLine(item);

// ==========================================================================================

// Dictionary<string, int> age = new Dictionary<string, int>() {
//     {"João", 25},
//     {"Maria", 30},
//     {"Pedro", 22},
//     {"Fábio", 47}
// };

// foreach (var people in age)
//     Console.WriteLine($"{people.Key} tem {people.Value} anos.");

// ==========================================================================================

// List<int> numbers = new List<int> {10, 20, 30, 40, 50};
// Console.WriteLine("Números da Lista: ");

// foreach (int item in numbers)
//     Console.WriteLine(item);

// ==========================================================================================

// int number;
// do {
//     Console.Write("Digite um número positivo: ");
//     number = Convert.ToInt32(Console.ReadLine());

//     if (number < 0)
//         Console.WriteLine("Número inválido, tente novamente.");
    
// } while (number < 0);

// Console.WriteLine($"Número válido inserido: {number}");

// ==========================================================================================

// Console.Write("Tabuada do 1 ao 5:");

// for (int i = 1; i <= 5; i++){
//     Console.WriteLine($"Tabuada do: {i}");

//     for (int j = 1; j <= 10; j++)
//         Console.WriteLine($"{i} x {j} = {i * j}");
// }

// ==========================================================================================

// int Sum ( int num1, int num2){
//     return num1 + num2;
// }

// int Sub ( int num1, int num2){
//     return num1 - num2;
// }

// int Div ( int num1, int num2){
//     return num1 / num2;
// }

// int Mult ( int num1, int num2){
//     return num1 * num2;
// }

// void returnMessage (string message){
//     Console.Write(message);
// }

// Console.WriteLine(Sum(10, 2));
// Console.WriteLine(Sub(10, 2));
// Console.WriteLine(Div(10, 2));
// Console.WriteLine(Mult(10, 2));

// returnMessage("Fim");

// ==========================================================================================