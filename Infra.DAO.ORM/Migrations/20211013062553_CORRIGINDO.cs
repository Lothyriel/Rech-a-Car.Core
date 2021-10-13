using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class CORRIGINDO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoCnh",
                table: "TBCnh",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoCnh",
                table: "TBCnh",
                type: "VARCHAR(2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
