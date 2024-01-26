using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistema_estacionamento.Entities;

namespace sistema_estacionamento.Context
{
    public class EstacionamentoContext(DbContextOptions<EstacionamentoContext> options) : DbContext(options)
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
    }
}