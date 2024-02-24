using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProEventos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EVENTOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOCAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATAEVENTO = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    TEMA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QTDPESSOAS = table.Column<int>(type: "int", nullable: false),
                    IMAGEMURL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TELEFONE = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVENTOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PALESTRANTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MINICURRICULO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAGEMURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PALESTRANTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATAINICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATAFIM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOTE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOTE_EVENTOS_EventoId",
                        column: x => x.EventoId,
                        principalTable: "EVENTOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PALESTRANTESEVENTOS",
                columns: table => new
                {
                    PalestranteId = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PALESTRANTESEVENTOS", x => new { x.EventoId, x.PalestranteId });
                    table.ForeignKey(
                        name: "FK_PALESTRANTESEVENTOS_EVENTOS_EventoId",
                        column: x => x.EventoId,
                        principalTable: "EVENTOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PALESTRANTESEVENTOS_PALESTRANTE_PalestranteId",
                        column: x => x.PalestranteId,
                        principalTable: "PALESTRANTE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "REDESOCIAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true),
                    PalestranteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REDESOCIAL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REDESOCIAL_EVENTOS_EventoId",
                        column: x => x.EventoId,
                        principalTable: "EVENTOS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_REDESOCIAL_PALESTRANTE_PalestranteId",
                        column: x => x.PalestranteId,
                        principalTable: "PALESTRANTE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LOTE_EventoId",
                table: "LOTE",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_PALESTRANTESEVENTOS_PalestranteId",
                table: "PALESTRANTESEVENTOS",
                column: "PalestranteId");

            migrationBuilder.CreateIndex(
                name: "IX_REDESOCIAL_EventoId",
                table: "REDESOCIAL",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_REDESOCIAL_PalestranteId",
                table: "REDESOCIAL",
                column: "PalestranteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOTE");

            migrationBuilder.DropTable(
                name: "PALESTRANTESEVENTOS");

            migrationBuilder.DropTable(
                name: "REDESOCIAL");

            migrationBuilder.DropTable(
                name: "EVENTOS");

            migrationBuilder.DropTable(
                name: "PALESTRANTE");
        }
    }
}
