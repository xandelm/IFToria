using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IFToria.Migrations
{
    public partial class create_table_aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CursoMatriculado = table.Column<string>(type: "TEXT", nullable: true),
                    TutoriaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    TutorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Certificado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Duracao = table.Column<int>(type: "INTEGER", nullable: false),
                    Disciplina = table.Column<string>(type: "TEXT", nullable: true),
                    Vagas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutoria_Alunos_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TutoriaId",
                table: "Alunos",
                column: "TutoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutoria_TutorId",
                table: "Tutoria",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Tutoria_TutoriaId",
                table: "Alunos",
                column: "TutoriaId",
                principalTable: "Tutoria",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Tutoria_TutoriaId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "Tutoria");

            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
