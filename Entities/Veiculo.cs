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
        public bool Estacionado { get; set;}

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Registro? Registro { get; set; }
    }
}