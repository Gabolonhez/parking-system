using Park.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

while (true)
{
    Console.WriteLine("Digite o preço inicial:");
    if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
        break;
    Console.WriteLine("Valor inválido. Tente novamente.");
}

while (true)
{
    Console.WriteLine("Agora digite o preço por hora:");
    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
        break;
    Console.WriteLine("Valor inválido. Tente novamente.");
}

Parking es = new Parking (precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida, tenta novamente com uma opção válida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");