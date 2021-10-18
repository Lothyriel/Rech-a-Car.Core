using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class chave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId",
                table: "TBServico");

            migrationBuilder.AddColumn<int>(
                name: "AluguelId1",
                table: "TBServico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBServico_AluguelId1",
                table: "TBServico",
                column: "AluguelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId",
                table: "TBServico",
                column: "AluguelId",
                principalTable: "TBAluguel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId1",
                table: "TBServico",
                column: "AluguelId1",
                principalTable: "TBAluguel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId",
                table: "TBServico");

            migrationBuilder.DropForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId1",
                table: "TBServico");

            migrationBuilder.DropIndex(
                name: "IX_TBServico_AluguelId1",
                table: "TBServico");

            migrationBuilder.DropColumn(
                name: "AluguelId1",
                table: "TBServico");

            migrationBuilder.AddForeignKey(
                name: "FK_TBServico_TBAluguel_AluguelId",
                table: "TBServico",
                column: "AluguelId",
                principalTable: "TBAluguel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
