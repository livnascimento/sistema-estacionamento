using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Entities
{
    public class Vaga
    {
        public int Id { get; set; }
        public int Piso { get; set; }
        public bool Ocupada { get; set; }
    }
}