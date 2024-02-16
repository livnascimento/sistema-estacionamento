using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColunaNomeTabelaVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Vagas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Vagas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
