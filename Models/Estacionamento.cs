using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Models
{
    public class Estacionamento
    {
        public double ValorInicial { get; set; }
        public double ValorPorHora { get; set; }
        public double ApuradoTotal { get; set; }

        public Estacionamento(double valorInicial, double valorPorHora)
        {
            ValorInicial = valorInicial * 100;
            ValorPorHora = valorPorHora * 100;
        }

        public double CalcularTotal(DateTime horarioEntrada)
        {
            DateTime horarioSaida = DateTime.Now;
            TimeSpan permanencia = horarioSaida - horarioEntrada;

            double horas = permanencia.TotalHours;
            return ValorInicial + (ValorPorHora * horas);
        }

    }
}