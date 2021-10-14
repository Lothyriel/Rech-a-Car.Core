using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class sexolandia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "TBClientePJ",
                type: "CHAR(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(11)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "TBClientePJ",
                type: "CHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(14)");
        }
    }
}
