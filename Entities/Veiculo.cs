using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public DateTime HorarioEntrada { get; set; }

        public int VagaId { get; set; }
        public Vaga Vaga { get; set; }
        public Veiculo(string placa, string tipo, int vagaId, DateTime horarioEntrada)
        {
            Placa = placa;
            Tipo = tipo;
            VagaId = vagaId;
            HorarioEntrada = horarioEntrada;
        }

        public Veiculo()
        {
        }

    }

}