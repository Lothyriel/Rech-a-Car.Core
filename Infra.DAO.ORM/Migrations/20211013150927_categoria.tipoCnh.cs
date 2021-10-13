using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class categoriatipoCnh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "TBFuncionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(40)");

            migrationBuilder.AlterColumn<int>(
                name: "TipoDeCnh",
                table: "TBCategoria",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "TBFuncionario",
                type: "VARCHAR(40)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoDeCnh",
                table: "TBCategoria",
                type: "VARCHAR(80)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
