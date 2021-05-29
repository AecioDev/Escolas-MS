using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaMS_Dados.Migrations
{
    public partial class Responsavel_Null_28052021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_RESPONSAVEL_ResponsavelId",
                schema: "dbo",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                schema: "dbo",
                newName: "ALUNOS",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_ResponsavelId",
                schema: "dbo",
                table: "ALUNOS",
                newName: "IX_ALUNOS_ResponsavelId");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                schema: "dbo",
                table: "ALUNOS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ALUNOS_RESPONSAVEL_ResponsavelId",
                schema: "dbo",
                table: "ALUNOS",
                column: "ResponsavelId",
                principalSchema: "dbo",
                principalTable: "RESPONSAVEL",
                principalColumn: "ResponsavelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ALUNOS_RESPONSAVEL_ResponsavelId",
                schema: "dbo",
                table: "ALUNOS");

            migrationBuilder.RenameTable(
                name: "ALUNOS",
                schema: "dbo",
                newName: "Alunos",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_ALUNOS_ResponsavelId",
                schema: "dbo",
                table: "Alunos",
                newName: "IX_Alunos_ResponsavelId");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                schema: "dbo",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_RESPONSAVEL_ResponsavelId",
                schema: "dbo",
                table: "Alunos",
                column: "ResponsavelId",
                principalSchema: "dbo",
                principalTable: "RESPONSAVEL",
                principalColumn: "ResponsavelId");
        }
    }
}
