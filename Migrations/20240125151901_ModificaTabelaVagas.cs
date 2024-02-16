using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class ModificaTabelaVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Vagas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Vagas");
        }
    }
}
