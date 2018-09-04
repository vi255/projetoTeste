using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoTeste.Data.Migrations
{
    public partial class addEmpresaNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Funcionarios");
        }
    }
}
