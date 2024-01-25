using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime HorarioSaida { get; set; }
        public double TotalPago { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}