using Model;
using Repository;
using Interface;

byte option;
ClienteRepository repository = new ClienteRepository();
Console.Clear();

do {
    Menu.Show();
    option = Menu.GetOption();

    switch (option) {
        case 1:
        case 2:
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Cliente cliente = option == 1 ? new ClienteComum(nome, sobrenome) : new ClienteVIP(nome, sobrenome);
            
            repository.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!\n");
            break;

        case 3:
            List<Cliente> todos = repository.GetAll();

            if (todos.Count == 0) {
                Console.WriteLine("Nenhum cliente cadastrado.\n");
                break;
            }

            Console.WriteLine("\n---- Cliente Cadastrados ----\n");
            foreach (Cliente c in todos) {
                Console.WriteLine(c.MostrarTipo());
                Console.WriteLine(((IPrintable)c).PrintDetails() + "\n");
            }

            break;

        case 4:
            Console.WriteLine("Você Saiu.\n");
            break;

        default:
            Console.WriteLine("Opção Inválida!\n");
            break;
    }
} while (option != 4);