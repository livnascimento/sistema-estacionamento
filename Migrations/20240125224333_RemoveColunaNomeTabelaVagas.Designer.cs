﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistema_estacionamento.Context;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoContext))]
    [Migration("20240125224333_RemoveColunaNomeTabelaVagas")]
    partial class RemoveColunaNomeTabelaVagas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sistema_estacionamento.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HorarioEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioSaida")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPago")
                        .HasColumnType("float");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId")
                        .IsUnique();

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ocupada")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Estacionado")
                        .HasColumnType("bit");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("VagaId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Registro", b =>
                {
                    b.HasOne("sistema_estacionamento.Entities.Veiculo", "Veiculo")
                        .WithOne("Registro")
                        .HasForeignKey("sistema_estacionamento.Entities.Registro", "VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Veiculo", b =>
                {
                    b.HasOne("sistema_estacionamento.Entities.Cliente", "Cliente")
                        .WithOne("Veiculo")
                        .HasForeignKey("sistema_estacionamento.Entities.Veiculo", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sistema_estacionamento.Entities.Vaga", "Vaga")
                        .WithMany()
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Cliente", b =>
                {
                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("sistema_estacionamento.Entities.Veiculo", b =>
                {
                    b.Navigation("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}
