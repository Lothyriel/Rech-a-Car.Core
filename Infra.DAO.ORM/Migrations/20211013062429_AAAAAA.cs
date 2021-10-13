using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class AAAAAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Salt",
                table: "TBSenha",
                type: "VARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BINARY(16)");

            migrationBuilder.AlterColumn<string>(
                name: "Hash",
                table: "TBSenha",
                type: "VARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "STRING");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Salt",
                table: "TBSenha",
                type: "BINARY(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)");

            migrationBuilder.AlterColumn<string>(
                name: "Hash",
                table: "TBSenha",
                type: "STRING",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)");
        }
    }
}
