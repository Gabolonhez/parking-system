namespace Park.Models
{
    public class Parking
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Parking(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();
           if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Essa placa não é válida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa) && veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                string? inputHoras = Console.ReadLine();
                if (!int.TryParse(inputHoras, out horas) || horas == 0)
                {
                    Console.WriteLine("Horas inexistentes, tente novamente adicionar uma hora");
                    return;
                }

                decimal valorTotal = precoInicial + precoPorHora * horas;

                if (valorTotal == 0)
                {
                    Console.WriteLine("Valor total inexistente, adicione novamente");
                }

                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}