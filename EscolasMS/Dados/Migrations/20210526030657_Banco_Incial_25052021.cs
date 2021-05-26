using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaMS_Dados.Migrations
{
    public partial class Banco_Incial_25052021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "RESPONSAVEL",
                schema: "dbo",
                columns: table => new
                {
                    ResponsavelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.ResponsavelId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                schema: "dbo",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroCertidaoNova = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    ResponsavelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_RESPONSAVEL_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalSchema: "dbo",
                        principalTable: "RESPONSAVEL",
                        principalColumn: "ResponsavelId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelId",
                schema: "dbo",
                table: "Alunos",
                column: "ResponsavelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RESPONSAVEL",
                schema: "dbo");
        }
    }
}
