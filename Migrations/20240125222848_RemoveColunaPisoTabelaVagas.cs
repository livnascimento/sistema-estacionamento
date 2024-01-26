using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColunaPisoTabelaVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Piso",
                table: "Vagas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Piso",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
