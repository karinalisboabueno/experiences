using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorDeTempos.Migrations
{
    public partial class primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCategorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TFuncionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFuncionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TUtilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilizadorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUtilizadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTarefas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRegisto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTarefas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TTarefas_TCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TTarefas_TClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TTarefas_TFuncionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "TFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TTempos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TempoemMin = table.Column<int>(type: "int", nullable: false),
                    TarefaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTempos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TTempos_TTarefas_TarefaId",
                        column: x => x.TarefaId,
                        principalTable: "TTarefas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TTarefas_CategoriaId",
                table: "TTarefas",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TTarefas_ClienteId",
                table: "TTarefas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TTarefas_FuncionarioId",
                table: "TTarefas",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TTempos_TarefaId",
                table: "TTempos",
                column: "TarefaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TTempos");

            migrationBuilder.DropTable(
                name: "TUtilizadores");

            migrationBuilder.DropTable(
                name: "TTarefas");

            migrationBuilder.DropTable(
                name: "TCategorias");

            migrationBuilder.DropTable(
                name: "TClientes");

            migrationBuilder.DropTable(
                name: "TFuncionarios");
        }
    }
}
