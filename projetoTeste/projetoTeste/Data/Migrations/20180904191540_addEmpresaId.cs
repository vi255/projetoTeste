using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoTeste.Data.Migrations
{
    public partial class addEmpresaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Empresas_EmpresaIdEmpresa",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "EmpresaIdEmpresa",
                table: "Funcionarios",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_EmpresaIdEmpresa",
                table: "Funcionarios",
                newName: "IX_Funcionarios_EmpresaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Empresas_EmpresaId",
                table: "Funcionarios",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Empresas_EmpresaId",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Funcionarios",
                newName: "EmpresaIdEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_EmpresaId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_EmpresaIdEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Empresas_EmpresaIdEmpresa",
                table: "Funcionarios",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresas",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
