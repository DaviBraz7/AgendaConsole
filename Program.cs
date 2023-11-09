
class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar Contato");
            Console.WriteLine("2 - Editar Contato");
            Console.WriteLine("3 - Excluir Contato");
            Console.WriteLine("4 - Visualizar Contatos");
            Console.WriteLine("0 - Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarContato(agenda);
                    break;

                case "2":
                    EditarContato(agenda);
                    break;
            
                case "3":
                    ExcluirContato(agenda);
                    break;
                
                case "4":
                    VisualizarContatos(agenda);
                    break;

                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarContato(Agenda agenda)
    {
        Contato novoContato =  new Contato();

        Console.WriteLine("Nome: ");
        novoContato.Nome = Console.ReadLine();

        Console.WriteLine("Telefone: ");
        novoContato.Telefone = Console.ReadLine();

        Console.WriteLine("Email: ");
        novoContato.Email =  Console.ReadLine();

        agenda.AdicionarContato(novoContato);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    static void EditarContato(Agenda agenda)
    {
        Console.WriteLine("Digite o nome do contato que deseja editar: ");
        string nome = Console.ReadLine();

        Contato novoContato =  new Contato();

        Console.WriteLine("Novo nome: ");
        novoContato.Nome = Console.ReadLine();

        Console.WriteLine("Novo Telefone: ");
        novoContato.Telefone = Console.ReadLine();

        Console.WriteLine("Novo Email:  ");
        novoContato.Email = Console.ReadLine();

        agenda.EditarContato(nome, novoContato);
        Console.WriteLine("Contato editado com sucesso!");
    }

    static void ExcluirContato(Agenda agenda)
    {
        Console.WriteLine("Digite oo nome do contato qque deseja excluir");
        string nome  = Console.ReadLine();

        agenda.ExcluirContato(nome);
        Console.WriteLine("Contato excluído com sucesso!");

    }

    static void VisualizarContatos(Agenda agenda)
    {
        Console.WriteLine("\nLista de contatos:");
        agenda.visualizarContatos();
    }
}