using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColunaEstacionadoTabelaVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estacionado",
                table: "Veiculos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estacionado",
                table: "Veiculos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
