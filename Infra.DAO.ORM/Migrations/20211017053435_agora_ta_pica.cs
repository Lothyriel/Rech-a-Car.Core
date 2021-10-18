using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DAO.ORM.Migrations
{
    public partial class agora_ta_pica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    PrecoDiaria = table.Column<double>(type: "FLOAT", nullable: false),
                    PrecoKm = table.Column<double>(type: "FLOAT", nullable: false),
                    PrecoLivre = table.Column<double>(type: "FLOAT", nullable: false),
                    QuilometragemFranquia = table.Column<int>(type: "INT", nullable: false),
                    TipoDeCnh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBDadosCondutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnh_NumeroCnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnh_TipoCnh = table.Column<int>(type: "int", nullable: true),
                    Cnh_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBDadosCondutor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBParceiro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBParceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Telefone = table.Column<string>(type: "CHAR(11)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPessoa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBSenha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salt = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false),
                    Hash = table.Column<string>(type: "VARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSenha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBVeiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Marca = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    Placa = table.Column<string>(type: "CHAR(7)", nullable: false),
                    Chassi = table.Column<string>(type: "CHAR(17)", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    CapacidadeTanque = table.Column<int>(type: "int", nullable: false),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    Porta_malas = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TipoDeCombustivel = table.Column<int>(type: "int", nullable: false),
                    Automatico = table.Column<bool>(type: "bit", nullable: false),
                    Quilometragem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBVeiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBVeiculo_TBCategoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TBCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBMulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DadosCondutorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBMulta_TBDadosCondutor_DadosCondutorId",
                        column: x => x.DadosCondutorId,
                        principalTable: "TBDadosCondutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBCupom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    ValorPercentual = table.Column<int>(type: "int", nullable: false),
                    ValorFixo = table.Column<double>(type: "float", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParceiroId = table.Column<int>(type: "int", nullable: true),
                    ValorMinimo = table.Column<double>(type: "float", nullable: false),
                    Usos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCupom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCupom_TBParceiro_ParceiroId",
                        column: x => x.ParceiroId,
                        principalTable: "TBParceiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCliente_TBPessoa_Id",
                        column: x => x.Id,
                        principalTable: "TBPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Usuario = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Cargo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBFuncionario_TBPessoa_Id",
                        column: x => x.Id,
                        principalTable: "TBPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBClientePF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DadosCondutorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBClientePF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBClientePF_TBCliente_Id",
                        column: x => x.Id,
                        principalTable: "TBCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBClientePF_TBDadosCondutor_DadosCondutorId",
                        column: x => x.DadosCondutorId,
                        principalTable: "TBDadosCondutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBClientePJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBClientePJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBClientePJ_TBCliente_Id",
                        column: x => x.Id,
                        principalTable: "TBCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBAluguel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    DadosCondutorId = table.Column<int>(type: "int", nullable: true),
                    TipoPlano = table.Column<int>(type: "int", nullable: false),
                    DataAluguel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CupomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBCliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TBCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBCupom_CupomId",
                        column: x => x.CupomId,
                        principalTable: "TBCupom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBDadosCondutor_DadosCondutorId",
                        column: x => x.DadosCondutorId,
                        principalTable: "TBDadosCondutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBFuncionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "TBFuncionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBVeiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "TBVeiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBMotorista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    DadosCondutorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMotorista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBMotorista_TBClientePJ_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "TBClientePJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBMotorista_TBDadosCondutor_DadosCondutorId",
                        column: x => x.DadosCondutorId,
                        principalTable: "TBDadosCondutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBMotorista_TBPessoa_Id",
                        column: x => x.Id,
                        principalTable: "TBPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBEnvioRelatorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AluguelId = table.Column<int>(type: "int", nullable: true),
                    StreamAttachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEnvioRelatorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBEnvioRelatorio_TBAluguel_AluguelId",
                        column: x => x.AluguelId,
                        principalTable: "TBAluguel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Taxa = table.Column<double>(type: "float", nullable: false),
                    AluguelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBServico_TBAluguel_AluguelId",
                        column: x => x.AluguelId,
                        principalTable: "TBAluguel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_ClienteId",
                table: "TBAluguel",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_CupomId",
                table: "TBAluguel",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_DadosCondutorId",
                table: "TBAluguel",
                column: "DadosCondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_FuncionarioId",
                table: "TBAluguel",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_VeiculoId",
                table: "TBAluguel",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBClientePF_DadosCondutorId",
                table: "TBClientePF",
                column: "DadosCondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCupom_ParceiroId",
                table: "TBCupom",
                column: "ParceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_TBEnvioRelatorio_AluguelId",
                table: "TBEnvioRelatorio",
                column: "AluguelId");

            migrationBuilder.CreateIndex(
                name: "IX_TBMotorista_DadosCondutorId",
                table: "TBMotorista",
                column: "DadosCondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBMotorista_EmpresaId",
                table: "TBMotorista",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBMulta_DadosCondutorId",
                table: "TBMulta",
                column: "DadosCondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBServico_AluguelId",
                table: "TBServico",
                column: "AluguelId");

            migrationBuilder.CreateIndex(
                name: "IX_TBVeiculo_CategoriaId",
                table: "TBVeiculo",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBClientePF");

            migrationBuilder.DropTable(
                name: "TBEnvioRelatorio");

            migrationBuilder.DropTable(
                name: "TBMotorista");

            migrationBuilder.DropTable(
                name: "TBMulta");

            migrationBuilder.DropTable(
                name: "TBSenha");

            migrationBuilder.DropTable(
                name: "TBServico");

            migrationBuilder.DropTable(
                name: "TBClientePJ");

            migrationBuilder.DropTable(
                name: "TBAluguel");

            migrationBuilder.DropTable(
                name: "TBCliente");

            migrationBuilder.DropTable(
                name: "TBCupom");

            migrationBuilder.DropTable(
                name: "TBDadosCondutor");

            migrationBuilder.DropTable(
                name: "TBFuncionario");

            migrationBuilder.DropTable(
                name: "TBVeiculo");

            migrationBuilder.DropTable(
                name: "TBParceiro");

            migrationBuilder.DropTable(
                name: "TBPessoa");

            migrationBuilder.DropTable(
                name: "TBCategoria");
        }
    }
}
