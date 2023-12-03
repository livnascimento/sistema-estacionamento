using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Models
{
    public class Estacionamento
    {        
        private double valorInicial, valorHora;
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
        public void AdicionarVeiculo(string veiculo) 
        {
            if (string.IsNullOrEmpty(veiculo)) 
            {
                throw new ArgumentException("Placa inválida.");
            }
            Veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(string veiculo) 
        {
            if (!veiculos.Contains(veiculo))
            {
                throw new ArgumentException($"Veículo de placa {veiculo} não foi adicionado.");
            }
            Veiculos.Remove(veiculo);
        }

        public void ListarVeiculos()
        {
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

        public double CalcularTotal(int horas) => valorInicial + (valorHora * horas);

    }
}