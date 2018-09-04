using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoTeste.Data.Migrations
{
    public partial class addEmpresaFuncionarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: false),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    EndRua = table.Column<string>(nullable: true),
                    EndNumero = table.Column<int>(nullable: false),
                    EndBairro = table.Column<string>(nullable: true),
                    EndCidade = table.Column<string>(nullable: true),
                    EndEstado = table.Column<string>(nullable: true),
                    EndPais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpresaIdEmpresa = table.Column<int>(nullable: false),
                    Sobrenome = table.Column<string>(nullable: true),
                    EndRua = table.Column<string>(nullable: true),
                    EndNumero = table.Column<string>(nullable: true),
                    EndBairro = table.Column<string>(nullable: true),
                    EndCidade = table.Column<string>(nullable: true),
                    EndEstado = table.Column<string>(nullable: true),
                    EndPais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Empresas_EmpresaIdEmpresa",
                        column: x => x.EmpresaIdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EmpresaIdEmpresa",
                table: "Funcionarios",
                column: "EmpresaIdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
