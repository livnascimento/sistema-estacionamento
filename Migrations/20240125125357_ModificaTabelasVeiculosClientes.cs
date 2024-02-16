using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class ModificaTabelasVeiculosClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Registros_RegistroId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_RegistroId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RegistroId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "VagaId",
                table: "Veiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_VagaId",
                table: "Veiculos",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Vagas_VagaId",
                table: "Veiculos",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Vagas_VagaId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_VagaId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Veiculos");

            migrationBuilder.AddColumn<int>(
                name: "RegistroId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RegistroId",
                table: "Clientes",
                column: "RegistroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Registros_RegistroId",
                table: "Clientes",
                column: "RegistroId",
                principalTable: "Registros",
                principalColumn: "Id");
        }
    }
}
