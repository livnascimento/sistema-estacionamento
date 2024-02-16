using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaColunaHorarioEntrada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HorarioEntrada",
                table: "Veiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorarioEntrada",
                table: "Veiculos");
        }
    }
}
