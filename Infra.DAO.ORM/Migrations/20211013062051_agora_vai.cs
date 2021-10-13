using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class agora_vai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cargo",
                table: "TBFuncionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(40)");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPlano",
                table: "TBAluguel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cargo",
                table: "TBFuncionario",
                type: "VARCHAR(40)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TipoPlano",
                table: "TBAluguel",
                type: "VARCHAR(20)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
