using System.Reflection.Metadata;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string? input = Console.ReadLine();
            string placa = input?.ToUpper() ?? ""; // Se input for nulo, usa uma string vazia

            // string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string? input = Console.ReadLine();
            string placa = input?.ToUpper() ?? ""; // Se input for nulo, usa uma string vazia

            // string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 

                horas = Convert.ToInt32(Console.ReadLine());

                if(horas <= 2){
                    precoInicial = precoInicial - 0.30m; 
                }

                decimal valorParcial = precoPorHora * horas;
                valorTotal = precoInicial + valorParcial;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido!");
                Console.WriteLine($"O valor de Entrada no Estacionamento foi de R$ {precoInicial}.");
                Console.WriteLine($"A Quantidade de Horas foi de {horas}, com um total parcial de R$ {valorParcial}");
                Console.WriteLine($"preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (String veiculosEstacionados in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculosEstacionados}");                    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
