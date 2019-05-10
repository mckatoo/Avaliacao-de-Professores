using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class AddProfessorDisciplina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Disciplinas_DisciplinaId",
                table: "Professores");

            migrationBuilder.DropIndex(
                name: "IX_Professores_DisciplinaId",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Professores");

            migrationBuilder.CreateTable(
                name: "ProfessorDisciplinas",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorDisciplinas", x => new { x.ProfessorId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_ProfessorDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorDisciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorDisciplinas_DisciplinaId",
                table: "ProfessorDisciplinas",
                column: "DisciplinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessorDisciplinas");

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Professores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professores_DisciplinaId",
                table: "Professores",
                column: "DisciplinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Disciplinas_DisciplinaId",
                table: "Professores",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
