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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Cliente)
                .WithOne(v => v.Veiculo)
                .HasForeignKey<Veiculo>(v => v.ClienteId)
                .IsRequired();
                
            modelBuilder.Entity<Registro>()
                .HasOne(r => r.Veiculo)
                .WithOne(r => r.Registro)
                .HasForeignKey<Registro>(r => r.VeiculoId)
                .IsRequired();
        }
    }
}