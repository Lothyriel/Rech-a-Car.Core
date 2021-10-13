using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class trocando_user_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeUsuario",
                table: "TBFuncionario",
                newName: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "TBFuncionario",
                newName: "NomeUsuario");
        }
    }
}
