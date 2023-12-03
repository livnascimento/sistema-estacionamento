using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Models
{
    public class Estacionamento
    {        
        private double valorInicial, valorHora, totalApurado;
        private static List<string> veiculos;
        public double ValorInicial { 
            get => valorInicial; 
            set {
                if (value == 0.0)
                {
                    throw new ArgumentException("O valor inicial não pode ser zero.");
                }
                valorInicial = value;
            } 
        }
        public double ValorHora { 
        
            get => valorHora; 
            set {
                if (value == 0.0)
                {
                    throw new ArgumentException("O valor por hora não pode ser zero.");
                }
                valorHora = value;
            }
        }
        public List<string> Veiculos { 
            get => veiculos; 
            set => veiculos = value;
        }
        public double TotalApurado { 
            get => totalApurado; 
            set => totalApurado = value; 
        }
        public void AdicionarVeiculo(string veiculo) 
        {
            Console.Clear();
            if (string.IsNullOrEmpty(veiculo)) 
            {
                Console.WriteLine("Placa inválida.");
            }
            else
            {
                Veiculos.Add(veiculo);
                Console.WriteLine("Veículo adicionado.");
            }
        }

        public void RemoverVeiculo(string veiculo, int horas) 
        {
            Console.Clear();
            if (!veiculos.Contains(veiculo))
            {
                Console.WriteLine($"Veículo de placa {veiculo} não foi adicionado.");
            }
            else
            {
                Veiculos.Remove(veiculo);  
                double total = CalcularTotal(horas);
                TotalApurado += total;
                
                Console.WriteLine($"Veículo removido, o total a pagar é de: {total:C}");
            }
        }

        public void ListarVeiculos()
        {
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

        public void FecharCaixa()
        {
            if (Veiculos.Count > 0)
            {
                Console.WriteLine($"Impossível fechar o caixa, pois ainda há carros no estacionamento.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("------------- Encerrando programa -------------\n");
                Console.WriteLine($"O total apurado foi {TotalApurado:C}\n");
                Console.WriteLine("Até amanhã :)\n\n");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
        }

        public double CalcularTotal(int horas) => valorInicial + (valorHora * horas);

    }
}